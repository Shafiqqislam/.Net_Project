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
    
    public partial class TravelAgency
    {
        public TravelAgency()
        {
            this.CustomerPackages = new HashSet<CustomerPackage>();
            this.Packages = new HashSet<Package>();
        }
    
        public int id { get; set; }
        public string ta_name { get; set; }
        public string ta_username { get; set; }
        public string ta_rating { get; set; }
        public string ta_bio { get; set; }
        public string ta_mail { get; set; }
        public int ta_phone { get; set; }
        public string ta_dp { get; set; }
        public string ta_officeaddress { get; set; }
    
        public virtual ICollection<CustomerPackage> CustomerPackages { get; set; }
        public virtual ICollection<Package> Packages { get; set; }
    }
}