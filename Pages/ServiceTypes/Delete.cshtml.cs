using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TEMA_MEDII_ROCA_RARES_GEORGE.Data;
using TEMA_MEDII_ROCA_RARES_GEORGE.Models;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Pages.ServiceTypes
{
    public class DeleteModel : PageModel
    {
        private readonly TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext _context;

        public DeleteModel(TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext context)
        {
            _context = context;
        }

        [BindProperty]
      public ServicesType ServicesType { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ServicesType == null)
            {
                return NotFound();
            }

            var servicestype = await _context.ServicesType.FirstOrDefaultAsync(m => m.ID == id);

            if (servicestype == null)
            {
                return NotFound();
            }
            else 
            {
                ServicesType = servicestype;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ServicesType == null)
            {
                return NotFound();
            }
            var servicestype = await _context.ServicesType.FindAsync(id);

            if (servicestype != null)
            {
                ServicesType = servicestype;
                _context.ServicesType.Remove(ServicesType);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
