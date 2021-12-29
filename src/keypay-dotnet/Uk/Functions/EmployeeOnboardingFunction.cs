using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using RestSharp;
using KeyPayV2.Common;
using KeyPayV2.Common.Models;
using KeyPayV2.Uk.Enums;
using KeyPayV2.Uk.Models.Common;

namespace KeyPayV2.Uk.Functions
{
    public class EmployeeOnboardingFunction : BaseFunction
    {
        public EmployeeOnboardingFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// Initiate Employee Self Setup
        /// </summary>
        /// <remarks>
        /// Initiate the Self Setup process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public void InitiateEmployeeSelfSetup(int businessId, InitiateEmployeeOnboardingApiModel model)
        {
            ApiRequest($"/business/{businessId}/employeeonboarding/initiateselfservice", model, Method.POST);
        }

        /// <summary>
        /// Initiate Employee Self Setup
        /// </summary>
        /// <remarks>
        /// Initiate the Self Setup process for an Employee.
        /// If the employee has an existing employee record, the id should be specified. If the Email and Mobile provided
        /// are not the same as those on the employee record, they will be updated.
        /// If the employee does not yet have an employee record do not specify an id, one will be created with the
        /// details provided.
        /// </remarks>
        public Task InitiateEmployeeSelfSetupAsync(int businessId, InitiateEmployeeOnboardingApiModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/business/{businessId}/employeeonboarding/initiateselfservice", model, Method.POST, cancellationToken);
        }
    }
}
