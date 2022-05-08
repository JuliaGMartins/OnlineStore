using Microsoft.AspNetCore.Mvc;
using OnlineStore.Domain.Users.Entities;
using OnlineStore.Domain.Users.Interfaces.Services;
using OnlineStore.Domain.Users.Services;

namespace OnlineStore.API.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {

        private readonly TokenService _tokenService;
        private readonly IUserService _userService;
        public AuthController(TokenService tokenService, IUserService userService)
        {
            _tokenService = tokenService;
            _userService = userService;
        }

        [Route("token")]
        [HttpPost]
        public ActionResult<string> Authenticate([FromBody] User user)
        {
            System.Diagnostics.Debug.WriteLine(user);
            var isValidUser = _userService.ValidateUser(user);
            //if (user.UserName.Equals("Julia") && user.Password.Equals("1234Senha!"))
            if (isValidUser)
            {
                return _tokenService.GenerateToken(user);
            }

            return NotFound();
        }
    }
}
