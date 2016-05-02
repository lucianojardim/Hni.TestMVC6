using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class WhereFound
    {
        public WhereFound()
        {
            PartReceived = new HashSet<PartReceived>();
        }

        public int WhereFoundId { get; set; }
        public string WhereFoundDesc { get; set; }

        public virtual ICollection<PartReceived> PartReceived { get; set; }
    }
}
