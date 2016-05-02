using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class ValveControlType
    {
        public ValveControlType()
        {
            Valve = new HashSet<Valve>();
        }

        public int ValveControlTypeId { get; set; }
        public string ValveControlTypeDesc { get; set; }

        public virtual ICollection<Valve> Valve { get; set; }
    }
}
