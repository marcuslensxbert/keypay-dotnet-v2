using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Manager
{
    public class EstimateLeaveHoursQueryModel
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public int LeaveCategoryId { get; set; }
    }
}
