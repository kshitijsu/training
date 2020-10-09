﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItronBankRESTFulService.Models
{
    public class BankTranMiniStatement
    
    {
        public int TransactionID { get; set; }
        public int AccountId { get; set; }
        public string TransType { get; set; }
        public System.DateTime TransDateTime { get; set; }
        public string TransDesc { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }

        public string  AccountNo { get; set; }
    }
}