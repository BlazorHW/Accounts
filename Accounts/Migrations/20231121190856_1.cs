using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accounts.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "assetsFixeds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Accounttypes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assetsFixeds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "companys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCompany = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Addres = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberCostCenter = table.Column<int>(type: "int", nullable: false),
                    NameCostCenter = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "treeOfAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberAcc = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_treeOfAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "useres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passwd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_useres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameAccount = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberAccount = table.Column<int>(type: "int", nullable: false),
                    SubAccounts = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    OpeningBlance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsBudgetProfit = table.Column<bool>(type: "bit", nullable: false),
                    AccountTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accounts_assetsFixeds_AccountTypeId",
                        column: x => x.AccountTypeId,
                        principalTable: "assetsFixeds",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "makeJournalBody",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Debit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Credit = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Blance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsBudgetProfit = table.Column<bool>(type: "bit", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    CostCenterID = table.Column<int>(type: "int", nullable: false),
                    MakeJournalHeadId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_makeJournalBody", x => x.Id);
                    table.ForeignKey(
                        name: "FK_makeJournalBody_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_makeJournalBody_CostCenter_CostCenterID",
                        column: x => x.CostCenterID,
                        principalTable: "CostCenter",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "makeJournalHeads",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryJournalId = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MakeJurnalBodyID = table.Column<int>(type: "int", nullable: false),
                    AccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_makeJournalHeads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_makeJournalHeads_Accounts_AccountID",
                        column: x => x.AccountID,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_makeJournalHeads_makeJournalBody_MakeJurnalBodyID",
                        column: x => x.MakeJurnalBodyID,
                        principalTable: "makeJournalBody",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_AccountTypeId",
                table: "Accounts",
                column: "AccountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_makeJournalBody_AccountID",
                table: "makeJournalBody",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_makeJournalBody_CostCenterID",
                table: "makeJournalBody",
                column: "CostCenterID");

            migrationBuilder.CreateIndex(
                name: "IX_makeJournalBody_MakeJournalHeadId",
                table: "makeJournalBody",
                column: "MakeJournalHeadId");

            migrationBuilder.CreateIndex(
                name: "IX_makeJournalHeads_AccountID",
                table: "makeJournalHeads",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IX_makeJournalHeads_MakeJurnalBodyID",
                table: "makeJournalHeads",
                column: "MakeJurnalBodyID");

            migrationBuilder.AddForeignKey(
                name: "FK_makeJournalBody_makeJournalHeads_MakeJournalHeadId",
                table: "makeJournalBody",
                column: "MakeJournalHeadId",
                principalTable: "makeJournalHeads",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_assetsFixeds_AccountTypeId",
                table: "Accounts");

            migrationBuilder.DropForeignKey(
                name: "FK_makeJournalBody_Accounts_AccountID",
                table: "makeJournalBody");

            migrationBuilder.DropForeignKey(
                name: "FK_makeJournalHeads_Accounts_AccountID",
                table: "makeJournalHeads");

            migrationBuilder.DropForeignKey(
                name: "FK_makeJournalBody_CostCenter_CostCenterID",
                table: "makeJournalBody");

            migrationBuilder.DropForeignKey(
                name: "FK_makeJournalBody_makeJournalHeads_MakeJournalHeadId",
                table: "makeJournalBody");

            migrationBuilder.DropTable(
                name: "companys");

            migrationBuilder.DropTable(
                name: "treeOfAccounts");

            migrationBuilder.DropTable(
                name: "useres");

            migrationBuilder.DropTable(
                name: "assetsFixeds");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "CostCenter");

            migrationBuilder.DropTable(
                name: "makeJournalHeads");

            migrationBuilder.DropTable(
                name: "makeJournalBody");
        }
    }
}
