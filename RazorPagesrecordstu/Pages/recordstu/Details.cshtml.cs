#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesrecordstu.Models;

namespace RazorPagesrecordstu.Pages_recordstu
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesrecordstuContext _context;

        public DetailsModel(RazorPagesrecordstuContext context)
        {
            _context = context;
        }

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
    }
}
