using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Uk.Models.Common;
using KeyPayV2.Uk.Enums;

namespace KeyPayV2.Uk.Models.EmployerLiabilityCategories
{
    public class EmployerLiabilityCategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ExternalReferenceId { get; set; }
        public bool CanBeDeleted { get; set; }
        public bool HideFromPaySlips { get; set; }
        public bool ShowTotalPayments { get; set; }
        public bool IncludeInShiftCosts { get; set; }
    }
}
