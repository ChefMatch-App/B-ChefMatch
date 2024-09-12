using ChefMatchAPI.Repository.AuthenticationRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChefMatchAPI.Controllers
{
    [Route("api/account")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthRepo _authRepo;
        public AccountController(IAuthRepo authRepo)
        {
            _authRepo = authRepo;
        }
    }
}
