using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAPI.Models;
using ServiceReferenceDetaliExtras;

namespace WebAPI.Pages.Detaliis
{
    public class DeleteModel : PageModel
    {
        DetaliiExtrasClient dec = new DetaliiExtrasClient();
        [BindProperty]
        public DetaliiDTO DetaliiDTO { get; set; }

        public DeleteModel()
        {

        }

        public async Task<IActionResult> OnGetAsync(string? path)
        {
            if(path==null)
            {
                return NotFound();
            }
            var detalii = await dec.getDetaliiAsync(path);
            if(detalii != null)
            {
                DetaliiDTO = new DetaliiDTO();
                DetaliiDTO.Path = detalii.Path;
                DetaliiDTO.Eveniment = detalii.Eveniment;
                DetaliiDTO.Data = detalii.Data;
                DetaliiDTO.Persoane = detalii.Persoane;
                DetaliiDTO.Peisaje = detalii.Peisaje;
                DetaliiDTO.Locatie = detalii.Locatie;
                DetaliiDTO.Deleted = detalii.Deleted;
                return Page();
            }
            else
            {
                return NotFound();
            }
        }
        public async Task<IActionResult> OnDetaliiAsync(string? path)
        {
            if(path == null)
            {
                return NotFound();
            }
            return RedirectToPage("./Index");

        }
    }
}