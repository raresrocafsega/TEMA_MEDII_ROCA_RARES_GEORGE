using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TEMA_MEDII_ROCA_RARES_GEORGE.Data;
using TEMA_MEDII_ROCA_RARES_GEORGE.Models;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Pages.ServiceDetails
{
    public class IndexModel : PageModel
    {
        private readonly TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext _context;

        public IndexModel(TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext context)
        {
            _context = context;
        }

        public IList<ServiceDetail> ServiceDetail { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.ServiceDetail != null)
            {
                ServiceDetail = await _context.ServiceDetail
                .Include(s => s.Services)
                .Include(s => s.ServiceTypes)
                .ToListAsync();
            }
        }
    }
}
