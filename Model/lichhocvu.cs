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
    
    public partial class lichhocvu
    {
        public string MaMonHoc { get; set; }
        public byte Nhom { get; set; }
        public string MaPhong { get; set; }
        public byte Thu { get; set; }
        public byte TietBD { get; set; }
        public byte SoTiet { get; set; }
        public byte TuanBD { get; set; }
        public byte SoTuan { get; set; }
    
        public virtual nhom nhom1 { get; set; }
        public virtual phong phong { get; set; }
    }
}
