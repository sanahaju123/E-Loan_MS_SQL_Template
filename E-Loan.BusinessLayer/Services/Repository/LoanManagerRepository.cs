using E_Loan.DataLayer;
using E_Loan.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Loan.BusinessLayer.Services.Repository
{
    public class LoanManagerRepository : ILoanManagerRepository
    {
        /// <summary>
        /// Creating referance Variable of DbContext and injecting in LoanManagerRepository constructor
        /// </summary>

        private readonly ELoanDbContext _eLoanDbContext;
        public LoanManagerRepository(ELoanDbContext eLoanDbContext)
        {
            _eLoanDbContext = eLoanDbContext;
        }
        /// <summary>
        /// Accept loan application before start the loan approval process.
        /// </summary>
        /// <param name="loanId"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public async Task<LoanMaster> AcceptLoanApplication(int loanId, string remark)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get list of all loan Application baed on status that is belongs to "Recived"
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> AllLoanApplication()
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Reject loan application after physical review with remark, before start the loan approval process make again as "Accept".
        /// </summary>
        /// <param name="loanId"></param>
        /// <param name="remark"></param>
        /// <returns></returns>
        public async Task<LoanMaster> RejectLoanApplication(int loanId, string remark)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start the loan Sanction if loan status is "Accept" and add the all pending amout and all terms,
        /// with makeking loan status is Done
        /// </summary>
        /// <param name="loanApprovaltrans"></param>
        /// <returns></returns>
        public async Task<LoanApprovaltrans> SanctionedLoan(int loanId, LoanApprovaltrans loanApprovaltrans)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Using this method check the loan status is "Accepted" or not before start loan process.
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        public async Task<LoanMaster> CheckLoanStatus(int loanId)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }
    }
}
