using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDRazorPages.DB;
using CRUDRazorPages.Models;

namespace CRUDRazorPages.Pages.ProductMaster
{
    public class IndexModel : PageModel
    {
        private readonly CRUDRazorPages.DB.AppDbContext _context;

        public IndexModel(CRUDRazorPages.DB.AppDbContext context)
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
