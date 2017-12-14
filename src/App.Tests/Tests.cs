using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace App.Tests
{
    public class Tests
    {
        [Fact]
        public void AddOrder()
        {
            var context = new OrderContext();
            context.Database.EnsureCreated();

            var order = new Order
            {
                Details = {
                    new OrderDetail { Product = "Product A "},
                    new OrderDetail { Product = "Product B "},
                    new OrderDetail { Product = "Product C "},
                }
            };

            context.Orders.Add(order);
            context.SaveChanges();

            Assert.Equal(3, order.Details.Count());

            //context.OrderDetails.RemoveRange(order.Details);
            order.Details.Clear();
            context.SaveChanges();

            Assert.Equal(Enumerable.Empty<OrderDetail>(), order.Details);
        }
    }
}
