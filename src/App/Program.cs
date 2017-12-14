using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App
{
    public class Order
    {
        [Key]
        public int Id { set; get; }
        public List<OrderDetail> Details { set; get; } = new List<OrderDetail>();
    }

    public class OrderDetail
    {
        [Key]
        public int Id { set; get; }
        public string Product { set; get; }
    }

    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetail> OrderDetails { set; get; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Order.db");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
