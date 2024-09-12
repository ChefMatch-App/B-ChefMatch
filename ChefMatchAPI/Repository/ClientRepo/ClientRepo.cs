using ChefMatchAPI.Data;

namespace ChefMatchAPI.Repository.ClientRepo
{
    public class ClientRepo : IClientRepo
    {
        private readonly ApplicationDbContext _context;
        public ClientRepo(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
