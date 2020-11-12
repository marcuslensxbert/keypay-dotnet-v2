using System;
using System.Collections.Generic;
using System.Net.Http;
using KeyPayV2.Au.Models.Common;
using KeyPayV2.Au.Enums;

namespace KeyPayV2.Au.Models.Manager
{
    public class GetBusinessExpenseRequestsQueryModel
    {
        public EmployeeExpenseRequestStatus? Status { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? LocationId { get; set; }
        public int? ExpenseCategoryId { get; set; }
        public EmployeeExpenseRequestGroupBy? GroupBy { get; set; }
        public int CurrentPage { get; set; }
        public int? PageSize { get; set; }
    }
}
