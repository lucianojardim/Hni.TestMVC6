using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class PassFail11
    {
        public PassFail11()
        {
            ValveTestResults = new HashSet<ValveTestResults>();
        }

        public short PassFail11Id { get; set; }
        public string PassFail11Desc { get; set; }

        public virtual ICollection<ValveTestResults> ValveTestResults { get; set; }
    }
}
