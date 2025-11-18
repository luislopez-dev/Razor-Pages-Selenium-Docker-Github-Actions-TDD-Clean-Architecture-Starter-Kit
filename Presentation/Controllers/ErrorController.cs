/*
 * Author: Luis René López
 * Website: https://github.com/luislopez-dev
 * Description: Open source Project
 */

using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

public class ErrorController: BaseController
{
    public IActionResult NotFound()
    {
        return View();
    }
}


/*
 ** Author: Luis René López
 ** Website: https://github.com/luislopez-dev
 ** Description: Open source Project
 */
