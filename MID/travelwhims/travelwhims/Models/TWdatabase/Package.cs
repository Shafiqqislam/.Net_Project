//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace travelwhims.Models.TWdatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Package
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Package()
        {
            this.CustomerPackages = new HashSet<CustomerPackage>();
        }
    
        public int id { get; set; }
        public string pac_title { get; set; }
        public string pac_bio { get; set; }
        public string pac_destinations { get; set; }
        public int pac_price { get; set; }
        public System.DateTime pac_tourdate { get; set; }
        public string pac_prerequisite { get; set; }
        public string pac_thumbnail { get; set; }
        public Nullable<System.DateTime> pac_returndate { get; set; }
        public string pac_class { get; set; }
        public string pac_category { get; set; }
        public int pac_ta_fk { get; set; }
        public string pac_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerPackage> CustomerPackages { get; set; }
        public virtual TravelAgency TravelAgency { get; set; }
    }
}
