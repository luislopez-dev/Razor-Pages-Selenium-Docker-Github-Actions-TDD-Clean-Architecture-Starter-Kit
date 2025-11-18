/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using FluentValidation.Results;

namespace Business.Exceptions.Product.Exceptions;

public class ProductValidationException: ValidationException
{
    public ProductValidationException(List<ValidationFailure> failures) : base(failures)
    {
    }
}


/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
