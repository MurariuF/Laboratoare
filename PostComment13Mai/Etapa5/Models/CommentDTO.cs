using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Etapa5.Models
{
    public class CommentDTO
    {
        public int PostId { get; set; }
        public string Text { get; set; }
        public int PostPostId { get; set; }

        public virtual PostDTO Post { get; set; }
    }
}
