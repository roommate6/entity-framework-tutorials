using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using contoso_pizza_asp_net.Data;
using contoso_pizza_asp_net.Models;

namespace contoso_pizza_asp_net.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly contoso_pizza_asp_net.Data.ContosoPizzaContext _context;

        public DetailsModel(contoso_pizza_asp_net.Data.ContosoPizzaContext context)
        {
            _context = context;
        }

      public Product Product { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            {
                Product = product;
            }
            return Page();
        }
    }
}
