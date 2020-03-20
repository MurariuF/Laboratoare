using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryNetCore
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int TotalValue { get; set; }
        public System.DateTime Date { get; set; }
        public int CustomerCustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
