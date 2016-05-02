using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class Valve
    {
        public int PartId { get; set; }
        public decimal Step10HighMax { get; set; }
        public decimal Step10HighMin { get; set; }
        public decimal Step10LowMax { get; set; }
        public decimal Step10LowMin { get; set; }
        public decimal Step5mHMax { get; set; }
        public decimal Step5mHMin { get; set; }
        public decimal Step5OhmsMax { get; set; }
        public decimal Step5OhmsMin { get; set; }
        public decimal Step6mHMax { get; set; }
        public decimal Step6mHMin { get; set; }
        public decimal Step6OhmsMax { get; set; }
        public decimal Step6OhmsMin { get; set; }
        public int ValveControlTypeId { get; set; }
        public int ValveFuelTypeId { get; set; }

        public virtual Part Part { get; set; }
        public virtual ValveControlType ValveControlType { get; set; }
        public virtual ValveFuelType ValveFuelType { get; set; }
    }
}
