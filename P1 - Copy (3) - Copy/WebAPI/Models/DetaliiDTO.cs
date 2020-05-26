using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    [DataContract(IsReference = true)]
    public partial class DetaliiDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetaliiDTO()
        {
            this.ExtrasDTO = new HashSet<ExtrasDTO>();
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Path { get; set; }
        [DataMember]
        public string Eveniment { get; set; }
        [DataMember]
        public string Persoane { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Data { get; set; }
        [DataMember]
        public string Peisaje { get; set; }
        [DataMember]
        public string Locatie { get; set; }
        [DataMember]
        public bool Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<ExtrasDTO> ExtrasDTO { get; set; }
    }
}
