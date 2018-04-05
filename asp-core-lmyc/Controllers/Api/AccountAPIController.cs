using System.Threading.Tasks;
using asp_core_lmyc.Models;
using asp_core_lmyc.Models.AccountViewModels;
using asp_core_lmyc.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace asp_core_lmyc.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/AccountAPI")]
    public class AccountAPIController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;

        public AccountAPIController(
            UserManager<ApplicationUser> userManager,
            IEmailSender emailSender,
            ILogger<AccountAPIController> logger)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            _logger = logger;
        }

        // POST api/AccountAPI/Register
        [HttpPost]
        [AllowAnonymous]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Street = model.Street,
                City = model.City,
                Province = model.Province,
                PostalCode = model.PostalCode,
                Country = model.Country,
                MobileNumber = model.MobileNumber,
                SailingExperience = model.SailingExperience
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest();
            }

            _logger.LogInformation("User created a new account with password.");
            await _userManager.AddToRoleAsync(user, "Member");

            return Ok();
        }
    }
}