//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class bomon
    {
        public bomon()
        {
            this.giaoviens = new HashSet<giaovien>();
            this.monhocs = new HashSet<monhoc>();
        }
    
        public string MaBoMon { get; set; }
        public string TenBoMon { get; set; }
        public string KhoaQL { get; set; }
    
        public virtual khoa khoa { get; set; }
        public virtual ICollection<giaovien> giaoviens { get; set; }
        public virtual ICollection<monhoc> monhocs { get; set; }
    }
}
