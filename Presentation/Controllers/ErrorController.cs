using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers;

/// <summary>
/// CONTROLLER FOR HANDLING ERRORS
/// </summary>
/// <remarks>
/// Author: Luis López  
/// GitHub: https://github.com/luislopez-dev
/// Description: Open source project: .NET-Clean-DevOps-Architecture
/// </remarks>
public class ErrorController: BaseController
{
    public IActionResult NotFound()
    {
        return View();
    }
}