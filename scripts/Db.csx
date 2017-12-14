#! "netcoreapp2.0"
#r "nuget:NetStandard.Library,2.0.0"
#r "nuget:Microsoft.EntityFrameworkCore,2.0.1"
#r "nuget:Microsoft.EntityFrameworkCore.Sqlite,2.0.1"

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

class Order { 
    public int Id { set;get; }
    public List<OrderDetail> Details { set; get; } = new List<OrderDetail>();
}

class OrderDetail { 
    public int Id { set;get; }
    public string Product { set;get; }
}

class OrderContext : DbContext { 
    public DbSet<Order> Orders { set;get; }
    public DbSet<OrderDetail> OrderDetails { set;get; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=Order.db");
    }
}

var context = new OrderContext();
context.Database.EnsureCreated();
context.Orders.Add(new Order { });
context.SaveChanges();