using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations.Model;

namespace P1.APIStatic
{
    public class API : IDisposable
    {
        private Model3Container context;

        public API()
        {
            this.context = new Model3Container();
        }

        public Detalii getDetails(string path)
        {

            var query = context.Detaliis
                                .Where(s => s.Path == path)
                                .FirstOrDefault<Detalii>();
            return query;

        }


        public Detalii addDetalii(Detalii d)
        {
            if (getDetails(d.Path) == null)
            {
                //Console.WriteLine(" Nu Am adaugat");
                return context.Detaliis.Add(d);
            }
            else
            {
                //Console.WriteLine("Este adaugat");
                return null;
            }
                  
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            //Console.WriteLine("Am salvat");
            context.SaveChanges();
        }
        public void AddExtra(Detalii d, Extras e)
        {
            d.Extras.Add(e);

        }

        public void UpdateDetalii(Detalii d)
        {
            Detalii b = getDetails(d.Path);
            b.Peisaje = d.Peisaje;
            b.Eveniment = d.Eveniment;
            b.Persoane = d.Persoane;
            b.Locatie = d.Locatie;
            context.SaveChanges();
        }
        public List<Detalii> getAllDetalii()
        {
            return context.Detaliis.ToList();
        }
    }
}
