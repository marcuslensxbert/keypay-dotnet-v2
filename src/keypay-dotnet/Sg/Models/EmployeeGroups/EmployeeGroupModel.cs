using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.EmployeeGroups
{
    public class EmployeeGroupModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FilterCombinationStrategyEnum FilterCombinationStrategy { get; set; }
        public IList<EmployeeFilterModel> Filters { get; set; }
    }
}
