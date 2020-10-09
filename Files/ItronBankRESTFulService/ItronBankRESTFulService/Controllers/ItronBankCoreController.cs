using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Validation;

namespace ItronBankRESTFulService.Controllers
{
    public class ItronBankCoreController : ApiController
    {
        Models.ItronBankDb2020Entities db = new Models.ItronBankDb2020Entities();


        public decimal? GetCurrentBalance(string AccountNo)
        {

            var ObjAcc = db.Accounts.SingleOrDefault(a => a.AccountNo == AccountNo);
            return ObjAcc?.CurrentAmount;
        
        }


        public IEnumerable<Models.BankTranMiniStatement> GetMiniStatement(string AccountNo, int noOftransaction)
        {

         var r=   db.BankTransactions.OrderBy(b => b.TransDateTime).ToList();
         var r1=   r.Where((b, idx) => idx < noOftransaction).Select(b=> new Models.BankTranMiniStatement {   AccountNo= b.Account.AccountNo, TransDateTime= b.TransDateTime, TransDesc= b.TransDesc,  TransType=b.TransType, Debit= b.Debit, Credit= b.Credit, AccountId= b.AccountId, TransactionID= b.TransactionID}   ).ToList();


            return r1;

        }


    }
}
