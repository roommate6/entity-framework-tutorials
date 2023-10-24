using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using contoso_pizza_performance_tips.Data;
using contoso_pizza_performance_tips.Models;

namespace contoso_pizza_performance_tips.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly contoso_pizza_performance_tips.Data.ContosoPizzaContext _context;

        public DetailsModel(contoso_pizza_performance_tips.Data.ContosoPizzaContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id, int customerId)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            CustomerId = customerId;

            Product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);

            if (Product == null)
            {
                return NotFound();
            }

            if (CustomerId > 0)
            {
                Customer = await _context.Customers
                    .FromSqlInterpolated($"SELECT * FROM Customers WHERE Id = {CustomerId}") // tip: you can add your own sql
                    .FirstOrDefaultAsync();
            }

            return Page();
        }
    }
}
