using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using iSpend_iCryModels;
using iSpend_iCryUI.EF;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace iSpend_iCryUI.Controllers
{
    [Route("api/transactions/{id}")]
    [Produces("application/json")]
    public class TransactionsController : Controller
    {
        private readonly iSpendiCryContext _context;
        public IConfiguration Configuration { get; }

        public TransactionsController(iSpendiCryContext context, IConfiguration configuration)
        {
            _context = context;
            Configuration = configuration;
        }

        [HttpGet]
        public async Task<IActionResult> GetTransactions(string id)
        {
            var result = await _context.up_getTransactionsByAccountID_Result.FromSql("EXECUTE up_GetTransactionsByAccountID {0}", id).ToListAsync();
            return Json(result);
        }
    }
}