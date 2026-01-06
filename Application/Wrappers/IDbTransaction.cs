namespace Application.Wrappers;

/// <summary>
/// DATABASE TRANSACTION WRAPPER
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// </remarks>
public interface IDbTransaction: IDisposable
{
    Task CommitAsync(CancellationToken cancellationToken = default);
    
    Task RollbackAsync(CancellationToken cancellationToken = default);
}