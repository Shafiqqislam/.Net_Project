using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class RatingModel
    {
        public int id { get; set; }
        public int cuspacta_id { get; set; }
        public string r_review { get; set; }
        public string name { get; set; }
        public int r_rating { get; set; }
    }
}
