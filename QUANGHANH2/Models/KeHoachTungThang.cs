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
    
    public partial class KeHoachTungThang
    {
        public int HeaderID { get; set; }
        public Nullable<int> ThangKeHoach { get; set; }
        public Nullable<int> NamKeHoach { get; set; }
        public Nullable<int> SoNgayLamViec { get; set; }
    
        public virtual header_KeHoachTungThang header_KeHoachTungThang { get; set; }
    }
}
