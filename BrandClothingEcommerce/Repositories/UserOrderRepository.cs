using BrandClothingEcommerce.Models.MyIdentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BrandClothingEcommerce.Repositories
{
    public class UserOrderRepository : IUserOrderRepository
    {
        // Контекст базы данных
        private readonly ApplicationDbContext _db;
        // Доступ к текущему HTTP-контексту(тип IHttpContextAccessor),
        // который используется для получения информации о текущем пользователе.
        private readonly IHttpContextAccessor _httpContextAccessor;
        // управление пользовательми
        private readonly UserManager<AppUser> _userManager;

        // Конструктор
        public UserOrderRepository(ApplicationDbContext db, 
                                   UserManager<AppUser> userManager,
                                   IHttpContextAccessor httpContextAccessor) 
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        // Получаем коллекцию заказов
        public async Task<IEnumerable<Order>> UserOrders()
        {
            // Получаем идентификатор пользователя 
            var userId = GetUserId();
            // Проверяем наличие такого пользователя
            if (string.IsNullOrEmpty(userId))
                throw new Exception("User is not logged-in");
            // Запрос на получение и последующий вывод данных о Заказе
            var orders = await _db.Orders
                            .Include(x => x.OrderStatus)
                            .Include(x => x.OrderDetail)
                            .ThenInclude(x => x.Product)
                            .ThenInclude(x => x.TypeOfСlothing)
                            .Where(a => a.UserId == userId)
                            .ToListAsync();
            // Возвращаем коллекцию Заказов
            return orders;
        }

        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(principal);
            return userId;
        }
    }
}
