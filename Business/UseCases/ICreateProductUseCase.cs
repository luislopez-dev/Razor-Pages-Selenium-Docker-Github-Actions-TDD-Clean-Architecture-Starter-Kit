using Business.Models;

namespace Business.UseCases;

public interface ICreateProductUseCase
{
    Task InvokeAsync(Product product, CancellationToken cancellationToken);
}