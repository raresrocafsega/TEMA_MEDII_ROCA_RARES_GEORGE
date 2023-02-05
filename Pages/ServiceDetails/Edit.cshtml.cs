using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TEMA_MEDII_ROCA_RARES_GEORGE.Data;
using TEMA_MEDII_ROCA_RARES_GEORGE.Models;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Pages.ServiceDetails
{
    public class EditModel : PageModel
    {
        private readonly TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext _context;

        public EditModel(TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ServiceDetail ServiceDetail { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ServiceDetail == null)
            {
                return NotFound();
            }

            var servicedetail =  await _context.ServiceDetail.FirstOrDefaultAsync(m => m.ID == id);
            if (servicedetail == null)
            {
                return NotFound();
            }
            ServiceDetail = servicedetail;
           ViewData["ServiceID"] = new SelectList(_context.Service, "ID", "Location");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ServiceDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServiceDetailExists(ServiceDetail.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ServiceDetailExists(int id)
        {
          return _context.ServiceDetail.Any(e => e.ID == id);
        }
    }
}
