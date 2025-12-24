
namespace Application.Repositories;

/// <summary>
/// INVOICE-PRODUCT REPOSITORY INTERFACE
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// Description: Open source project: .NET-Clean-DevOps-Architecture
/// </remarks>
public interface IInvoiceProductRepository
{
    public Task CreateRecordAsync(int invoiceId, int[] selectedProducts, CancellationToken cancellationToken);
}