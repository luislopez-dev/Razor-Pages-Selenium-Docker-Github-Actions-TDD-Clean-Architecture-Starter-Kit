using System.Transactions;
using Application.Exceptions.Invoice.Exceptions;
using Application.Interfaces;
using Application.Repositories;
using Domain.Entities;
using FluentValidation;
using FluentValidation.Results;

namespace Application.Services;


/// <summary>
/// INVOICE APPLICATION SERVICE 
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// </remarks>
public class InvoiceService: IInvoiceService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IValidator<Invoice> _validator;

    public InvoiceService(IUnitOfWork unitOfWork, IValidator<Invoice> validator)
    {
        _unitOfWork = unitOfWork;
        _validator = validator;
    }

    public async Task AddInvoiceAsync(Invoice invoice, int[] selectedProducts, CancellationToken cancellationToken)
    { 
        cancellationToken.ThrowIfCancellationRequested();
        
        // Start Validations
        ValidationResult validation = await _validator
            .ValidateAsync(invoice, cancellationToken);
        
        if (!validation.IsValid)
            throw new InvoiceValidationException(validation.Errors);
            
        // Begin Transaction
        using var transaction = await _unitOfWork.BeginTransactionAsync(cancellationToken);
        
        try
        {
            // Create Invoice
            await _unitOfWork
                .InvoiceRepository
                .AddInvoice(invoice, cancellationToken);
            await _unitOfWork.CompleteAsync(cancellationToken);

            // Assign products to newly created invoice
            await _unitOfWork
                .InvoiceProductRepository
                .CreateRecordAsync(invoice.Id, selectedProducts, cancellationToken);
            await _unitOfWork.CompleteAsync(cancellationToken);

            // Commit transaction if previous operations succeed
            await transaction.CommitAsync(cancellationToken);
        }
        catch (TransactionException e)
        {
            await transaction.RollbackAsync(cancellationToken);
            
        }
    }

    public async Task<List<Invoice>> GetInvoicesPaginatedAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();
        
        return await _unitOfWork
                .InvoiceRepository
                .GetInvoicesPaginatedAsync(cancellationToken);
    }
}