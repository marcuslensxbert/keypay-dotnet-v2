using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.Reporting
{
    public class EmployeeDetailsReportRequestModel
    {
        public List<String> SelectedColumns { get; set; }
        public int LocationId { get; set; }
        public int? EmployingEntityId { get; set; }
        public bool IncludeActive { get; set; }
        public bool IncludeInactive { get; set; }
    }
}
