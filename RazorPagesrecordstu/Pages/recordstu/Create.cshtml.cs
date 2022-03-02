#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesrecordstu.Models;

namespace RazorPagesrecordstu.Pages_recordstu
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesrecordstuContext _context;

        public CreateModel(RazorPagesrecordstuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public recordstu recordstu { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.recordstu.Add(recordstu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
