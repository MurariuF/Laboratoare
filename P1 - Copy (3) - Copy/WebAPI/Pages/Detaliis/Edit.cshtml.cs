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
    public class EditModel : PageModel
    {
        DetaliiExtrasClient dec = new DetaliiExtrasClient();
        [BindProperty]
        public DetaliiDTO DetaliiDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(string path)
        {
            if (path == null)
            {
                return NotFound();
            }
            return Page();
        }


    }
}