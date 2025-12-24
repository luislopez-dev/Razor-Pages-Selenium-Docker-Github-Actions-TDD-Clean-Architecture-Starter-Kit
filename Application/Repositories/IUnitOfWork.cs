using Microsoft.EntityFrameworkCore.Storage;

namespace Application.Repositories;

/// <summary>
/// UNIT OF WORK INTERFACE
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// Description: Open source project: .NET-Clean-DevOps-Architecture
/// </remarks>
public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    
    IInvoiceRepository InvoiceRepository { get; }
    
    IInvoiceProductRepository InvoiceProductRepository { get; }
    
    Task<bool> CompleteAsync(CancellationToken cancellationToken);
    
    bool HasChanges();
    
    IDbContextTransaction BeginTransaction(CancellationToken cancellationToken);
    
}