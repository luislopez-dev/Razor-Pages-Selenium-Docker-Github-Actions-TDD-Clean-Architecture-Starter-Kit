/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using FluentValidation.Results;

namespace Business.Exceptions.Invoice.Exceptions.ValidationExceptions;

public class InvoiceValidationException: ValidationException
{
    public InvoiceValidationException(List<ValidationFailure> failures) : base(failures)
    {
    }
}

/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
