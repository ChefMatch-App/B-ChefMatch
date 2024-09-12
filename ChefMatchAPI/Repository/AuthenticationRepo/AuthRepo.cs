using ChefMatchAPI.Data;

namespace ChefMatchAPI.Repository.AuthenticationRepo
{
    public class AuthRepo : IAuthRepo
    {
        private readonly ApplicationDbContext _context;
        public AuthRepo(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
