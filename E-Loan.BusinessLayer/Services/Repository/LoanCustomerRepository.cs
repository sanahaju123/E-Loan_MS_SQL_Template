using E_Loan.DataLayer;
using E_Loan.Entities;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace E_Loan.BusinessLayer.Services.Repository
{
    public class LoanCustomerRepository : ILoanCustomerRepository
    {
        /// <summary>
        /// Creating referance Variable of EloanDbContext and Injecting in LoanCustomerRepository constructor
        /// </summary>
        private readonly ELoanDbContext _eLoanDbContext;
        public LoanCustomerRepository(ELoanDbContext eLoanDbContext)
        {
            _eLoanDbContext = eLoanDbContext;
        }

        /// <summary>
        /// Apply mortage and save all data in InMemory Database collection.
        /// </summary>
        /// <param name="loanMaster"></param>
        /// <returns></returns>
        public async Task<LoanMaster> ApplyMortgage(LoanMaster loanMaster)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the loan status by id applied by customer
        /// </summary>
        /// <param name="loanId"></param>
        /// <returns></returns>
        public async Task<LoanMaster> AppliedLoanStatus(int loanId)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an existing loan application before sent to loan clerk if loan status is recived update not possible
        /// </summary>
        /// <param name="loanId"></param>
        /// <param name="loanMaster"></param>
        /// <returns></returns>
        public async Task<LoanMaster> UpdateMortgage(int loanId, LoanMaster loanMaster)
        {
            //Write Your Code Her
            throw new NotImplementedException();
        }
    }
}
