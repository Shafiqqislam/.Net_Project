using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class PackageModel
    {
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

        public virtual ICollection<CustomerPackage> CustomerPackages { get; set; }
        public virtual TravelAgency TravelAgency { get; set; }
    }
}
