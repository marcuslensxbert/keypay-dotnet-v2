using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Nz.Models.Common;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using KeyPayV2.Nz.Enums;

namespace KeyPayV2.Nz.Models.ChartOfAccounts
{
    public class JournalAccountModel
    {
        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ExternalAccountType AccountType { get; set; }
        public string ExternalReferenceId { get; set; }
    }
}
