using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TEMA_MEDII_ROCA_RARES_GEORGE.Data;
using TEMA_MEDII_ROCA_RARES_GEORGE.Models;

namespace TEMA_MEDII_ROCA_RARES_GEORGE.Pages.ServiceDetails
{
    public class CreateModel : PageModel
    {
        private readonly TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext _context;

        public CreateModel(TEMA_MEDII_ROCA_RARES_GEORGE.Data.TEMA_MEDII_ROCA_RARES_GEORGEContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ServiceID"] = new SelectList(_context.Service, "ID", "Name");
            ViewData["ServiceTypeID"] = new SelectList(_context.ServiceType, "ID", "Type");
            return Page();
        }

        [BindProperty]
        public ServiceDetail ServiceDetail { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {

          if (!ModelState.IsValid)
          {
            return Page();
          }

            _context.ServiceDetail.Add(ServiceDetail);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
