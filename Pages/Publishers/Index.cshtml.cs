﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Barbu_Nicoleta_Lab9.Data;
using Barbu_Nicoleta_Lab9.Models;

namespace Barbu_Nicoleta_Lab9.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Barbu_Nicoleta_Lab9.Data.Barbu_Nicoleta_Lab9Context _context;

        public IndexModel(Barbu_Nicoleta_Lab9.Data.Barbu_Nicoleta_Lab9Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
