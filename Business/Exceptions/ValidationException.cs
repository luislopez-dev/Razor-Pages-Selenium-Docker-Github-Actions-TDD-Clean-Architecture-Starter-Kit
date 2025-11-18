/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using FluentValidation.Results;

namespace Business.Exceptions;

public class ValidationException: Exception
{
    public List<ValidationFailure> ValidationFailures { get; }

    public ValidationException(List<ValidationFailure> validationFailures)
    {
        ValidationFailures = validationFailures;
    }
}

/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
