using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.My.Models.Common;
using KeyPayV2.My.Enums;

namespace KeyPayV2.My.Models.Employee
{
    public class CreateOrUpdateEmployeeQueryModel
    {
        public EmployeeMatchType MatchType { get; set; }
    }
}
