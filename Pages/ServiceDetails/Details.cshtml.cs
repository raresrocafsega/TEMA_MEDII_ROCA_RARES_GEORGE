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
    public class DetailsModel : PageModel
    {
        private readonly TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext _context;

        public DetailsModel(TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext context)
        {
            _context = context;
        }

      public ServiceDetail ServiceDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ServiceDetail == null)
            {
                return NotFound();
            }

            var servicedetail = await _context.ServiceDetail.FirstOrDefaultAsync(m => m.ID == id);
            if (servicedetail == null)
            {
                return NotFound();
            }
            else 
            {
                ServiceDetail = servicedetail;
            }
            return Page();
        }
    }
}
