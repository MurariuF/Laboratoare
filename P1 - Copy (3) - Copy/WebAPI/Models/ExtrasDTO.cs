using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [DataContract(IsReference = true)]
    public partial class ExtrasDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nume { get; set; }
        [DataMember]
        public string Valoare { get; set; }
        [DataMember]
        public int DetaliiId { get; set; }

        [DataMember]
        public virtual DetaliiDTO DetaliiDTO { get; set; }
    }
}
