using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using KeyPayV2.Sg.Models.Common;
using KeyPayV2.Sg.Enums;

namespace KeyPayV2.Sg.Models.ChartOfAccounts
{
    public class SgChartOfAccountsLocationGroupModel
    {
        public SgChartOfAccountsLocationAccountsModel DefaultAccounts { get; set; }
        public int LocationId { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> PayCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> DeductionCategories { get; set; }
        public List<ChartOfAccountsLocationCategoryModel> EmployeeExpenseCategories { get; set; }
        public List<ChartOfAccountsLiabilityLocationCategoryModel> EmployerLiabilityCategories { get; set; }
    }
}
