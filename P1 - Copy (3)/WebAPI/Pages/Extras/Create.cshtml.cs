using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceDetaliExtras;
using WebAPI.Models;

namespace WebAPI.Pages.Extras
{
    public class CreateModel : PageModel
    {
        DetaliiExtrasClient dec = new DetaliiExtrasClient();
        [BindProperty]
        public ExtrasDTO ExtrasDTO { get; set; }
        public CreateModel()
        {
            ExtrasDTO = new ExtrasDTO();
        }
        
        public async Task<IActionResult> OnGetAsync(string? path)
        {
            if(path != null)
            {
                var itemDetalii = await dec.getDetaliiAsync(path);
                ViewData["path"] = path + " : " + itemDetalii.Eveniment;
                ExtrasDTO.DetaliiId = itemDetalii.Id;

            }
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync(string? path)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }

            return RedirectToPage("/Detaliis/Index");
        }

    }
}