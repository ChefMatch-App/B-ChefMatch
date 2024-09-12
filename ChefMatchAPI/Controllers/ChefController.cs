using ChefMatchAPI.Repository.AuthenticationRepo;
using ChefMatchAPI.Repository.ChefRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChefMatchAPI.Controllers
{
    [Route("api/chef")]
    [ApiController]
    public class ChefController : ControllerBase
    {
        private readonly IChefRepo _chefRepo;
        public ChefController(IChefRepo chefRepo)
        {
            _chefRepo = chefRepo;
        }
    }
}
