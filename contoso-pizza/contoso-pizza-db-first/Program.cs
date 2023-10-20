using contoso_pizza_db_first.Data;
using contoso_pizza_db_first.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

foreach (Customer c in context.Customers)
{
    Console.WriteLine($"Full name: {c.FullName}");
}
