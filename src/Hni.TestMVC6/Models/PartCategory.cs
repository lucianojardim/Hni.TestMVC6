using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class PartCategory
    {
        public PartCategory()
        {
            Part = new HashSet<Part>();
        }

        public int PartCategoryId { get; set; }
        public string PartCategoryDesc { get; set; }

        public virtual ICollection<Part> Part { get; set; }
    }
}
