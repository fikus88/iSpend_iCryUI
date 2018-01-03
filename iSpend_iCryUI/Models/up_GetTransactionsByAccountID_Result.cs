using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iSpend_iCryModels
{
    public class up_GetTransactionsByAccountID_Result
    {
        [Key]
        public string transaction_id { get; set; }

        public string account_id { get; set; }
        public string display_name { get; set; }

        public decimal current { get; set; }
        public decimal available { get; set; }
        public DateTime timestamp { get; set; }
        public string description { get; set; }
        public string transaction_type { get; set; }
        public string transaction_category { get; set; }
        public decimal amount { get; set; }
        public string meta_transaction_reference { get; set; }
    }
}