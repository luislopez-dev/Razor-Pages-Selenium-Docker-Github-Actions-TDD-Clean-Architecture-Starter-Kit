/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using Business.Models;

namespace Business.Interfaces;

/// <summary>
/// 
/// </summary>
public interface IInvoiceRepository
{
    public Task AddInvoice(Invoice invoice, CancellationToken cancellationToken);
    public Task<List<Invoice>> GetInvoicesPaginatedAsync(CancellationToken cancellationToken);
}

/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
