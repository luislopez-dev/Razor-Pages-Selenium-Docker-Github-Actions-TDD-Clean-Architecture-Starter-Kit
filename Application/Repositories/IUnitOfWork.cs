using Application.Wrappers;

namespace Application.Repositories;

/// <summary>
/// UNIT OF WORK INTERFACE
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// : 
/// </remarks>
public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    
    IInvoiceRepository InvoiceRepository { get; }
    
    IInvoiceProductRepository InvoiceProductRepository { get; }
    
    Task<bool> CompleteAsync(CancellationToken cancellationToken);
    
    bool HasChanges();
    
    Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken);    
}