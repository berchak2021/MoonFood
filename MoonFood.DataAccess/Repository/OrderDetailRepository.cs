using MoonFood.DataAccess.Repository.IRepository;
using MoonFood.Models;

namespace MoonFood.DataAccess.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private ApplicationDbContext _db;
        public OrderDetailRepository(ApplicationDbContext param): base(param)
        {
            _db = param;
        }
        public void Update(OrderDetail obj)
        {
           _db.OrderDetail.Update(obj);
        }
    }
}
