#nullable disable

using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesrecordstu.Models;

namespace RazorPagesrecordstu.Pages_recordstu
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesrecordstuContext _context;

        public IndexModel(RazorPagesrecordstuContext context)
        {
            _context = context;
        }

        public IList<recordstu> recordstu { get;set; }

        public async Task OnGetAsync()
        {
            recordstu = await _context.recordstu.ToListAsync();
        }
    }
}
