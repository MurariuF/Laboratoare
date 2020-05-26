using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAPI.Models;
using ServiceReferenceDetaliExtras;
using System.Security.Policy;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebAPI.Pages.Detaliis
{
    public class IndexModel : PageModel
    {
        DetaliiExtrasClient dec = new DetaliiExtrasClient();
        public List<DetaliiDTO> Detaliis { get; set; }
        public List<string> propSorted { get; set; }
        public string SearchString { get; set; }
        public SelectList Eveniment { get; set; }
        public string DetaliiEveniment { get; set; }

        public IndexModel()
        {
            Detaliis = new List<DetaliiDTO>();
        }

        public string NameSort { get; set; }
        public string DateSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }

        public async Task OnGetAsync(string sortOrder)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            DateSort = sortOrder == "Date" ? "date_Desc" : "Date";
            var detaliis = await dec.getAllDetaliiAsync();
            switch (sortOrder)
            {
                case "name_desc":
                    var ordered = detaliis.OrderBy(f => f.Path);
                    break;
                case "date_desc":
                    ordered = detaliis.OrderBy(s => s.Data);
                    break;
            }

            foreach(var item in detaliis)
            {
                DetaliiDTO dd = new DetaliiDTO();
                dd.Id = item.Id;
                dd.Path = item.Path;
                dd.Eveniment = item.Eveniment;
                dd.Persoane = item.Persoane;
                dd.Data = item.Data;
                dd.Peisaje = item.Peisaje;
                dd.Locatie = item.Locatie;
                dd.Deleted = item.Deleted;
                //if(!string.IsNullOrEmpty(dd.Eveniment))
                //{
                //    dd = dec.getDetaliiAsync(path)
                //}
                foreach(var cc in item.Extras)
                {
                    ExtrasDTO edto = new ExtrasDTO();
                    edto.Nume = cc.Nume;
                    edto.Valoare = cc.Valoare;
                    edto.DetaliiId = cc.DetaliiId;
                    dd.ExtrasDTO.Add(edto);
                }
                Detaliis.Add(dd);
            }
            HashSet<string> proprietati = new HashSet<string>();
         
            foreach(var item in Detaliis)
            {
                proprietati.Add(item.Eveniment);
                proprietati.Add(item.Peisaje);
                proprietati.Add(item.Persoane);
                proprietati.Add(item.Locatie);
            }
            propSorted = proprietati.ToList();
            propSorted.Sort();
        }
    }
}