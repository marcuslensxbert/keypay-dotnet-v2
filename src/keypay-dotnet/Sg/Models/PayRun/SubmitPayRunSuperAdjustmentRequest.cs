using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.PayRun
{
    public class SubmitPayRunSuperAdjustmentRequest
    {
        public Dictionary<string,List<SuperAdjustmentModel>> SuperAdjustments { get; set; }
        public int PayRunId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public IdType EmployeeIdType { get; set; }
        public bool ReplaceExisting { get; set; }
        public bool SuppressCalculations { get; set; }
    }
}
