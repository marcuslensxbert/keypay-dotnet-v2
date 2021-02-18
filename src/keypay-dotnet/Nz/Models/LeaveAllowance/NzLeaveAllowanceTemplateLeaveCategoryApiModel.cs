using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.LeaveAllowance
{
    public class NzLeaveAllowanceTemplateLeaveCategoryApiModel
    {
        public int? AccrualRuleLeaveYearOffsetAmount { get; set; }
        public int LeaveCategoryId { get; set; }
        public string LeaveCategoryName { get; set; }
        public decimal? Units { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAllowanceUnitEnum? UnitType { get; set; }
        public bool CanApplyForLeave { get; set; }
        public decimal? ContingentPeriod { get; set; }
        public decimal? EntitlementPeriod { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualType LeaveAccrualRuleAccrualType { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualCapType LeaveAccrualRuleCapType { get; set; }
        public decimal LeaveAccrualRuleUnitCap { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public LeaveAccrualCarryOverBehaviour LeaveAccrualRuleCarryOverBehaviour { get; set; }
        public decimal LeaveAccrualRuleCarryOverAmount { get; set; }
        public bool LeaveAccrualRuleAccrueInAdvance { get; set; }
    }
}
