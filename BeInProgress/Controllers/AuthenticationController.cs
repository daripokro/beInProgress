using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Auth;
using Microsoft.AspNetCore.Identity;

namespace BeInProgress.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;

        public AuthenticationController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this._configuration = configuration;
        }

        //[HttpPost]
        //[Route("login")]
        //public async Task<IActionResult> Login(string returnUrl)

    }
}
