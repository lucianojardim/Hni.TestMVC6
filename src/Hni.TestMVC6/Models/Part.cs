using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class Part
    {
        public Part()
        {
            PartReceived = new HashSet<PartReceived>();
        }

        public int PartId { get; set; }
        public int PartCategoryId { get; set; }
        public string PartNumber { get; set; }

        public virtual ICollection<PartReceived> PartReceived { get; set; }
        public virtual Valve Valve { get; set; }
        public virtual PartCategory PartCategory { get; set; }
    }
}
