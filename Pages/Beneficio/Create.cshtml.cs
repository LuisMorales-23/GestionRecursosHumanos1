using GestionRecursosHumanos1.Data;
using GestionRecursosHumanos1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GestionRecursosHumanos1.Pages.Beneficio
{
    public class CreateModel : PageModel
    {
        private readonly GestionRecursosContext _context;

        public CreateModel(GestionRecursosContext context)
        {
            this._context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Beneficios Beneficio { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Beneficio == null || Beneficio == null)
            {
                return Page();
            }

            _context.Beneficio.Add(Beneficio);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

