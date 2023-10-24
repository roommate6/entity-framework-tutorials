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
    public class IndexModel : PageModel
    {
        private readonly contoso_pizza_performance_tips.Data.ContosoPizzaContext _context;

        public IndexModel(contoso_pizza_performance_tips.Data.ContosoPizzaContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
