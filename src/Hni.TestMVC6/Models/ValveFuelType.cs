using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class ValveFuelType
    {
        public ValveFuelType()
        {
            Valve = new HashSet<Valve>();
        }

        public int ValveFuelTypeId { get; set; }
        public string ValveFuelTypeDesc { get; set; }

        public virtual ICollection<Valve> Valve { get; set; }
    }
}
