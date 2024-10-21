using Auth.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenService;
        public AuthController(IUserService userService, ITokenService tokenService)
        {
            _userService = userService;
            _tokenService = tokenService;
        }
        [HttpPost]
        public IActionResult Login([FromForm] string username, [FromForm] string password)
        {
            var user = _userService.Authenticate(username, password);

            if (user == null)
            {
                return Unauthorized("Invalid Credentials");
            }
            var token = _tokenService.GenerateToken(user.UserName, user.Role);
            return Ok(new { Token = token });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
