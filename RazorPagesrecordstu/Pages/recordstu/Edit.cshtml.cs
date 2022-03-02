#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesrecordstu.Models;

namespace RazorPagesrecordstu.Pages_recordstu
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesrecordstuContext _context;

        public EditModel(RazorPagesrecordstuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public recordstu recordstu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            recordstu = await _context.recordstu.FirstOrDefaultAsync(m => m.ID == id);

            if (recordstu == null)
            {
                return NotFound();
            }
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

            _context.Attach(recordstu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!recordstuExists(recordstu.ID))
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

        private bool recordstuExists(int id)
        {
            return _context.recordstu.Any(e => e.ID == id);
        }
    }
}
