using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class PassFail08
    {
        public PassFail08()
        {
            ValveTestResults = new HashSet<ValveTestResults>();
        }

        public short PassFail08Id { get; set; }
        public string PassFail08Desc { get; set; }

        public virtual ICollection<ValveTestResults> ValveTestResults { get; set; }
    }
}
