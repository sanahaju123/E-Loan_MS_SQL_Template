using E_Loan.DataLayer;
using E_Loan.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Loan.BusinessLayer.Services.Repository
{
    public class LoanClerkRepository : ILoanClerkRepository
    {
        /// <summary>
        /// Creating referance Variable of DbContext and injecting in LoanClerkRepository Constructor.
        /// </summary>
        private readonly ELoanDbContext _eLoanDbContext;
        public LoanClerkRepository(ELoanDbContext eLoanDbContext)
        {
            _eLoanDbContext = eLoanDbContext;
        }
        /// <summary>
        /// Show/Get all loan application
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> AllLoanApplication()
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Show/Get all loan application that status is Not Recived
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> NotReceivedLoanApplication()
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Start the loan process and add the remening data by loan clerk
        /// </summary>
        /// <param name="loanProcesstrans"></param>
        /// <returns></returns>
        public async Task<LoanProcesstrans> ProcessLoan(LoanProcesstrans loanProcesstrans)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Make the loan application as "Recived" before starting loan process using this method
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        public async Task<LoanMaster> ReceivedLoan(int loanId)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find and get all loan application that is recived for loan clerk
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<LoanMaster>> ReceivedLoanApplication()
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }
    }
}
