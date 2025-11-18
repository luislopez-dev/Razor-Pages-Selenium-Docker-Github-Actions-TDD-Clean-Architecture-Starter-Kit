using Business.Interfaces;
using Business.Models;
using Business.UseCases;

namespace Application.UseCases;

/// <summary>
/// 
/// </summary>
public class CreateProductUseCase : ICreateProductUseCase
{

    private IProductService productService;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task InvokeAsync(Product product, CancellationToken cancellationToken)
    {
        await productService.AddProductAsync(product, cancellationToken);
    }
}