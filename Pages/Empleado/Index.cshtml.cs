using GestionRecursosHumanos1.Data;
using GestionRecursosHumanos1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GestionRecursosHumanos1.Pages.Empleado
{
    public class IndexModel : PageModel
    {
        private readonly GestionRecursosContext _context;

        public IndexModel(GestionRecursosContext context)
        {
            _context = context;
        }

        public IList<Empleados> Empleados { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Empleado != null)
            {
                Empleados = await _context.Empleado.ToListAsync();
            }
        }

    }
}
