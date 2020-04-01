using System.Collections.Generic;
using System.ServiceModel;
using Model;
using P1;
namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceDetalii
    {
        [OperationContract]
        bool AddDetalii(Detalii detalii);

        [OperationContract]
        Detalii UpdateDetalii(Detalii detalii);

        [OperationContract]
        bool DeleteDetalii(string name);

        [OperationContract]
        Detalii getDetails(string path);

        [OperationContract]
        List<Detalii> GetDetaliis();
    }

    [ServiceContract]
    interface InterfaceExtras
    {
        [OperationContract]
        bool AddExtras(Extras extras);
        [OperationContract]
        Extras UpdateExtras(Extras newExtras);

        [OperationContract]
        Extras GetExtrasById(int id);
    }

    [ServiceContract]
    interface IDetaliiExtras: InterfaceDetalii, InterfaceExtras
    {

    }
    class InterfaceWCF
    {
    }
}
