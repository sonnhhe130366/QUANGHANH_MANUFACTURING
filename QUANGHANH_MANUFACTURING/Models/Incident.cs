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
    
    public partial class Incident
    {
        public int incident_id { get; set; }
        public string room_id { get; set; }
        public int incident_camera_quantity { get; set; }
        public System.DateTime start_time { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public string reason { get; set; }
        public bool disk_saveable { get; set; }
        public string disk_status { get; set; }
    
        public virtual Room Room { get; set; }
    }
}