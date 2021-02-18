using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Ess
{
    public class IrasPaymentSummaryModel
    {
        public int Id { get; set; }
        public int IrasSnapshotId { get; set; }
        public string Period { get; set; }
        public string FormType { get; set; }
        public string DownloadUrl { get; set; }
    }
}
