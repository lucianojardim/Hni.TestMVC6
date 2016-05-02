using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class InspectionType
    {
        public InspectionType()
        {
            PartReceived = new HashSet<PartReceived>();
        }

        public int InspectionTypeId { get; set; }
        public string InspectionTypeDesc { get; set; }

        public virtual ICollection<PartReceived> PartReceived { get; set; }
    }
}
