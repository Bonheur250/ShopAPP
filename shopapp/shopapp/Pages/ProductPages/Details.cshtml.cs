using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using shopapp.Data;
using shopapp.Model;

namespace shopapp.Pages_ProductPages
{
    public class DetailsModel : PageModel
    {
        private readonly shopapp.Data.ProductContext _context;

        public DetailsModel(shopapp.Data.ProductContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.product.FirstOrDefaultAsync(m => m.id == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
