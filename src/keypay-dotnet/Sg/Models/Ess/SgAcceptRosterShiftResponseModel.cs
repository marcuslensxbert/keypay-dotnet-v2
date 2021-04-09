using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.Ess
{
    public class SgAcceptRosterShiftResponseModel
    {
        public SgEssRosterShiftModel Shift { get; set; }
        public int ProposedSwapCount { get; set; }
        public int PendingShiftCount { get; set; }
        public int BiddableShiftCount { get; set; }
    }
}
