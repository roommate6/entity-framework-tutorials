using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using contoso_pizza_performance_tips.Models;

namespace contoso_pizza_performance_tips.Data;

public partial class ContosoPizzaContext : DbContext
{
    public ContosoPizzaContext()
    {
    }

    public ContosoPizzaContext(DbContextOptions<ContosoPizzaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    public virtual DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
