//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANGHANH_MANUFACTURING.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DocumentaryType
    {
        public DocumentaryType()
        {
            this.Documentaries = new HashSet<Documentary>();
        }
    
        public int documentary_type { get; set; }
        public string documentary_name { get; set; }
    
        public virtual ICollection<Documentary> Documentaries { get; set; }
    }
}