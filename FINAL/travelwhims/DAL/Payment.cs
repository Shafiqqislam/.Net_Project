//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int id { get; set; }
        public int cuspac_id_fk { get; set; }
        public string pay_id { get; set; }
        public int pay_amount { get; set; }
        public string pay_mfs { get; set; }
        public int pay_phone { get; set; }
        public string pay_trxid { get; set; }
        public string pay_status { get; set; }
    
        public virtual CustomerPackage CustomerPackage { get; set; }
    }
}
