using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceDetaliExtras;
using WebAPI.Models;

namespace WebAPI.Pages.Detaliis
{
    public class CreateModel : PageModel
    {
        DetaliiExtrasClient dec = new DetaliiExtrasClient();
        [BindProperty]
        public DetaliiDTO DetaliiDTO { get; set; }
        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(ModelState.IsValid)
            {
                return Page();
            }
            Detalii detalii = new Detalii();
            detalii.Path = DetaliiDTO.Path;
            detalii.Eveniment = DetaliiDTO.Eveniment;
            detalii.Persoane = DetaliiDTO.Persoane;
            detalii.Data = DetaliiDTO.Data;
            detalii.Peisaje = DetaliiDTO.Peisaje;
            detalii.Locatie = DetaliiDTO.Locatie;
            detalii.Deleted = DetaliiDTO.Deleted;

            var result = await dec.addDetaliiAsync(detalii);
            if (result == null)
            {
                return RedirectToAction("Error");
            }
            return RedirectToPage("./Index");
        }
    }
}