using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iSpend_iCryModels;
using iSpend_iCryUI.EF;

namespace iSpend_iCryUI.Controllers
{
    [Produces("application/json")]
    [Route("api/direct_debits")]
    public class DirectDebitsController : Controller
    {
        private readonly iSpendiCryContext _context;

        public DirectDebitsController(iSpendiCryContext context)
        {
            _context = context;
        }

        // GET: api/DirectDebits
        [HttpGet]
        public IEnumerable<up_GetTransactionsByAccountID_Result> Getup_getTransactionsByAccountID_Result()
        {
            return _context.up_getTransactionsByAccountID_Result;
        }

        // GET: api/DirectDebits/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDirectDebits([FromRoute] string id)
        {
            var result = await _context.up_getTransactionsByAccountID_Result.FromSql("EXECUTE up_GetDirectDebitsByAccountID {0}", id).ToListAsync();
            return Json(result);
        }

        //// PUT: api/DirectDebits/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Putup_GetTransactionsByAccountID_Result([FromRoute] string id, [FromBody] up_GetTransactionsByAccountID_Result up_GetTransactionsByAccountID_Result)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    if (id != up_GetTransactionsByAccountID_Result.transaction_id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(up_GetTransactionsByAccountID_Result).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!up_GetTransactionsByAccountID_ResultExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/DirectDebits
        //[HttpPost]
        //public async Task<IActionResult> Postup_GetTransactionsByAccountID_Result([FromBody] up_GetTransactionsByAccountID_Result up_GetTransactionsByAccountID_Result)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    _context.up_getTransactionsByAccountID_Result.Add(up_GetTransactionsByAccountID_Result);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("Getup_GetTransactionsByAccountID_Result", new { id = up_GetTransactionsByAccountID_Result.transaction_id }, up_GetTransactionsByAccountID_Result);
        //}

        //// DELETE: api/DirectDebits/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Deleteup_GetTransactionsByAccountID_Result([FromRoute] string id)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    var up_GetTransactionsByAccountID_Result = await _context.up_getTransactionsByAccountID_Result.SingleOrDefaultAsync(m => m.transaction_id == id);
        //    if (up_GetTransactionsByAccountID_Result == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.up_getTransactionsByAccountID_Result.Remove(up_GetTransactionsByAccountID_Result);
        //    await _context.SaveChangesAsync();

        //    return Ok(up_GetTransactionsByAccountID_Result);
        //}

        private bool up_GetTransactionsByAccountID_ResultExists(string id)
        {
            return _context.up_getTransactionsByAccountID_Result.Any(e => e.transaction_id == id);
        }
    }
}