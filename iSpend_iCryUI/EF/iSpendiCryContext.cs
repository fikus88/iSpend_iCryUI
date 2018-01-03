using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using iSpend_iCryModels;
using Microsoft.EntityFrameworkCore;

namespace iSpend_iCryUI.EF
{
    public class iSpendiCryContext : DbContext
    {
        public iSpendiCryContext(DbContextOptions<iSpendiCryContext> options) : base(options)
        {
        }

        public DbSet<account> account { get; set; }
        public DbSet<balance> balance { get; set; }
        public DbSet<transaction> transaction { get; set; }
        public DbSet<up_GetAccountsWithbalances_Result> up_getAccountsWithBalances_Result { get; set; }
        public DbSet<up_GetTransactionsByAccountID_Result> up_getTransactionsByAccountID_Result { get; set; }
    }
}