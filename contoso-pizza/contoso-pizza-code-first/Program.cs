using contoso_pizza.Data;
using contoso_pizza.Models;

using ContosoPizzaContext context = new ContosoPizzaContext();

#region Add products to DB

//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};

//context.Products.Add(veggieSpecial);

//Product deluxeMeat = new Product()
//{
//    Name = "Deluxe Meat Pizza",
//    Price = 12.99M
//};
//context.Products.Add(deluxeMeat);

//context.SaveChanges();

#endregion

#region Get products from DB

# region Fluent API

//var products = context.Products
//    .Where(p => p.Price > 10.00M)
//    .OrderBy(p => p.Name);

#endregion

# region LINQ

//var products2 = from product in context.Products
//                where product.Price > 10.00M
//                orderby product.Name
//                select product;

#endregion

//foreach (Product p in products)
//{
//    Console.WriteLine($"Id:    {p.Id}");
//    Console.WriteLine($"Name:  {p.Name}");
//    Console.WriteLine($"Price: {p.Price}");
//    Console.WriteLine(new string('-', 20));
//}

#endregion

#region Update product from DB

//var veggieSpecial = context.Products
//    .Where (p => p.Name == "Veggie Special Pizza")
//    .FirstOrDefault();

//if (veggieSpecial is Product)
//{
//    veggieSpecial.Price = 10.99M;
//}

//context.SaveChanges();

#endregion

#region Delete product from DB

//var veggieSpecial = context.Products
//    .Where(p => p.Name == "Veggie Special Pizza")
//    .FirstOrDefault();

//if (veggieSpecial is Product)
//{
//    context.Remove(veggieSpecial);
//}

//context.SaveChanges();

#endregion

#region Get products from DB

# region Fluent API

var products = context.Products
    .Where(p => p.Price > 10.00M)
    .OrderBy(p => p.Name);

#endregion

# region LINQ

//var products2 = from product in context.Products
//                where product.Price > 10.00M
//                orderby product.Name
//                select product;

#endregion

foreach (Product p in products)
{
    Console.WriteLine($"Id:    {p.Id}");
    Console.WriteLine($"Name:  {p.Name}");
    Console.WriteLine($"Price: {p.Price}");
    Console.WriteLine(new string('-', 20));
}

#endregion
