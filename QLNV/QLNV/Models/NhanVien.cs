//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLNV.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public int manhanvien { get; set; }
        public string tennhanvien { get; set; }
        public Nullable<System.DateTime> ngaysinh { get; set; }
        public Nullable<decimal> luong { get; set; }
        public byte[] hinhanh { get; set; }
        public Nullable<int> maphong { get; set; }
    
        public virtual PhongBang PhongBang { get; set; }
    }
}
