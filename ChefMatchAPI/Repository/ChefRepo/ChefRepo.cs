using ChefMatchAPI.Data;

namespace ChefMatchAPI.Repository.ChefRepo
{
    public class ChefRepo : IChefRepo
    {
        private readonly ApplicationDbContext _context;
        public ChefRepo(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
