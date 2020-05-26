using System.Collections.Generic;
using System.ServiceModel;
using P1;
using P1.APIStatic;

namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceDetalii
    {
        [OperationContract]
        Detalii getDetalii(string path);

        [OperationContract]
        Detalii addDetalii(Detalii d);

        [OperationContract]
        List<Detalii> getAllDetalii();

        [OperationContract]
        void UpdateDetalii(Detalii d);
        
        [OperationContract]
        void Save();

        [OperationContract]
        void Dispose();

    }

    [ServiceContract]
    interface InterfaceExtras
    {
        [OperationContract]
        void AddExtras(Detalii d, Extras extra);

    }

    [ServiceContract]
    interface IDetaliiExtras : InterfaceDetalii, InterfaceExtras
    {
    }

}
