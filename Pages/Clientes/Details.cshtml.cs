using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUDSimples.Model;

namespace ProjetoCRUD.Pages_Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly AplicationDbContext _context;

        public DetailsModel(AplicationDbContext context)
        {
            _context = context;
        }

        public Clientes Clientes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientes = await _context.Clientes.FirstOrDefaultAsync(m => m.Id == id);

            if (clientes is not null)
            {
                Clientes = clientes;

                return Page();
            }

            return NotFound();
        }
    }
}
