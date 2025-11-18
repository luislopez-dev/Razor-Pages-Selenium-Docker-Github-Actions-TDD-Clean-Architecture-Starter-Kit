/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using Business.Models;

namespace Business.Interfaces;

public interface IInvoiceService
{
    public Task AddInvoiceAsync(Invoice invoice, int[] selectedProducts, CancellationToken cancellationToken);
    public Task<List<Invoice>> GetInvoicesPaginatedAsync(CancellationToken cancellationToken);
}