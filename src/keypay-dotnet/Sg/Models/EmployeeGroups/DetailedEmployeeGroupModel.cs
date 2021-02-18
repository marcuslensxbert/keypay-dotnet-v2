using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeGroups
{
    public class DetailedEmployeeGroupModel
    {
        public IList<MatchingEmployeeModel> MatchingEmployees { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public FilterCombinationStrategyEnum FilterCombinationStrategy { get; set; }
        public IList<EmployeeFilterModel> Filters { get; set; }
    }
}
