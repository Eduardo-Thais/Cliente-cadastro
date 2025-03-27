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
    public class IndexModel : PageModel
    {
        private readonly AplicationDbContext _context;

        public IndexModel(AplicationDbContext context)
        {
            _context = context;
        }

        public IList<Clientes> Clientes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Clientes = await _context.Clientes.ToListAsync();
        }
    }
}
