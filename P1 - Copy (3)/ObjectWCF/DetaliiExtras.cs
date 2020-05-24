using P1;
using P1.APIStatic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectWCF
{
    public class DetaliiExtras : IDetaliiExtras
    {
        API a = new API();


        Detalii InterfaceDetalii.addDetalii(Detalii d)
        {
            return a.addDetalii(d);
        }

        Detalii InterfaceDetalii.getDetalii(string path)
        {
            return a.getDetails(path);
        }

        List<Detalii> InterfaceDetalii.getAllDetalii()
        {
            return a.getAllDetalii();
        }

        void InterfaceDetalii.Save()
        {
            a.Save();
        }
        
        void InterfaceDetalii.Dispose()
        {
            a.Dispose();
        }

        void InterfaceDetalii.UpdateDetalii(Detalii d)
        {
            a.UpdateDetalii(d);
        }

        public void AddExtras(Detalii d, Extras extra)
        {
            throw new NotImplementedException();
        }
    }
}
