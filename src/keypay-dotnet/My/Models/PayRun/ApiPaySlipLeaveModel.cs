using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.PayRun
{
    public class ApiPaySlipLeaveModel
    {
        public string LeaveCategory { get; set; }
        public decimal Amount { get; set; }
        public string Notes { get; set; }
    }
}
