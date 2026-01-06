using Application.Wrappers;

namespace Infrastructure.Wrappers;

using Microsoft.EntityFrameworkCore.Storage;

/// <summary>
/// EF DATABASE TRANSACTION WRAPPER IMPLEMENTATION
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// </remarks>
public class DbTransactionWrapper : IDbTransaction
{
    private readonly IDbContextTransaction _efTransaction;

    public DbTransactionWrapper(IDbContextTransaction efTransaction)
    {
        _efTransaction = efTransaction ?? throw new ArgumentNullException(nameof(efTransaction));
    }

    public async Task CommitAsync(CancellationToken cancellationToken = default)
    {
        await _efTransaction.CommitAsync(cancellationToken);
    }

    public async Task RollbackAsync(CancellationToken cancellationToken = default)
    {
        await _efTransaction.RollbackAsync(cancellationToken);
    }

    public void Dispose()
    {
        _efTransaction.Dispose();
    }
}