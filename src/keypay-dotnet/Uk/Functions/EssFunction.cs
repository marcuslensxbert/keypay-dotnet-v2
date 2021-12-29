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
using KeyPayV2.Uk.Models.Ess;

namespace KeyPayV2.Uk.Functions
{
    public class EssFunction : BaseFunction
    {
        public EssFunction(ApiRequestExecutor api) : base(api) {}

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public List<UkEssBankAccountModel> ListBankAccounts(int employeeId)
        {
            return ApiRequest<List<UkEssBankAccountModel>>($"/ess/{employeeId}/bankaccounts", Method.GET);
        }

        /// <summary>
        /// List Bank Accounts
        /// </summary>
        /// <remarks>
        /// Lists all of the bank accounts for this employee.
        /// </remarks>
        public Task<List<UkEssBankAccountModel>> ListBankAccountsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEssBankAccountModel>>($"/ess/{employeeId}/bankaccounts", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public UkEssSaveBankAccountResponseModel CreateBankAccount(int employeeId, UkEssBankAccountModel model)
        {
            return ApiRequest<UkEssSaveBankAccountResponseModel,UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts", model, Method.POST);
        }

        /// <summary>
        /// Create Bank Account
        /// </summary>
        /// <remarks>
        /// Creates a new bank account for the employee.
        /// </remarks>
        public Task<UkEssSaveBankAccountResponseModel> CreateBankAccountAsync(int employeeId, UkEssBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssSaveBankAccountResponseModel,UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public UkEssBankAccountModel GetBankAccountById(int employeeId, int bankAccountId)
        {
            return ApiRequest<UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.GET);
        }

        /// <summary>
        /// Get Bank Account by ID
        /// </summary>
        /// <remarks>
        /// Gets the bank account for this employee with the specified ID.
        /// </remarks>
        public Task<UkEssBankAccountModel> GetBankAccountByIdAsync(int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public UkEssSaveBankAccountResponseModel DeleteBankAccount(int employeeId, int bankAccountId)
        {
            return ApiRequest<UkEssSaveBankAccountResponseModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Bank Account
        /// </summary>
        /// <remarks>
        /// Deletes the employee's bank account with the specified ID.
        /// </remarks>
        public Task<UkEssSaveBankAccountResponseModel> DeleteBankAccountAsync(int employeeId, int bankAccountId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssSaveBankAccountResponseModel>($"/ess/{employeeId}/bankaccounts/{bankAccountId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public UkEssSaveBankAccountResponseModel UpdateBankAccount(int employeeId, int id, UkEssBankAccountModel model)
        {
            return ApiRequest<UkEssSaveBankAccountResponseModel,UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{id}", model, Method.PUT);
        }

        /// <summary>
        /// Update Bank Account
        /// </summary>
        /// <remarks>
        /// Updates the employee's bank account with the specified ID.
        /// </remarks>
        public Task<UkEssSaveBankAccountResponseModel> UpdateBankAccountAsync(int employeeId, int id, UkEssBankAccountModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssSaveBankAccountResponseModel,UkEssBankAccountModel>($"/ess/{employeeId}/bankaccounts/{id}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the employee may need for self setup tasks.
        /// </remarks>
        public UkDashboardModel GetDashboard(int employeeId)
        {
            return ApiRequest<UkDashboardModel>($"/ess/{employeeId}/dashboard", Method.GET);
        }

        /// <summary>
        /// Get Dashboard
        /// </summary>
        /// <remarks>
        /// Gets a set of useful information that the employee may need for self setup tasks.
        /// </remarks>
        public Task<UkDashboardModel> GetDashboardAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkDashboardModel>($"/ess/{employeeId}/dashboard", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Details
        /// </summary>
        /// <remarks>
        /// Gets ESS details for the specified employee.
        /// </remarks>
        public EssEmployeeDetailsModel GetDetails(int employeeId)
        {
            return ApiRequest<EssEmployeeDetailsModel>($"/ess/{employeeId}/details", Method.GET);
        }

        /// <summary>
        /// Get Details
        /// </summary>
        /// <remarks>
        /// Gets ESS details for the specified employee.
        /// </remarks>
        public Task<EssEmployeeDetailsModel> GetDetailsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssEmployeeDetailsModel>($"/ess/{employeeId}/details", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Save Details
        /// </summary>
        /// <remarks>
        /// Saves any employee details that the employee is allowed to set.
        /// </remarks>
        public UkUnstructuredEmployeeModel SaveDetails(int employeeId, EmployeePartialEditModel model)
        {
            return ApiRequest<UkUnstructuredEmployeeModel,EmployeePartialEditModel>($"/ess/{employeeId}/details", model, Method.POST);
        }

        /// <summary>
        /// Save Details
        /// </summary>
        /// <remarks>
        /// Saves any employee details that the employee is allowed to set.
        /// </remarks>
        public Task<UkUnstructuredEmployeeModel> SaveDetailsAsync(int employeeId, EmployeePartialEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkUnstructuredEmployeeModel,EmployeePartialEditModel>($"/ess/{employeeId}/details", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List all Documents
        /// </summary>
        /// <remarks>
        /// Lists all documents visible to this employee, including both business and employee documents.
        /// </remarks>
        public List<EssDocumentModel> ListAllDocuments(int employeeId)
        {
            return ApiRequest<List<EssDocumentModel>>($"/ess/{employeeId}/document", Method.GET);
        }

        /// <summary>
        /// List all Documents
        /// </summary>
        /// <remarks>
        /// Lists all documents visible to this employee, including both business and employee documents.
        /// </remarks>
        public Task<List<EssDocumentModel>> ListAllDocumentsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssDocumentModel>>($"/ess/{employeeId}/document", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Document Details by ID
        /// </summary>
        /// <remarks>
        /// Gets details for the specified document which is visible to the employee.
        /// </remarks>
        public EssDocumentModel GetDocumentDetailsById(int employeeId, string documentId)
        {
            return ApiRequest<EssDocumentModel>($"/ess/{employeeId}/document/{documentId}", Method.GET);
        }

        /// <summary>
        /// Get Document Details by ID
        /// </summary>
        /// <remarks>
        /// Gets details for the specified document which is visible to the employee.
        /// </remarks>
        public Task<EssDocumentModel> GetDocumentDetailsByIdAsync(int employeeId, string documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssDocumentModel>($"/ess/{employeeId}/document/{documentId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Acknowledge Document
        /// </summary>
        /// <remarks>
        /// Acknowledges the document with the specified ID as having been read by the employee.
        /// </remarks>
        public void AcknowledgeDocument(int employeeId, string documentId)
        {
            ApiRequest($"/ess/{employeeId}/document/acknowledge/{documentId}", Method.POST);
        }

        /// <summary>
        /// Acknowledge Document
        /// </summary>
        /// <remarks>
        /// Acknowledges the document with the specified ID as having been read by the employee.
        /// </remarks>
        public Task AcknowledgeDocumentAsync(int employeeId, string documentId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/document/acknowledge/{documentId}", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the employee.
        /// </remarks>
        public byte[] DownloadDocument(int employeeId, string documentId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/download/{documentId}", Method.GET);
        }

        /// <summary>
        /// Download Document
        /// </summary>
        /// <remarks>
        /// Downloads the document with the specified ID so long as it is visible to the employee.
        /// </remarks>
        public Task<byte[]> DownloadDocumentAsync(int employeeId, string documentId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/ess/{employeeId}/document/download/{documentId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Leaving employee form PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the leaving employee form
        /// </remarks>
        public byte[] GetLeavingEmployeeFormPdf(int employeeId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/LeavingEmployeeForm", Method.GET);
        }

        /// <summary>
        /// Get Leaving employee form PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the leaving employee form
        /// </remarks>
        public Task<byte[]> GetLeavingEmployeeFormPdfAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/ess/{employeeId}/document/LeavingEmployeeForm", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get P11D form PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the P11D form for the specified tax year ending
        /// </remarks>
        public byte[] GetP11dFormPdf(int employeeId, int taxYear)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/p11d/{taxYear}", Method.GET);
        }

        /// <summary>
        /// Get P11D form PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the P11D form for the specified tax year ending
        /// </remarks>
        public Task<byte[]> GetP11dFormPdfAsync(int employeeId, int taxYear, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/ess/{employeeId}/document/p11d/{taxYear}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List P11D forms
        /// </summary>
        /// <remarks>
        /// Lists all the employee's P11D forms.
        /// </remarks>
        public List<EssP11DModel> ListP11dForms(int employeeId)
        {
            return ApiRequest<List<EssP11DModel>>($"/ess/{employeeId}/document/p11ds", Method.GET);
        }

        /// <summary>
        /// List P11D forms
        /// </summary>
        /// <remarks>
        /// Lists all the employee's P11D forms.
        /// </remarks>
        public Task<List<EssP11DModel>> ListP11dFormsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssP11DModel>>($"/ess/{employeeId}/document/p11ds", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get P60 certificate PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the P60 certificate with the specified ID.
        /// </remarks>
        public byte[] GetP60CertificatePdf(int employeeId, int documentId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/P60/{documentId}", Method.GET);
        }

        /// <summary>
        /// Get P60 certificate PDF
        /// </summary>
        /// <remarks>
        /// Gets the PDF for the P60 certificate with the specified ID.
        /// </remarks>
        public Task<byte[]> GetP60CertificatePdfAsync(int employeeId, int documentId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/ess/{employeeId}/document/P60/{documentId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get P60 certificates
        /// </summary>
        /// <remarks>
        /// List all the employee's P60 certificates.
        /// </remarks>
        public List<EssP60Model> GetP60Certificates(int employeeId)
        {
            return ApiRequest<List<EssP60Model>>($"/ess/{employeeId}/document/p60s", Method.GET);
        }

        /// <summary>
        /// Get P60 certificates
        /// </summary>
        /// <remarks>
        /// List all the employee's P60 certificates.
        /// </remarks>
        public Task<List<EssP60Model>> GetP60CertificatesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssP60Model>>($"/ess/{employeeId}/document/p60s", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Pay Slips
        /// </summary>
        /// <remarks>
        /// Lists all pay slips for the employee.
        /// </remarks>
        public List<EssPayslipModel> ListPaySlips(int employeeId)
        {
            return ApiRequest<List<EssPayslipModel>>($"/ess/{employeeId}/document/payslip", Method.GET);
        }

        /// <summary>
        /// List Pay Slips
        /// </summary>
        /// <remarks>
        /// Lists all pay slips for the employee.
        /// </remarks>
        public Task<List<EssPayslipModel>> ListPaySlipsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssPayslipModel>>($"/ess/{employeeId}/document/payslip", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Pay Slip by Pay Run ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for the pay run with the specified ID.
        /// </remarks>
        public byte[] GetPaySlipByPayRunId(int employeeId, int payrunId)
        {
            return ApiByteArrayRequest($"/ess/{employeeId}/document/payslip/{payrunId}", Method.GET);
        }

        /// <summary>
        /// Get Pay Slip by Pay Run ID
        /// </summary>
        /// <remarks>
        /// Gets the pay slip for the pay run with the specified ID.
        /// </remarks>
        public Task<byte[]> GetPaySlipByPayRunIdAsync(int employeeId, int payrunId, CancellationToken cancellationToken = default)
        {
            return ApiByteArrayRequestAsync($"/ess/{employeeId}/document/payslip/{payrunId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Gets emergency contacts for the specified employee.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel GetEmergencyContacts(int employeeId)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", Method.GET);
        }

        /// <summary>
        /// Get Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Gets emergency contacts for the specified employee.
        /// </remarks>
        public Task<EmployeeEmergencyContactsEditModel> GetEmergencyContactsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel UpdateEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.PUT);
        }

        /// <summary>
        /// Update Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public Task<EmployeeEmergencyContactsEditModel> UpdateEmergencyContactsAsync(int employeeId, EmployeeEmergencyContactsEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Save Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public EmployeeEmergencyContactsEditModel SaveEmergencyContacts(int employeeId, EmployeeEmergencyContactsEditModel model)
        {
            return ApiRequest<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.POST);
        }

        /// <summary>
        /// Save Emergency Contacts
        /// </summary>
        /// <remarks>
        /// Saves the employee's emergency contact details.
        /// </remarks>
        public Task<EmployeeEmergencyContactsEditModel> SaveEmergencyContactsAsync(int employeeId, EmployeeEmergencyContactsEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeEmergencyContactsEditModel,EmployeeEmergencyContactsEditModel>($"/ess/{employeeId}/emergencycontacts", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public List<EssExpenseRequestResponseModel> GetExpenseRequests(int employeeId, GetExpenseRequestsQueryModel request)
        {
            return ApiRequest<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense?currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.GET);
        }

        /// <summary>
        /// Get Expense Requests
        /// </summary>
        /// <remarks>
        /// Gets a paged view of expense requests for this employee.
        /// </remarks>
        public Task<List<EssExpenseRequestResponseModel>> GetExpenseRequestsAsync(int employeeId, GetExpenseRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssExpenseRequestResponseModel>>($"/ess/{employeeId}/expense?currentPage={request.CurrentPage}&pageSize={request.PageSize}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for the employee.
        /// </remarks>
        public void CreateExpenseRequest(int employeeId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/ess/{employeeId}/expense", model, Method.POST);
        }

        /// <summary>
        /// Create Expense Request
        /// </summary>
        /// <remarks>
        /// Creates a new expense request for the employee.
        /// </remarks>
        public Task CreateExpenseRequestAsync(int employeeId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/expense", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public EssExpenseRequestResponseModel GetExpenseRequestById(int employeeId, int expenseRequestId)
        {
            return ApiRequest<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.GET);
        }

        /// <summary>
        /// Get Expense Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the expense request with the specified ID.
        /// </remarks>
        public Task<EssExpenseRequestResponseModel> GetExpenseRequestByIdAsync(int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public void UpdateExpenseRequest(int employeeId, int expenseRequestId, ExpenseRequestEditModel model)
        {
            ApiRequest($"/ess/{employeeId}/expense/{expenseRequestId}", model, Method.PUT);
        }

        /// <summary>
        /// Update Expense Request
        /// </summary>
        /// <remarks>
        /// Updates the expense request with the specified ID.
        /// </remarks>
        public Task UpdateExpenseRequestAsync(int employeeId, int expenseRequestId, ExpenseRequestEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/expense/{expenseRequestId}", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public EssExpenseRequestResponseModel DeleteExpenseRequest(int employeeId, int expenseRequestId)
        {
            return ApiRequest<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Expense Request
        /// </summary>
        /// <remarks>
        /// Deletes the expense request with the specified ID.
        /// </remarks>
        public Task<EssExpenseRequestResponseModel> DeleteExpenseRequestAsync(int employeeId, int expenseRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssExpenseRequestResponseModel>($"/ess/{employeeId}/expense/{expenseRequestId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToExpenseRequest(int employeeId, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request)
        {
            ApiRequest($"/ess/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", Method.PUT);
        }

        /// <summary>
        /// Upload Attachment to Expense Request
        /// </summary>
        /// <remarks>
        /// Uploads an attachment to the expense request with the specified ID.
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task UploadAttachmentToExpenseRequestAsync(int employeeId, int expenseRequestId, UploadAttachmentToExpenseRequestQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/expense/{expenseRequestId}/attachment?fileName={request.FileName}", Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Get Expense Categories
        /// </summary>
        /// <remarks>
        /// Gets all the expense categories for the employee.
        /// </remarks>
        public List<ExpenseCategoryResponseModel> GetExpenseCategories(int employeeId)
        {
            return ApiRequest<List<ExpenseCategoryResponseModel>>($"/ess/{employeeId}/expense/categories", Method.GET);
        }

        /// <summary>
        /// Get Expense Categories
        /// </summary>
        /// <remarks>
        /// Gets all the expense categories for the employee.
        /// </remarks>
        public Task<List<ExpenseCategoryResponseModel>> GetExpenseCategoriesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<ExpenseCategoryResponseModel>>($"/ess/{employeeId}/expense/categories", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Expense Payment Summary
        /// </summary>
        /// <remarks>
        /// Gets a summary of the employee's expense payments.
        /// </remarks>
        public List<EmployeeExpensePaymentSummaryModel> GetExpensePaymentSummary(int employeeId)
        {
            return ApiRequest<List<EmployeeExpensePaymentSummaryModel>>($"/ess/{employeeId}/expense/summary", Method.GET);
        }

        /// <summary>
        /// Get Expense Payment Summary
        /// </summary>
        /// <remarks>
        /// Gets a summary of the employee's expense payments.
        /// </remarks>
        public Task<List<EmployeeExpensePaymentSummaryModel>> GetExpensePaymentSummaryAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EmployeeExpensePaymentSummaryModel>>($"/ess/{employeeId}/expense/summary", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets all the tax codes for the employee.
        /// </remarks>
        public List<JournalServiceTaxCode> GetTaxCodes(int employeeId)
        {
            return ApiRequest<List<JournalServiceTaxCode>>($"/ess/{employeeId}/expense/taxcodes", Method.GET);
        }

        /// <summary>
        /// Get Tax Codes
        /// </summary>
        /// <remarks>
        /// Gets all the tax codes for the employee.
        /// </remarks>
        public Task<List<JournalServiceTaxCode>> GetTaxCodesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<JournalServiceTaxCode>>($"/ess/{employeeId}/expense/taxcodes", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public List<EssLeaveRequestModel> ListLeaveRequests(int employeeId, ListLeaveRequestsQueryModel request)
        {
            return ApiRequest<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave?showOtherEmployees={request.ShowOtherEmployees}&approvedOnly={request.ApprovedOnly}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// List Leave Requests
        /// </summary>
        /// <remarks>
        /// Lists all leave requests for this employee, with optional filters
        /// </remarks>
        public Task<List<EssLeaveRequestModel>> ListLeaveRequestsAsync(int employeeId, ListLeaveRequestsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssLeaveRequestModel>>($"/ess/{employeeId}/leave?showOtherEmployees={request.ShowOtherEmployees}&approvedOnly={request.ApprovedOnly}&fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for the employee.
        /// </remarks>
        public void CreateLeaveRequest(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication)
        {
            ApiRequest($"/ess/{employeeId}/leave", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Create Leave Request
        /// </summary>
        /// <remarks>
        /// Creates a new leave request for the employee.
        /// </remarks>
        public Task CreateLeaveRequestAsync(int employeeId, LeaveApplicationWithAttachmentModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave", leaveApplication, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public EssLeaveRequestModel GetLeaveRequestById(int employeeId, int leaveRequestId)
        {
            return ApiRequest<EssLeaveRequestModel>($"/ess/{employeeId}/leave/{leaveRequestId}", Method.GET);
        }

        /// <summary>
        /// Get Leave Request by ID
        /// </summary>
        /// <remarks>
        /// Gets the details for a leave request with the specified ID.
        /// </remarks>
        public Task<EssLeaveRequestModel> GetLeaveRequestByIdAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssLeaveRequestModel>($"/ess/{employeeId}/leave/{leaveRequestId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public void UpdateLeaveRequest(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}", leaveApplication, Method.POST);
        }

        /// <summary>
        /// Update Leave Request
        /// </summary>
        /// <remarks>
        /// Updates the leave request with the specified ID.
        /// </remarks>
        public Task UpdateLeaveRequestAsync(int employeeId, int leaveRequestId, LeaveApplicationWithAttachmentModel leaveApplication, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}", leaveApplication, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public void DeleteLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the leave request with the specified ID.
        /// </remarks>
        public Task DeleteLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Upload Attachment to Leave Request
        /// </summary>
        /// <remarks>
        /// Uploads a file as a new employee document, and attaches it to the leave request with the specified ID. 
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public void UploadAttachmentToLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.PUT);
        }

        /// <summary>
        /// Upload Attachment to Leave Request
        /// </summary>
        /// <remarks>
        /// Uploads a file as a new employee document, and attaches it to the leave request with the specified ID. 
        /// The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task UploadAttachmentToLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Attachment from Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the leave request with the specified ID.
        /// </remarks>
        public void DeleteAttachmentFromLeaveRequest(int employeeId, int leaveRequestId)
        {
            ApiRequest($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.DELETE);
        }

        /// <summary>
        /// Delete Attachment from Leave Request
        /// </summary>
        /// <remarks>
        /// Deletes the attachment on the leave request with the specified ID.
        /// </remarks>
        public Task DeleteAttachmentFromLeaveRequestAsync(int employeeId, int leaveRequestId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/leave/{leaveRequestId}/attachment", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public List<LeaveBalanceModel> GetLeaveBalances(int employeeId, GetLeaveBalancesQueryModel request)
        {
            return ApiRequest<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Leave Balances
        /// </summary>
        /// <remarks>
        /// Gets the leave balances for the employee.
        /// </remarks>
        public Task<List<LeaveBalanceModel>> GetLeaveBalancesAsync(int employeeId, GetLeaveBalancesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LeaveBalanceModel>>($"/ess/{employeeId}/leave/balances?asAtDate={(request.AsAtDate.HasValue ? request.AsAtDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public EssLeaveEstimate EstimateLeaveHours(int employeeId, EstimateLeaveHoursQueryModel request)
        {
            return ApiRequest<EssLeaveEstimate>($"/ess/{employeeId}/leave/estimate?leaveCategoryId={request.LeaveCategoryId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Estimate Leave Hours
        /// </summary>
        /// <remarks>
        /// Estimates the number of hours of leave required based on date and leave category.
        /// </remarks>
        public Task<EssLeaveEstimate> EstimateLeaveHoursAsync(int employeeId, EstimateLeaveHoursQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssLeaveEstimate>($"/ess/{employeeId}/leave/estimate?leaveCategoryId={request.LeaveCategoryId}&fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Leave Categories
        /// </summary>
        /// <remarks>
        /// Gets the available leave categories for the employee.
        /// </remarks>
        public List<EssLeaveCategoryModel> GetLeaveCategories(int employeeId)
        {
            return ApiRequest<List<EssLeaveCategoryModel>>($"/ess/{employeeId}/leave/leavecategories", Method.GET);
        }

        /// <summary>
        /// Get Leave Categories
        /// </summary>
        /// <remarks>
        /// Gets the available leave categories for the employee.
        /// </remarks>
        public Task<List<EssLeaveCategoryModel>> GetLeaveCategoriesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssLeaveCategoryModel>>($"/ess/{employeeId}/leave/leavecategories", Method.GET, cancellationToken);
        }

        public void UkEssLookup_Addresses(int employeeId, int suburbId)
        {
            ApiRequest($"/ess/{employeeId}/lookup/addresses/{suburbId}", Method.GET);
        }

        public Task UkEssLookup_AddressesAsync(int employeeId, int suburbId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/lookup/addresses/{suburbId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets all the locations for the employee.
        /// </remarks>
        public List<LocationModel> GetLocations(int employeeId)
        {
            return ApiRequest<List<LocationModel>>($"/ess/{employeeId}/lookup/location", Method.GET);
        }

        /// <summary>
        /// Get Locations
        /// </summary>
        /// <remarks>
        /// Gets all the locations for the employee.
        /// </remarks>
        public Task<List<LocationModel>> GetLocationsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<LocationModel>>($"/ess/{employeeId}/lookup/location", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Shift Conditions
        /// </summary>
        /// <remarks>
        /// Gets all the shift conditions for the employee.
        /// </remarks>
        public List<UkWorkTypeModel> GetShiftConditions(int employeeId)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/ess/{employeeId}/lookup/shiftcondition", Method.GET);
        }

        /// <summary>
        /// Get Shift Conditions
        /// </summary>
        /// <remarks>
        /// Gets all the shift conditions for the employee.
        /// </remarks>
        public Task<List<UkWorkTypeModel>> GetShiftConditionsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/ess/{employeeId}/lookup/shiftcondition", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Suburb
        /// </summary>
        /// <remarks>
        /// Gets the suburb for the criteria passed in
        /// </remarks>
        public SuburbResult GetSuburb(int employeeId, GetSuburbQueryModel request)
        {
            return ApiRequest<SuburbResult>($"/ess/{employeeId}/lookup/suburb?suburb={request.Suburb}&state={request.State}&postCode={request.PostCode}&countryId={request.CountryId}", Method.GET);
        }

        /// <summary>
        /// Get Suburb
        /// </summary>
        /// <remarks>
        /// Gets the suburb for the criteria passed in
        /// </remarks>
        public Task<SuburbResult> GetSuburbAsync(int employeeId, GetSuburbQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<SuburbResult>($"/ess/{employeeId}/lookup/suburb?suburb={request.Suburb}&state={request.State}&postCode={request.PostCode}&countryId={request.CountryId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Search Suburbs
        /// </summary>
        /// <remarks>
        /// Gets a list of suburbs that match the search term.
        /// </remarks>
        public PagedResultModel<SuburbModel> SearchSuburbs(int employeeId, SearchSuburbsQueryModel request)
        {
            return ApiRequest<PagedResultModel<SuburbModel>>($"/ess/{employeeId}/lookup/suburbs?term={request.Term}&pageNum={request.PageNum}&pageSize={request.PageSize}&countryId={request.CountryId}", Method.GET);
        }

        /// <summary>
        /// Search Suburbs
        /// </summary>
        /// <remarks>
        /// Gets a list of suburbs that match the search term.
        /// </remarks>
        public Task<PagedResultModel<SuburbModel>> SearchSuburbsAsync(int employeeId, SearchSuburbsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<PagedResultModel<SuburbModel>>($"/ess/{employeeId}/lookup/suburbs?term={request.Term}&pageNum={request.PageNum}&pageSize={request.PageSize}&countryId={request.CountryId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Titles
        /// </summary>
        /// <remarks>
        /// Gets list of valid personal titles
        /// </remarks>
        public List<TitleViewModel> GetTitles(int employeeId)
        {
            return ApiRequest<List<TitleViewModel>>($"/ess/{employeeId}/lookup/title", Method.GET);
        }

        /// <summary>
        /// Get Titles
        /// </summary>
        /// <remarks>
        /// Gets list of valid personal titles
        /// </remarks>
        public Task<List<TitleViewModel>> GetTitlesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<TitleViewModel>>($"/ess/{employeeId}/lookup/title", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Work Types
        /// </summary>
        /// <remarks>
        /// Gets all the work types for the employee.
        /// </remarks>
        public List<UkWorkTypeModel> GetWorkTypes(int employeeId)
        {
            return ApiRequest<List<UkWorkTypeModel>>($"/ess/{employeeId}/lookup/worktype", Method.GET);
        }

        /// <summary>
        /// Get Work Types
        /// </summary>
        /// <remarks>
        /// Gets all the work types for the employee.
        /// </remarks>
        public Task<List<UkWorkTypeModel>> GetWorkTypesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkWorkTypeModel>>($"/ess/{employeeId}/lookup/worktype", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Personal Details
        /// </summary>
        /// <remarks>
        /// Gets Personal details for the specified employee.
        /// </remarks>
        public UkEssEmployeeDetailsViewModel GetPersonalDetails(int employeeId)
        {
            return ApiRequest<UkEssEmployeeDetailsViewModel>($"/ess/{employeeId}/personaldetails", Method.GET);
        }

        /// <summary>
        /// Get Personal Details
        /// </summary>
        /// <remarks>
        /// Gets Personal details for the specified employee.
        /// </remarks>
        public Task<UkEssEmployeeDetailsViewModel> GetPersonalDetailsAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssEmployeeDetailsViewModel>($"/ess/{employeeId}/personaldetails", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Personal Details
        /// </summary>
        /// <remarks>
        /// Updates the personal details for the employee
        /// </remarks>
        public UkEssEmployeeDetailsViewModel UpdatePersonalDetails(int employeeId, UkEssEmployeeDetailsEditModel model)
        {
            return ApiRequest<UkEssEmployeeDetailsViewModel,UkEssEmployeeDetailsEditModel>($"/ess/{employeeId}/personaldetails", model, Method.PUT);
        }

        /// <summary>
        /// Update Personal Details
        /// </summary>
        /// <remarks>
        /// Updates the personal details for the employee
        /// </remarks>
        public Task<UkEssEmployeeDetailsViewModel> UpdatePersonalDetailsAsync(int employeeId, UkEssEmployeeDetailsEditModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssEmployeeDetailsViewModel,UkEssEmployeeDetailsEditModel>($"/ess/{employeeId}/personaldetails", model, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public void GetEmployeeProfileImage(int employeeId)
        {
            ApiRequest($"/ess/{employeeId}/profileimage", Method.GET);
        }

        /// <summary>
        /// Get Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Returns the file content for the employee's current profile image.
        /// </remarks>
        public Task GetEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/profileimage", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public ProfileImageMetadata SetEmployeeProfileImage(int employeeId)
        {
            return ApiRequest<ProfileImageMetadata>($"/ess/{employeeId}/profileimage", Method.POST);
        }

        /// <summary>
        /// Set Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Uploads a new employee profile image. The request should be a MIME multipart file upload request.
        /// </remarks>
        public Task<ProfileImageMetadata> SetEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<ProfileImageMetadata>($"/ess/{employeeId}/profileimage", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public void DeleteEmployeeProfileImage(int employeeId)
        {
            ApiRequest($"/ess/{employeeId}/profileimage", Method.DELETE);
        }

        /// <summary>
        /// Delete Employee Profile Image
        /// </summary>
        /// <remarks>
        /// Delete's the employee's profile image.
        /// </remarks>
        public Task DeleteEmployeeProfileImageAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/profileimage", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get public holidays
        /// </summary>
        /// <remarks>
        /// Lists relevant public holiday for an employee
        /// </remarks>
        public List<PublicHolidayModel> GetPublicHolidays(int employeeId, GetPublicHolidaysQueryModel request)
        {
            return ApiRequest<List<PublicHolidayModel>>($"/ess/{employeeId}/publicHolidays?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Get public holidays
        /// </summary>
        /// <remarks>
        /// Lists relevant public holiday for an employee
        /// </remarks>
        public Task<List<PublicHolidayModel>> GetPublicHolidaysAsync(int employeeId, GetPublicHolidaysQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<PublicHolidayModel>>($"/ess/{employeeId}/publicHolidays?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public List<EssSatisfactionSurvey> GetSatisfactionSurveyResults(int employeeId, GetSatisfactionSurveyResultsQueryModel request)
        {
            return ApiRequest<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// Get Satisfaction Survey Results
        /// </summary>
        /// <remarks>
        /// Gets satisfaction survey results for the employee
        /// </remarks>
        public Task<List<EssSatisfactionSurvey>> GetSatisfactionSurveyResultsAsync(int employeeId, GetSatisfactionSurveyResultsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssSatisfactionSurvey>>($"/ess/{employeeId}/satisfaction?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Submit Satisfaction Survey
        /// </summary>
        /// <remarks>
        /// Submit a satisfaction survey for this employee.
        /// </remarks>
        public EmployeeSatisfactionValue SubmitSatisfactionSurvey(int employeeId, EssSatisfactionSurvey survey)
        {
            return ApiRequest<EmployeeSatisfactionValue,EssSatisfactionSurvey>($"/ess/{employeeId}/satisfaction", survey, Method.POST);
        }

        /// <summary>
        /// Submit Satisfaction Survey
        /// </summary>
        /// <remarks>
        /// Submit a satisfaction survey for this employee.
        /// </remarks>
        public Task<EmployeeSatisfactionValue> SubmitSatisfactionSurveyAsync(int employeeId, EssSatisfactionSurvey survey, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EmployeeSatisfactionValue,EssSatisfactionSurvey>($"/ess/{employeeId}/satisfaction", survey, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Enabled Features
        /// </summary>
        /// <remarks>
        /// Gets details as to which ESS features are enabled for the business.
        /// </remarks>
        public UkFeaturesModel GetEnabledFeatures(int employeeId)
        {
            return ApiRequest<UkFeaturesModel>($"/ess/{employeeId}/security/features", Method.GET);
        }

        /// <summary>
        /// Get Enabled Features
        /// </summary>
        /// <remarks>
        /// Gets details as to which ESS features are enabled for the business.
        /// </remarks>
        public Task<UkFeaturesModel> GetEnabledFeaturesAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkFeaturesModel>($"/ess/{employeeId}/security/features", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets the employee's roster shifts within the date range.
        /// </remarks>
        public List<UkEssRosterShiftModel> ListRosterShifts(int employeeId, ListRosterShiftsQueryModel request)
        {
            return ApiRequest<List<UkEssRosterShiftModel>>($"/ess/{employeeId}/shift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// List Roster Shifts
        /// </summary>
        /// <remarks>
        /// Gets the employee's roster shifts within the date range.
        /// </remarks>
        public Task<List<UkEssRosterShiftModel>> ListRosterShiftsAsync(int employeeId, ListRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEssRosterShiftModel>>($"/ess/{employeeId}/shift?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the roster shift with the specified ID (as long as it is assigned to this employee).
        /// </remarks>
        public UkEssRosterShiftModel GetRosterShiftById(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}", Method.GET);
        }

        /// <summary>
        /// Get Roster Shift by ID
        /// </summary>
        /// <remarks>
        /// Gets the roster shift with the specified ID (as long as it is assigned to this employee).
        /// </remarks>
        public Task<UkEssRosterShiftModel> GetRosterShiftByIdAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Accept Roster Shift
        /// </summary>
        /// <remarks>
        /// Accepts the roster shift with the specified ID.
        /// </remarks>
        public UkAcceptRosterShiftResponseModel AcceptRosterShift(int employeeId, int shiftId)
        {
            return ApiRequest<UkAcceptRosterShiftResponseModel>($"/ess/{employeeId}/shift/{shiftId}/accept", Method.POST);
        }

        /// <summary>
        /// Accept Roster Shift
        /// </summary>
        /// <remarks>
        /// Accepts the roster shift with the specified ID.
        /// </remarks>
        public Task<UkAcceptRosterShiftResponseModel> AcceptRosterShiftAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkAcceptRosterShiftResponseModel>($"/ess/{employeeId}/shift/{shiftId}/accept", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Decline Roster Shift
        /// </summary>
        /// <remarks>
        /// Declines the roster shift with the specified ID.
        /// </remarks>
        public EssRosterShiftCountModel DeclineRosterShift(int employeeId, int shiftId, EssDeclineRosterShiftModel model)
        {
            return ApiRequest<EssRosterShiftCountModel,EssDeclineRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}/decline", model, Method.POST);
        }

        /// <summary>
        /// Decline Roster Shift
        /// </summary>
        /// <remarks>
        /// Declines the roster shift with the specified ID.
        /// </remarks>
        public Task<EssRosterShiftCountModel> DeclineRosterShiftAsync(int employeeId, int shiftId, EssDeclineRosterShiftModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssRosterShiftCountModel,EssDeclineRosterShiftModel>($"/ess/{employeeId}/shift/{shiftId}/decline", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Accept Shift Swap
        /// </summary>
        /// <remarks>
        /// Accept a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse AcceptShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/accept", Method.POST);
        }

        /// <summary>
        /// Accept Shift Swap
        /// </summary>
        /// <remarks>
        /// Accept a shift swap
        /// </remarks>
        public Task<UkEssRosterShiftActionResponse> AcceptShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/accept", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Cancel Shift Swap
        /// </summary>
        /// <remarks>
        /// Cancel a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse CancelShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/cancel", Method.POST);
        }

        /// <summary>
        /// Cancel Shift Swap
        /// </summary>
        /// <remarks>
        /// Cancel a shift swap
        /// </remarks>
        public Task<UkEssRosterShiftActionResponse> CancelShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/cancel", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Employees Eligible For Shift Swap
        /// </summary>
        /// <remarks>
        /// List the employees that are eligible for a shift swap
        /// </remarks>
        public List<EssShiftSwapCandidate> EmployeesEligibleForShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<List<EssShiftSwapCandidate>>($"/ess/{employeeId}/shift/{shiftId}/swap/candidates", Method.GET);
        }

        /// <summary>
        /// Employees Eligible For Shift Swap
        /// </summary>
        /// <remarks>
        /// List the employees that are eligible for a shift swap
        /// </remarks>
        public Task<List<EssShiftSwapCandidate>> EmployeesEligibleForShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssShiftSwapCandidate>>($"/ess/{employeeId}/shift/{shiftId}/swap/candidates", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Decline Shift Swap
        /// </summary>
        /// <remarks>
        /// Decline a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse DeclineShiftSwap(int employeeId, int shiftId)
        {
            return ApiRequest<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/decline", Method.POST);
        }

        /// <summary>
        /// Decline Shift Swap
        /// </summary>
        /// <remarks>
        /// Decline a shift swap
        /// </remarks>
        public Task<UkEssRosterShiftActionResponse> DeclineShiftSwapAsync(int employeeId, int shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftActionResponse>($"/ess/{employeeId}/shift/{shiftId}/swap/decline", Method.POST, cancellationToken);
        }

        /// <summary>
        /// Bulk Accept Roster Shifts
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shifts by ID.
        /// </remarks>
        public UkAcceptRosterShiftsResponseModel BulkAcceptRosterShifts(int employeeId, EssBulkAcceptRosterShiftsModel model)
        {
            return ApiRequest<UkAcceptRosterShiftsResponseModel,EssBulkAcceptRosterShiftsModel>($"/ess/{employeeId}/shift/accept", model, Method.POST);
        }

        /// <summary>
        /// Bulk Accept Roster Shifts
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shifts by ID.
        /// </remarks>
        public Task<UkAcceptRosterShiftsResponseModel> BulkAcceptRosterShiftsAsync(int employeeId, EssBulkAcceptRosterShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkAcceptRosterShiftsResponseModel,EssBulkAcceptRosterShiftsModel>($"/ess/{employeeId}/shift/accept", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Bulk Decline Roster Shifts
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shifts by ID.
        /// </remarks>
        public EssRosterShiftCountModel BulkDeclineRosterShifts(int employeeId, EssBulkDeclineRosterShiftsModel model)
        {
            return ApiRequest<EssRosterShiftCountModel,EssBulkDeclineRosterShiftsModel>($"/ess/{employeeId}/shift/decline", model, Method.POST);
        }

        /// <summary>
        /// Bulk Decline Roster Shifts
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shifts by ID.
        /// </remarks>
        public Task<EssRosterShiftCountModel> BulkDeclineRosterShiftsAsync(int employeeId, EssBulkDeclineRosterShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssRosterShiftCountModel,EssBulkDeclineRosterShiftsModel>($"/ess/{employeeId}/shift/decline", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public UkRosterShiftMatchingResultModel FindMatchingClockOffRosterShift(int employeeId, FindMatchingClockOffRosterShiftQueryModel request)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockoff?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Find Matching Clock Off Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock off at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public Task<UkRosterShiftMatchingResultModel> FindMatchingClockOffRosterShiftAsync(int employeeId, FindMatchingClockOffRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockoff?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public UkRosterShiftMatchingResultModel FindMatchingClockOnRosterShift(int employeeId, FindMatchingClockOnRosterShiftQueryModel request)
        {
            return ApiRequest<UkRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockon?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Find Matching Clock On Roster Shift
        /// </summary>
        /// <remarks>
        /// If a roster shift exists that could match for this employee to clock on at this time
        /// given ESS settings for shift matching, returns that shift.
        /// Otherwise, the Shift result will be null.
        /// Note that if the time matches a shift exactly, the Shift result will also be null.
        /// </remarks>
        public Task<UkRosterShiftMatchingResultModel> FindMatchingClockOnRosterShiftAsync(int employeeId, FindMatchingClockOnRosterShiftQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkRosterShiftMatchingResultModel>($"/ess/{employeeId}/shift/matchingclockon?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public List<UkEssRosterShiftModel> FindNearbyRosterShifts(int employeeId, FindNearbyRosterShiftsQueryModel request)
        {
            return ApiRequest<List<UkEssRosterShiftModel>>($"/ess/{employeeId}/shift/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Find Nearby Roster Shifts
        /// </summary>
        /// <remarks>
        /// Finds any of the employee's roster shifts that are nearby to the specified local time.
        /// </remarks>
        public Task<List<UkEssRosterShiftModel>> FindNearbyRosterShiftsAsync(int employeeId, FindNearbyRosterShiftsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkEssRosterShiftModel>>($"/ess/{employeeId}/shift/nearby?localTime={request.LocalTime.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Bulk Accept Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shift swaps by shift ID.
        /// </remarks>
        public UkEssBulkRosterShiftActionResponse BulkAcceptRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/accept", model, Method.POST);
        }

        /// <summary>
        /// Bulk Accept Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Accepts a number of roster shift swaps by shift ID.
        /// </remarks>
        public Task<UkEssBulkRosterShiftActionResponse> BulkAcceptRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/accept", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Bulk Cancel Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Cancels a number of roster shift swaps by shift ID.
        /// </remarks>
        public UkEssBulkRosterShiftActionResponse BulkCancelRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/cancel", model, Method.POST);
        }

        /// <summary>
        /// Bulk Cancel Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Cancels a number of roster shift swaps by shift ID.
        /// </remarks>
        public Task<UkEssBulkRosterShiftActionResponse> BulkCancelRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/cancel", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Bulk Decline Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shift swaps by shift ID.
        /// </remarks>
        public UkEssBulkRosterShiftActionResponse BulkDeclineRosterShiftSwaps(int employeeId, EssBulkRosterShiftSwapModel model)
        {
            return ApiRequest<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/decline", model, Method.POST);
        }

        /// <summary>
        /// Bulk Decline Roster Shift Swaps
        /// </summary>
        /// <remarks>
        /// Declines a number of roster shift swaps by shift ID.
        /// </remarks>
        public Task<UkEssBulkRosterShiftActionResponse> BulkDeclineRosterShiftSwapsAsync(int employeeId, EssBulkRosterShiftSwapModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssBulkRosterShiftActionResponse,EssBulkRosterShiftSwapModel>($"/ess/{employeeId}/shift/swap/decline", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Propose Shift Swap
        /// </summary>
        /// <remarks>
        /// Propose a shift swap
        /// </remarks>
        public UkEssRosterShiftActionResponse ProposeShiftSwap(int employeeId, SwapShiftModel model)
        {
            return ApiRequest<UkEssRosterShiftActionResponse,SwapShiftModel>($"/ess/{employeeId}/shift/swap/propose", model, Method.POST);
        }

        /// <summary>
        /// Propose Shift Swap
        /// </summary>
        /// <remarks>
        /// Propose a shift swap
        /// </remarks>
        public Task<UkEssRosterShiftActionResponse> ProposeShiftSwapAsync(int employeeId, SwapShiftModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssRosterShiftActionResponse,SwapShiftModel>($"/ess/{employeeId}/shift/swap/propose", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out the employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public void ClockOutEmployee(int employeeId, ClockOffModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/clockoff", request, Method.POST);
        }

        /// <summary>
        /// Clock Out Employee
        /// </summary>
        /// <remarks>
        /// Clocks out the employee from their existing shift.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task ClockOutEmployeeAsync(int employeeId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/clockoff", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public KioskEmployeeModel ClockInEmployee(int employeeId, UkClockOnModel model)
        {
            return ApiRequest<KioskEmployeeModel,UkClockOnModel>($"/ess/{employeeId}/timeandattendance/clockon", model, Method.POST);
        }

        /// <summary>
        /// Clock In Employee
        /// </summary>
        /// <remarks>
        /// Clocks in an employee for a new shift.
        /// </remarks>
        public Task<KioskEmployeeModel> ClockInEmployeeAsync(int employeeId, UkClockOnModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<KioskEmployeeModel,UkClockOnModel>($"/ess/{employeeId}/timeandattendance/clockon", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public void DiscardCurrentShift(int employeeId, ClockOffModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/discard", request, Method.POST);
        }

        /// <summary>
        /// Discard current shift
        /// </summary>
        /// <remarks>
        /// Discards the current shift for an employee.
        /// If they are on a break, it will be ended automatically.
        /// </remarks>
        public Task DiscardCurrentShiftAsync(int employeeId, ClockOffModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/discard", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public void EndBreak(int employeeId, EndBreakModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/endbreak", request, Method.POST);
        }

        /// <summary>
        /// End Break
        /// </summary>
        /// <remarks>
        /// Ends the employee's current break.
        /// </remarks>
        public Task EndBreakAsync(int employeeId, EndBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/endbreak", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for the employee in relation to a kiosk.
        /// </remarks>
        public UkTimeAndAttendanceLookupDataModel GetLookupData(int employeeId)
        {
            return ApiRequest<UkTimeAndAttendanceLookupDataModel>($"/ess/{employeeId}/timeandattendance/lookupdata", Method.GET);
        }

        /// <summary>
        /// Get Lookup Data
        /// </summary>
        /// <remarks>
        /// Gets relevant lookup data for the employee in relation to a kiosk.
        /// </remarks>
        public Task<UkTimeAndAttendanceLookupDataModel> GetLookupDataAsync(int employeeId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkTimeAndAttendanceLookupDataModel>($"/ess/{employeeId}/timeandattendance/lookupdata", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public void GetShiftNotes(int employeeId, int shiftId, GetShiftNotesQueryModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.GET);
        }

        /// <summary>
        /// Get Shift Notes
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task GetShiftNotesAsync(int employeeId, int shiftId, GetShiftNotesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes?employeeId={request.EmployeeId}&isAdminInitiated={request.IsAdminInitiated}&type={request.Type}&visibility={request.Visibility}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public void AddNoteToShift(int employeeId, int shiftId, AddNoteModel model)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", model, Method.POST);
        }

        /// <summary>
        /// Add Note to Shift
        /// </summary>
        /// <remarks>
        /// Adds a note to an existing shift.
        /// </remarks>
        public Task AddNoteToShiftAsync(int employeeId, int shiftId, AddNoteModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public void MarkShiftNotesRead(int employeeId, MarkNotesReadViewModel model, string shiftId)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes/read-state", model, Method.POST);
        }

        /// <summary>
        /// Mark Shift Notes Read
        /// </summary>
        /// <remarks>
        /// Marks some shift notes as either read or unread.
        /// </remarks>
        public Task MarkShiftNotesReadAsync(int employeeId, MarkNotesReadViewModel model, string shiftId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/shift/{shiftId}/notes/read-state", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public List<UkTimeAndAttendanceShiftModel> Shifts(int employeeId, GetShiftsModel model)
        {
            return ApiRequest<List<UkTimeAndAttendanceShiftModel>,GetShiftsModel>($"/ess/{employeeId}/timeandattendance/shifts", model, Method.POST);
        }

        /// <summary>
        /// Shifts
        /// </summary>
        /// <remarks>
        /// Gets shifts based on certain optional criteria.
        /// </remarks>
        public Task<List<UkTimeAndAttendanceShiftModel>> ShiftsAsync(int employeeId, GetShiftsModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<UkTimeAndAttendanceShiftModel>,GetShiftsModel>($"/ess/{employeeId}/timeandattendance/shifts", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for the employee who is clocked on for a shift.
        /// </remarks>
        public void StartBreak(int employeeId, StartBreakModel request)
        {
            ApiRequest($"/ess/{employeeId}/timeandattendance/startbreak", request, Method.POST);
        }

        /// <summary>
        /// Start Break
        /// </summary>
        /// <remarks>
        /// Starts a break for the employee who is clocked on for a shift.
        /// </remarks>
        public Task StartBreakAsync(int employeeId, StartBreakModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timeandattendance/startbreak", request, Method.POST, cancellationToken);
        }

        /// <summary>
        /// List Timesheets
        /// </summary>
        /// <remarks>
        /// Lists timesheets for the employee.
        /// </remarks>
        public List<EssTimesheetModel> ListTimesheets(int employeeId, ListTimesheetsQueryModel request)
        {
            return ApiRequest<List<EssTimesheetModel>>($"/ess/{employeeId}/timesheet?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// List Timesheets
        /// </summary>
        /// <remarks>
        /// Lists timesheets for the employee.
        /// </remarks>
        public Task<List<EssTimesheetModel>> ListTimesheetsAsync(int employeeId, ListTimesheetsQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssTimesheetModel>>($"/ess/{employeeId}/timesheet?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Submit or Update Timesheet
        /// </summary>
        /// <remarks>
        /// If no ID is specified, create a new timesheet for the employee. 
        /// Otherwise, update the timesheet with the specified ID.
        /// </remarks>
        public void SubmitOrUpdateTimesheet(int employeeId, EssTimesheetModel timesheet)
        {
            ApiRequest($"/ess/{employeeId}/timesheet", timesheet, Method.POST);
        }

        /// <summary>
        /// Submit or Update Timesheet
        /// </summary>
        /// <remarks>
        /// If no ID is specified, create a new timesheet for the employee. 
        /// Otherwise, update the timesheet with the specified ID.
        /// </remarks>
        public Task SubmitOrUpdateTimesheetAsync(int employeeId, EssTimesheetModel timesheet, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timesheet", timesheet, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public void EditTimesheet(int employeeId, int timesheetId, EssTimesheetModel timesheet)
        {
            ApiRequest($"/ess/{employeeId}/timesheet/{timesheetId}", timesheet, Method.POST);
        }

        /// <summary>
        /// Edit Timesheet
        /// </summary>
        /// <remarks>
        /// Edits the timesheet with the specified ID.
        /// </remarks>
        public Task EditTimesheetAsync(int employeeId, int timesheetId, EssTimesheetModel timesheet, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timesheet/{timesheetId}", timesheet, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public void DeleteTimesheet(int employeeId, int timesheetId)
        {
            ApiRequest($"/ess/{employeeId}/timesheet/{timesheetId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Timesheet
        /// </summary>
        /// <remarks>
        /// Deletes the timesheet with the specified ID.
        /// </remarks>
        public Task DeleteTimesheetAsync(int employeeId, int timesheetId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/timesheet/{timesheetId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Get Timesheet Creation Data
        /// </summary>
        /// <remarks>
        /// Lists relevant timesheet, leave and shift data for an employee, to allow for intuitive timesheet creation.
        /// </remarks>
        public UkEssTimesheetDataModel GetTimesheetCreationData(int employeeId, GetTimesheetCreationDataQueryModel request)
        {
            return ApiRequest<UkEssTimesheetDataModel>($"/ess/{employeeId}/timesheet/data?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET);
        }

        /// <summary>
        /// Get Timesheet Creation Data
        /// </summary>
        /// <remarks>
        /// Lists relevant timesheet, leave and shift data for an employee, to allow for intuitive timesheet creation.
        /// </remarks>
        public Task<UkEssTimesheetDataModel> GetTimesheetCreationDataAsync(int employeeId, GetTimesheetCreationDataQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<UkEssTimesheetDataModel>($"/ess/{employeeId}/timesheet/data?fromDate={request.FromDate.ToString("yyyy-MM-ddTHH:mm:ss")}&toDate={request.ToDate.ToString("yyyy-MM-ddTHH:mm:ss")}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public List<EssUnavailabilityModel> ListUnavailabilities(int employeeId, ListUnavailabilitiesQueryModel request)
        {
            return ApiRequest<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET);
        }

        /// <summary>
        /// List Unavailabilities
        /// </summary>
        /// <remarks>
        /// Lists all of the unavailabilities for this employee, with optional filters.
        /// </remarks>
        public Task<List<EssUnavailabilityModel>> ListUnavailabilitiesAsync(int employeeId, ListUnavailabilitiesQueryModel request, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<EssUnavailabilityModel>>($"/ess/{employeeId}/unavailability?fromDate={(request.FromDate.HasValue ? request.FromDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}&toDate={(request.ToDate.HasValue ? request.ToDate.Value.ToString("yyyy-MM-ddTHH:mm:ss") : String.Empty)}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public EssUnavailabilityModel CreateUnavailability(int employeeId, UnavailabilityEditModel unavailability)
        {
            return ApiRequest<EssUnavailabilityModel,UnavailabilityEditModel>($"/ess/{employeeId}/unavailability", unavailability, Method.POST);
        }

        /// <summary>
        /// Create Unavailability
        /// </summary>
        /// <remarks>
        /// Creates a new unavailability for the employee.
        /// </remarks>
        public Task<EssUnavailabilityModel> CreateUnavailabilityAsync(int employeeId, UnavailabilityEditModel unavailability, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssUnavailabilityModel,UnavailabilityEditModel>($"/ess/{employeeId}/unavailability", unavailability, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID (so long as the unavailability is from the specified employee).
        /// </remarks>
        public EssUnavailabilityModel GetUnavailabilityById(int employeeId, int unavailabilityId)
        {
            return ApiRequest<EssUnavailabilityModel>($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.GET);
        }

        /// <summary>
        /// Get unavailability by ID
        /// </summary>
        /// <remarks>
        /// Gets the unavailability with the specified ID (so long as the unavailability is from the specified employee).
        /// </remarks>
        public Task<EssUnavailabilityModel> GetUnavailabilityByIdAsync(int employeeId, int unavailabilityId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<EssUnavailabilityModel>($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public void UpdateUnavailability(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability)
        {
            ApiRequest($"/ess/{employeeId}/unavailability/{unavailabilityId}", unavailability, Method.PUT);
        }

        /// <summary>
        /// Update Unavailability
        /// </summary>
        /// <remarks>
        /// Updates the unavailability with the specified ID.
        /// </remarks>
        public Task UpdateUnavailabilityAsync(int employeeId, int unavailabilityId, UnavailabilityEditModel unavailability, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/unavailability/{unavailabilityId}", unavailability, Method.PUT, cancellationToken);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public void DeleteUnavailability(int employeeId, int unavailabilityId)
        {
            ApiRequest($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.DELETE);
        }

        /// <summary>
        /// Delete Unavailability
        /// </summary>
        /// <remarks>
        /// Deletes the unavailability with the specified ID.
        /// </remarks>
        public Task DeleteUnavailabilityAsync(int employeeId, int unavailabilityId, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/{employeeId}/unavailability/{unavailabilityId}", Method.DELETE, cancellationToken);
        }

        /// <summary>
        /// Register Device Token
        /// </summary>
        /// <remarks>
        /// Registers a device token.
        /// </remarks>
        public void RegisterDeviceToken(DeviceTokenModel model)
        {
            ApiRequest($"/ess/devicetoken/register", model, Method.POST);
        }

        /// <summary>
        /// Register Device Token
        /// </summary>
        /// <remarks>
        /// Registers a device token.
        /// </remarks>
        public Task RegisterDeviceTokenAsync(DeviceTokenModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/devicetoken/register", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Unregister Device Token
        /// </summary>
        /// <remarks>
        /// Unregisters a device token.
        /// </remarks>
        public void UnregisterDeviceToken(DeviceTokenModel model)
        {
            ApiRequest($"/ess/devicetoken/unregister", model, Method.POST);
        }

        /// <summary>
        /// Unregister Device Token
        /// </summary>
        /// <remarks>
        /// Unregisters a device token.
        /// </remarks>
        public Task UnregisterDeviceTokenAsync(DeviceTokenModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/devicetoken/unregister", model, Method.POST, cancellationToken);
        }

        /// <summary>
        /// Get Employees
        /// </summary>
        /// <remarks>
        /// Returns all the employees the user can access.
        /// </remarks>
        public List<AvailableEmployeeModel> GetEmployees()
        {
            return ApiRequest<List<AvailableEmployeeModel>>($"/ess/security/employees", Method.GET);
        }

        /// <summary>
        /// Get Employees
        /// </summary>
        /// <remarks>
        /// Returns all the employees the user can access.
        /// </remarks>
        public Task<List<AvailableEmployeeModel>> GetEmployeesAsync(CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync<List<AvailableEmployeeModel>>($"/ess/security/employees", Method.GET, cancellationToken);
        }

        /// <summary>
        /// Recover Forgotten Password
        /// </summary>
        /// <remarks>
        /// Sends an email so that the user can reset their password
        /// </remarks>
        public void RecoverForgottenPassword(RecoverPasswordModel model)
        {
            ApiRequest($"/ess/security/forgottenpassword", model, Method.POST);
        }

        /// <summary>
        /// Recover Forgotten Password
        /// </summary>
        /// <remarks>
        /// Sends an email so that the user can reset their password
        /// </remarks>
        public Task RecoverForgottenPasswordAsync(RecoverPasswordModel model, CancellationToken cancellationToken = default)
        {
            return ApiRequestAsync($"/ess/security/forgottenpassword", model, Method.POST, cancellationToken);
        }
    }
}
