using contoso_pizza_db_providers.Data;
using contoso_pizza_db_providers.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();
context.Database.EnsureCreated();

Product veggieSpecial = new Product()
{
    Name = "Veggie Special Pizza",
    Price = 8.59M
};
context.Products.Add(veggieSpecial);

Product superTuna = new Product()
{
    Name = "Super Tuna Pizza",
    Price = 10.00M
};
context.Add(superTuna);

context.SaveChanges();
