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
    
    public partial class CongViec
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CongViec()
        {
            this.CongViec_NhomCongViec = new HashSet<CongViec_NhomCongViec>();
            this.DieuDong_NhanVien = new HashSet<DieuDong_NhanVien>();
            this.DieuDong_NhanVien1 = new HashSet<DieuDong_NhanVien>();
            this.NhanViens = new HashSet<NhanVien>();
        }
    
        public int MaCongViec { get; set; }
        public string TenCongViec { get; set; }
        public Nullable<double> PhuCap { get; set; }
        public Nullable<int> MaThangLuong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CongViec_NhomCongViec> CongViec_NhomCongViec { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuDong_NhanVien> DieuDong_NhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DieuDong_NhanVien> DieuDong_NhanVien1 { get; set; }
        public virtual ThangLuong ThangLuong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
