using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations.Model;
using Model;

namespace P1
{
    public class API: IDisposable
    {
        private Model1Container context;

        public API()
        {
            this.context = new Model1Container();
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

                return context.Detaliis.Add(d);
        }

        //public void UpdateDetalii(Detalii d)
        //{
        //    (from p in context.Detaliis
        //     where p.Path == d.Path
        //     select p).ToList()
        //     .ForEach(x => x.Eveniment = d.Eveniment);
        //}
        //public void UpdateDetalii(Detalii d)
        //{

        //}
        public void Dispose()
        {
            context.Dispose();
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
