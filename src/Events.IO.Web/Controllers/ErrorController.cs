using Events.IO.Domain.Interface;
using Events.IO.Infra.CrossCutting.Identity.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Events.IO.Web.Controllers
{
    public class ErrorController : Controller
    {
        private readonly IUser _user;

        public ErrorController(IUser user)
        {
            _user = user;
        }
        [Route("/error-of-application")]
        [Route("/error-of-application/{id}")]
        public IActionResult Errors(string id)
        {
            switch (id)
            {
                case "404":
                    return View("NotFound");
                case "403":
                case "401":
                    if (!_user.IsAuthenticated()) return RedirectToAction("Login", "Account");
                    return View("AccessDenied");
            }

            return View("Error");
        }

    }
}
