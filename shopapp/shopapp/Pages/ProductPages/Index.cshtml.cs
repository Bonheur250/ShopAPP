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
    public class IndexModel : PageModel
    {
        private readonly shopapp.Data.ProductContext _context;

        public IndexModel(shopapp.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.product.ToListAsync();
        }
    }
}
