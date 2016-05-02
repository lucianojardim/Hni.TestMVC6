using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class Auditor
    {
        public Auditor()
        {
            PartReceived = new HashSet<PartReceived>();
        }

        public int AuditorId { get; set; }
        public string AuditorName { get; set; }

        public virtual ICollection<PartReceived> PartReceived { get; set; }
    }
}
