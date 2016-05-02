using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class ValveTestResults
    {
        public int PartReceivedId { get; set; }
        public short Step03TestResultId { get; set; }
        public decimal? Step05mH { get; set; }
        public decimal? Step05Ohms { get; set; }
        public decimal? Step06mH { get; set; }
        public decimal? Step06Ohms { get; set; }
        public short Step08TestResultId { get; set; }
        public decimal? Step10High { get; set; }
        public decimal? Step10Low { get; set; }
        public short Step11TestResultId { get; set; }
        public short Step13TestResultId { get; set; }

        public virtual PartReceived PartReceived { get; set; }
        public virtual PassFail03 Step03TestResult { get; set; }
        public virtual PassFail08 Step08TestResult { get; set; }
        public virtual PassFail11 Step11TestResult { get; set; }
        public virtual PassFail13 Step13TestResult { get; set; }
    }
}
