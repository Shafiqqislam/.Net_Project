﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
   public class NoticeModel
    {
        public int id { get; set; }
        public string notice1 { get; set; }
        public string user_type { get; set; }
        public string status { get; set; }
        public System.DateTime datet { get; set; }
        public object Name { get; set; }
    }
}
