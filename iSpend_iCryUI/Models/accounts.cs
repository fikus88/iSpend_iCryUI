﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iSpend_iCryModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class account
    {
        [Key]
        public string account_id { get; set; }
        public System.DateTime update_timestamp { get; set; }
        public string account_type { get; set; }
        public string display_name { get; set; }
        public string currency { get; set; }
        public string provider_display_name { get; set; }
        public string provider_id { get; set; }
        public string logo_uri { get; set; }
        public string account_number_iban { get; set; }
        public string account_number_swift_bic { get; set; }
        public string account_number_number { get; set; }
        public string account_number_sort_code { get; set; }
    }
}
