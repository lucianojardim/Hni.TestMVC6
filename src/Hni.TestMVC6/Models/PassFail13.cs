using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class PassFail13
    {
        public PassFail13()
        {
            ValveTestResults = new HashSet<ValveTestResults>();
        }

        public short PassFail13Id { get; set; }
        public string PassFail13Desc { get; set; }

        public virtual ICollection<ValveTestResults> ValveTestResults { get; set; }
    }
}
