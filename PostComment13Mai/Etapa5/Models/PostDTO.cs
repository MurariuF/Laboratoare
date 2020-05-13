using ServiceReferencePostComment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa5.Models
{
    public class PostDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PostDTO()
        {
            this.Comments = new HashSet<Comment>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public System.DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
