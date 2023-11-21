using Accounts.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Accounts.Data
{
    public class AccountingDbContext : DbContext
    {
        public AccountingDbContext(DbContextOptions<AccountingDbContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<MakeJournalHead> makeJournalHeads { get; set; }
        public DbSet<MakeJournalBody> makeJournalBody { get; set; }

        public DbSet<Company> companys { get; set; }
        public DbSet<Useres> useres { get; set; }
        public DbSet<AccountType> assetsFixeds { get; set; }

        public DbSet<TreeOfAccounts> treeOfAccounts { get; set; }

    }
}
