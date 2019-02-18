using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WomenAccessoriesShop.Models.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AccessoriesDbContext _dbContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(AccessoriesDbContext dbContext, ShoppingCart shoppingCart)
        {
            _dbContext = dbContext;
            _shoppingCart = shoppingCart;
        }


        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _dbContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetails()
                {
                    Amount = shoppingCartItem.Amount,
                    PieId = shoppingCartItem.Accessory.AccessoryId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Accessory.Price
                };

                _dbContext.OrderDetails.Add(orderDetail);
            }

            _dbContext.SaveChanges();
        }
    }
}
