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
    
    public partial class Customer
    {
        public Customer()
        {
            this.CustomerPackages = new HashSet<CustomerPackage>();
        }
    
        public int id { get; set; }
        public string c_name { get; set; }
        public string c_username { get; set; }
        public int c_phone { get; set; }
        public string c_address { get; set; }
        public string c_dp { get; set; }
        public string c_mail { get; set; }
    
        public virtual ICollection<CustomerPackage> CustomerPackages { get; set; }
    }
}
