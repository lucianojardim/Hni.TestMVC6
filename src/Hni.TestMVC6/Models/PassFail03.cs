using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class PassFail03
    {
        public PassFail03()
        {
            ValveTestResults = new HashSet<ValveTestResults>();
        }

        public short PassFail03Id { get; set; }
        public string PassFail03Desc { get; set; }

        public virtual ICollection<ValveTestResults> ValveTestResults { get; set; }
    }
}
