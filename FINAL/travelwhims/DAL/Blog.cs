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
    
    public partial class Blog
    {
        public Blog()
        {
            this.Blogcomments = new HashSet<Blogcomment>();
        }
    
        public int id { get; set; }
        public string blg_title { get; set; }
        public string blg_des { get; set; }
        public string blg_img1 { get; set; }
        public string blg_img2 { get; set; }
        public string blg_img3 { get; set; }
        public string blg_img4 { get; set; }
        public string blg_img5 { get; set; }
        public int blg_user_fk { get; set; }
        public byte[] blg_datetime { get; set; }
        public string blg_status { get; set; }
    
        public virtual ICollection<Blogcomment> Blogcomments { get; set; }
        public virtual User User { get; set; }
    }
}
