using System;
using System.Collections.Generic;

namespace Hni.TestMVC6.Models
{
    public partial class PartReceived
    {
        public int PartReceivedId { get; set; }
        public int AuditorId { get; set; }
        public decimal DateCode { get; set; }
        public DateTime IncomingDate { get; set; }
        public string IndividualPartComments { get; set; }
        public int InspectionTypeId { get; set; }
        public decimal InspectorNum { get; set; }
        public decimal? InspectorNum2 { get; set; }
        public int PartId { get; set; }
        public string RedTagNum { get; set; }
        public DateTime SampleInspectionEntryDate { get; set; }
        public string SerialNumber { get; set; }
        public int VendorId { get; set; }
        public short WasTestedId { get; set; }
        public int WhereFoundId { get; set; }

        public virtual ValveTestResults ValveTestResults { get; set; }
        public virtual Auditor Auditor { get; set; }
        public virtual InspectionType InspectionType { get; set; }
        public virtual Part Part { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual WasTested WasTested { get; set; }
        public virtual WhereFound WhereFound { get; set; }
    }
}
