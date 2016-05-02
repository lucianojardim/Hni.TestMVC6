using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class WasTested
    {
        public WasTested()
        {
            PartReceived = new HashSet<PartReceived>();
        }

        public short WasTestedId { get; set; }
        public string WasTestedDesc { get; set; }

        public virtual ICollection<PartReceived> PartReceived { get; set; }
    }
}
