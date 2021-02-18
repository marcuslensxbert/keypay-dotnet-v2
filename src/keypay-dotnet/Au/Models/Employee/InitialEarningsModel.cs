using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Employee
{
    public class InitialEarningsModel
    {
        public int PayCategoryId { get; set; }
        public bool IsStandardPayCategory { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public PayCategoryType PayCategoryType { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
