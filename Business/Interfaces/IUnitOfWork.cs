/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using Microsoft.EntityFrameworkCore.Storage;

namespace Business.Interfaces;

public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    
    IInvoiceRepository InvoiceRepository { get; }
    
    IInvoiceProductRepository InvoiceProductRepository { get; }
    
    Task<bool> CompleteAsync(CancellationToken cancellationToken);
    
    bool HasChanges();
    
    IDbContextTransaction BeginTransaction(CancellationToken cancellationToken);
    
}

/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */
