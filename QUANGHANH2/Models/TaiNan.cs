//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANGHANH2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiNan
    {
        public int MaTaiNan { get; set; }
        public string MaNV { get; set; }
        public string LyDo { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> Ca { get; set; }
        public string Loai { get; set; }
        public string GhiChu { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
    }
}
