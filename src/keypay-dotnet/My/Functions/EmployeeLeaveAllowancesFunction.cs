using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.My.Enums;
using KeyPayV2.My.Models.Common;

namespace KeyPayV2.My.Functions
{
    public class EmployeeLeaveAllowancesFunction : BaseFunction
    {
        public EmployeeLeaveAllowancesFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Get Leave Allowances
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for the specified employee
        /// </remarks>
        public List<MyLeaveAllowanceModel> GetLeaveAllowances(int businessId, int employeeId)
        {
            return ApiRequest<List<MyLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances", Method.GET);
        }

        /// <summary>
        /// Get Leave Allowances
        /// </summary>
        /// <remarks>
        /// Gets the leave allowances for the specified employee
        /// </remarks>
        public Task<List<MyLeaveAllowanceModel>> GetLeaveAllowancesAsync(int businessId, int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<MyLeaveAllowanceModel>>($"/business/{businessId}/employee/{employeeId}/leaveallowances", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public void SetLeaveAllowances(int businessId, int employeeId, IList<MyLeaveAllowanceModel> leaveAllowances)
        {
            ApiRequest($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.PUT);
        }

        /// <summary>
        /// Set Leave Allowances
        /// </summary>
        /// <remarks>
        /// Sets the leave allowances for the specified employee
        /// </remarks>
        public Task SetLeaveAllowancesAsync(int businessId, int employeeId, IList<MyLeaveAllowanceModel> leaveAllowances, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employee/{employeeId}/leaveallowances", leaveAllowances, Method.PUT, cancellationToken);
        }
    }
}
