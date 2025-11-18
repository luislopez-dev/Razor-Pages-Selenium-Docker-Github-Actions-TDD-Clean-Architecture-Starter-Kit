/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using Business.Models;
using Business.Validations;

namespace Business.Tests.Validations;

public class ProductValidatorTests
{
    [Fact]
    public void ProductValidator_ReturnsError_WhenNameIsNull()
    {
        // Arrange
        var product = new Product { Name = null, Price = 10, Description = "some description", Stock = 100 };
        var validator = new ProductValidator();

        // Act
        var result = validator.Validate(product);

        // Assert
        Assert.False(result.IsValid);
        
        Assert.Contains(result.Errors, e => 
            e.PropertyName == "Name" && 
            e.ErrorMessage == "¡El nombre del producto no debe estar vacio!");
    }
}

/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
