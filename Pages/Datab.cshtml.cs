using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCrafts.Data1;
using ContosoCrafts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCrafts.Pages
{
    public class DatabModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ProductsContext _context;
        public IList<Product> Products { get; set; }
        public DatabModel(ILogger<IndexModel> logger, ProductsContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            Products = _context.Product.ToList();
        }
    }
}
