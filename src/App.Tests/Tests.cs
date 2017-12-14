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


            //order.Details.Clear();
            context.OrderDetails.RemoveRange(order.Details);

            context.SaveChanges();
            Assert.Equal(Enumerable.Empty<OrderDetail>(), order.Details);

            order.Details.Add(new OrderDetail { Product = "A" });
            order.Details.Add(new OrderDetail { Product = "B" });
            order.Details.Add(new OrderDetail { Product = "C" });
            order.Details.Add(new OrderDetail { Product = "D" });
            order.Details.Add(new OrderDetail { Product = "E" });
            context.SaveChanges();
            Assert.Equal(5, order.Details.Count());
        }
    }
}
