using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            PartReceived = new HashSet<PartReceived>();
        }

        public int VendorId { get; set; }
        public string VendorDesc { get; set; }

        public virtual ICollection<PartReceived> PartReceived { get; set; }
    }
}
