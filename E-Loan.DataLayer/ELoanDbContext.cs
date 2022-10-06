using E_Loan.Entities;
using Microsoft.EntityFrameworkCore;


namespace E_Loan.DataLayer
{
    public class ELoanDbContext : DbContext
    {
        public ELoanDbContext(DbContextOptions<ELoanDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
           
        }
         ///<summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<UserMaster> userMasters { get; set; }
        public DbSet<LoanMaster> loanMasters { get; set; }
        public DbSet<LoanProcesstrans> loanProcesstrans { get; set; }
        public DbSet<LoanApprovaltrans> loanApprovaltrans { get; set; }
        
    }
}
