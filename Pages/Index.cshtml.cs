using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using ArthrpodaASP.Models;

namespace Arthropoda.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ArthropodaDbContext _context;
        private readonly ILogger<IndexModel> _logger;

        public List<InfraOrder> InfraOrders { get;set; }

        public List<Family> Familys {get; set;}

        public List<Genera> Generas {get; set;}

        public IndexModel(ArthropodaDbContext context, ILogger<IndexModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void OnGet()
        {
            InfraOrders = _context.InfraOrders.ToList();
            Familys = _context.Familys.ToList();
            Generas = _context.Generas.ToList();
        }
    }
}
