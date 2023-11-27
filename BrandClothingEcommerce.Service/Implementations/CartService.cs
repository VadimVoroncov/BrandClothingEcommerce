using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpdatedWebBCE.DAL;
using UpdatedWebBCE.Domain.Entity;
using UpdatedWebBCE.Service.Interfaces;

namespace UpdatedWebBCE.Service.Implementations
{
    public class CartService : ICartService
    {
        private readonly AppDbContext _db;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CartRepository(AppDbContext db,
                              IHttpContextAccessor httpContextAccessor,
                              UserManager<IdentityUser> userManager)
        {
            _db = db;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        #region Добавление товара (AddItem)
        public async Task<int> AddItem(int productId, int qty)
        {
            string userId = GetUserId();
            using var transaction = _db.Database.BeginTransaction();// Чекай внизу 
            try
            {
                // Проверяем есть ли id
                if (string.IsNullOrEmpty(userId))
                    throw new Exception("user is not logger-in");

                var cart = await GetCart(userId);
                // Если корзина null тогда создаём новую
                if (cart is null)
                {
                    // Закрепляем пользователя с корзиной 
                    cart = new ShoppingCart { UserId = userId };
                    _db.ShoppingCarts.Add(cart);
                }
                _db.SaveChanges();

                // cart detail section
                var cartItem = _db.CartDetails.FirstOrDefault(a => a.ProductId == productId &&
                                                              a.ShoppingCartId == cart.Id);
                // Если у нас есть запись и она соответствует id ProductId и id ShoppingCartId
                if (cartItem is not null)
                    cartItem.Quantity += qty;// Добавляем
                                             // Иначе создаём новый экземпляр
                else
                {
                    var product = _db.Products.Find(productId);
                    cartItem = new CartDetail
                    {
                        ProductId = productId,
                        ShoppingCartId = cart.Id,
                        Quantity = qty,
                        UnitPrice = product.Price
                    };
                    _db.CartDetails.Add(cartItem);
                }
                _db.SaveChanges();
                transaction.Commit();// Также внизу

            }
            catch (Exception ex)
            {

            }
            var cartItemCount = await GetCartItemCount(userId);
            return cartItemCount;

        }
        #endregion

        #region Удаление товара (RemoveItem)
        public async Task<int> RemoveItem(int productId)
        {
            //using var transaction = _db.Database.BeginTransaction();
            string userId = GetUserId();
            try
            {
                // Проверяем есть ли id
                if (string.IsNullOrEmpty(userId))
                    throw new Exception("user is not logged-in");

                var cart = await GetCart(userId);
                // Проверяем наличие данных в бд о корзине пользователя
                if (cart is null) throw new Exception("invalid cart");

                // cart detail section
                var cartItem = _db.CartDetails.
                    FirstOrDefault(a => a.ProductId == productId &&
                                        a.ShoppingCartId == cart.Id);
                // Проверяем наличие товара в корзине
                if (cartItem is null) throw new Exception("not items in cart");

                // Если в корзине только один экземляр товара тогда мы удалим его из бд 
                else if (cartItem.Quantity == 1)
                    _db.CartDetails.Remove(cartItem);

                // Если больше одного тогда просто вычтим
                else cartItem.Quantity = cartItem.Quantity - 1;

                //Сохраняем изменения в бд
                _db.SaveChanges();

            }
            catch (Exception ex)
            {

            }
            var cartItemCount = await GetCartItemCount(userId);
            return cartItemCount;
        }
        #endregion

        #region Получение карточки пользователя (GetUserCart)
        public async Task<ShoppingCart> GetUserCart()
        {
            var userId = GetUserId();
            // Проверочка пользователя
            if (userId == null)
                throw new Exception("Invalid userId");
            // Совмещаем таблицы
            var shoppingCart = await _db.ShoppingCarts.Include(a => a.CartDetails)
                                                .ThenInclude(a => a.Product)
                                                .ThenInclude(a => a.TypeOfСlothing)
                                                .Where(a => a.UserId == userId)
                                                .FirstOrDefaultAsync();
            return shoppingCart;
        }
        #endregion

        public async Task<int> GetCartItemCount(string userId = "")
        {
            if (!string.IsNullOrEmpty(userId))
            {
                userId = GetUserId();
            }
            var data = await (from cart in _db.ShoppingCarts
                              join cartDetail in _db.CartDetails
                              on cart.Id equals cartDetail.ShoppingCartId
                              select new { cartDetail.Id }).ToListAsync();

            return data.Count;
        }

        // Получение данных о корзине пользователя через id
        public async Task<ShoppingCart> GetCart(string userId)
        {
            var cart = await _db.ShoppingCarts.FirstOrDefaultAsync(x => x.UserId == userId);
            return cart;
        }

        public async Task<bool> DoCheckout()
        {
            using var transaction = _db.Database.BeginTransaction();
            try
            {
                var userId = GetUserId();
                if (string.IsNullOrEmpty(userId))
                    throw new Exception("User is not logged-in");

                var cart = await GetCart(userId);
                if (cart is null)
                    throw new Exception("Invalid cart");
                var cartDetail = _db.CartDetails
                                    .Where(a => a.ShoppingCartId == cart.Id).ToList();
                if (cartDetail.Count == 0)
                    throw new Exception("Cart is empty");
                var order = new Order
                {
                    UserId = userId,
                    CreateDate = DateTime.UtcNow,
                    OrderStatusId = 1
                };
                _db.Orders.Add(order);
                _db.SaveChanges();
                foreach (var item in cartDetail)
                {
                    var orderDetail = new OrderDetail
                    {
                        ProductId = item.ProductId,
                        OrderId = order.Id,
                        Quantity = item.Quantity,
                        UnitPrice = item.UnitPrice,
                    };
                    _db.OrderDetails.Add(orderDetail);
                }
                _db.SaveChanges();

                _db.CartDetails.RemoveRange(cartDetail);
                _db.SaveChanges();
                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        // Получение id пользователя
        private string GetUserId()
        {
            var principal = _httpContextAccessor.HttpContext.User;
            string userId = _userManager.GetUserId(principal);
            return userId;
        }
    }
}


#region Объяснение для AddItem
/* BeginTransaction в Entity Framework представляет собой метод,
 * который позволяет начать новую транзакцию базы данных.
 * Транзакция - это набор операций, которые должны быть выполнены как единое целое.
 * Если одна из операций не выполнится, то все изменения,
 * внесенные в базу данных в рамках этой транзакции, будут отменены.
 * Метод BeginTransaction используется для создания новой транзакции и получения объекта Transaction,
 * который может использоваться для управления этой транзакцией.*/

/*Commit в Entity Framework означает подтверждение транзакции базы данных.
 * Когда все операции в рамках транзакции успешно выполнены, вызывается метод Commit,
 * который сохраняет изменения в базе данных и завершает транзакцию.
 * Если в процессе выполнения транзакции возникли ошибки, то метод Commit не будет вызван,
 * и все изменения будут отменены при откате транзакции.*/
#endregion