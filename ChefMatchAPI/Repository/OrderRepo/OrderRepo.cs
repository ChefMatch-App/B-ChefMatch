using ChefMatchAPI.Data;

namespace ChefMatchAPI.Repository.OrderRepo
{
    public class OrderRepo : IOrderRepo
    {
        private readonly ApplicationDbContext _context;
        public OrderRepo(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
