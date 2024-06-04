using Events.IO.Domain.Core.Bus;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.Hosts.Commands;
using Events.IO.Domain.Interface;
using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Web.Mvc;
namespace Events.IO.Services.Api.Controllers
{
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly ILogger _logger;
        private readonly IBus _bus;

        public AccountController(UserManager<ApplicationUser> userManager, ILoggerFactory loggerFactory,
            SignInManager<ApplicationUser> signManager,
            IDomainNotificationHandler<DomainNotification>
            notifications, ILogger logger, IBus bus, IUser user) : base(notifications, user, bus)
        {
            _userManager = userManager;
            _signManager = signManager;
            _bus = bus;

            _logger = loggerFactory.CreateLogger<AccountController>();

        }

        [System.Web.Mvc.HttpPost]
        [AllowAnonymous]
        [System.Web.Mvc.Route("new-account")]
        public async Task<IActionResult> Register([FromBody] RegisterViewModel model, int version)
        {
            if(version == 2)
            {
                return Response(new { Message = "API v2 doesnt exist" });
            }
            if (!ModelState.IsValid) return Response(model);
            var user = new ApplicationUser { UserName = model.Email, Email = model.Email };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                //TODO: Fix this
                var registerComamand = new RegistryHostCommand(Guid.Parse(user.Id), model.Email, model.Password, model.ConfirmPassword);
                _bus.SendCommand(registerComamand);

                if (!ValideOperation())
                {
                    await _userManager.DeleteAsync(user);
                    return Response(model);
                }
                _logger.LogInformation(1, "User registered.");
                return Response(model);
            }
            return Response(model);
        }

        [System.Web.Mvc.HttpPost]
        [AllowAnonymous]
        [System.Web.Mvc.Route("account")]
        public async Task<IActionResult> Login([FromBody] RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                NotifyErrorInvalidModel();
                return Response(model);
            }
            var result = await _signManager.PasswordSignInAsync(model.Email, model.Password, false, true);
            if (result.Succeeded)
            {
                _logger.LogInformation(1, "User logged");
                return Response(model);
            }

            NotifyErrors(result.ToString(), "Fail to login");
            return Response(model);
        }

        protected void AddErrors(IdentityResult result)
        {

            foreach (var error in result.Errors)
            {
                NotifyErrors(result.ToString(), error.Description);
            }
        }
    }
}
