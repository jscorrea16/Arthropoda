using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ArthrpodaASP.Models;

namespace ArthrpodaASP.Pages.Insects
{
    public class InsectModel : PageModel
    {
        private readonly ArthropodaDbContext _context;

        public InsectModel(ArthrpodaASP.Models.ArthropodaDbContext context)
        {
            _context = context;
        }

        public IList<Order> Orders { get;set; }

        public IList<Familyinsect> Familyinsects {get; set;}

        
        
    }
}