using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Loan.DataLayer.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "loanApprovaltrans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SanctionedAmount = table.Column<double>(nullable: false),
                    Termofloan = table.Column<double>(nullable: false),
                    PaymentStartDate = table.Column<DateTime>(nullable: false),
                    LoanCloserDate = table.Column<DateTime>(nullable: false),
                    MonthlyPayment = table.Column<double>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanApprovaltrans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loanMasters",
                columns: table => new
                {
                    LoanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanName = table.Column<string>(nullable: false),
                    LoanAmount = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    BusinessStructure = table.Column<int>(nullable: false),
                    Billing_Indicator = table.Column<int>(nullable: false),
                    Tax_Indicator = table.Column<int>(nullable: false),
                    ContactAddress = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    AppliedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    ManagerRemark = table.Column<string>(nullable: true),
                    LStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanMasters", x => x.LoanId);
                });

            migrationBuilder.CreateTable(
                name: "loanProcesstrans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcresofLand = table.Column<long>(nullable: false),
                    LandValueinRs = table.Column<long>(nullable: false),
                    AppraisedBy = table.Column<string>(nullable: false),
                    ValuationDate = table.Column<DateTime>(nullable: false),
                    AddressofProperty = table.Column<string>(nullable: false),
                    SuggestedAmount = table.Column<long>(nullable: false),
                    ManagerId = table.Column<int>(nullable: false),
                    LoanId = table.Column<int>(nullable: false),
                    UpdatedOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loanProcesstrans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userMasters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Contact = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    IdproofTypes = table.Column<int>(nullable: true),
                    IdProofNumber = table.Column<string>(nullable: true),
                    Enabled = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userMasters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loanApprovaltrans");

            migrationBuilder.DropTable(
                name: "loanMasters");

            migrationBuilder.DropTable(
                name: "loanProcesstrans");

            migrationBuilder.DropTable(
                name: "userMasters");
        }
    }
}
