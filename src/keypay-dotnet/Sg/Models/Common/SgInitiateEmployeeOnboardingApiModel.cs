using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Common
{
    public class SgInitiateEmployeeOnboardingApiModel
    {
        public int? EmployingEntityId { get; set; }
        public int? Id { get; set; }
        public int? Title { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public bool QualificationsRequired { get; set; }
        public bool EmergencyContactDetailsRequired { get; set; }
    }
}
