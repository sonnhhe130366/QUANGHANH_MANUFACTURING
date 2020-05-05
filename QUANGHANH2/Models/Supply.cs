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
    
    public partial class Supply
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supply()
        {
            this.Equipment_SCTX_Detail = new HashSet<Equipment_SCTX_Detail>();
            this.Fuel_activities_consumption = new HashSet<Fuel_activities_consumption>();
            this.Maintain_Car_Detail = new HashSet<Maintain_Car_Detail>();
            this.Supply_Documentary_Big_Maintain_Equipment = new HashSet<Supply_Documentary_Big_Maintain_Equipment>();
            this.Supply_Documentary_Camera = new HashSet<Supply_Documentary_Camera>();
            this.Supply_Documentary_Equipment = new HashSet<Supply_Documentary_Equipment>();
            this.Supply_Documentary_Maintain_Equipment = new HashSet<Supply_Documentary_Maintain_Equipment>();
            this.Supply_Documentary_Repair_Equipment = new HashSet<Supply_Documentary_Repair_Equipment>();
            this.Supply_Equipment_DiKem = new HashSet<Supply_Equipment_DiKem>();
            this.Supply_SCTX = new HashSet<Supply_SCTX>();
            this.Supply_tieuhao = new HashSet<Supply_tieuhao>();
            this.SupplyPlans = new HashSet<SupplyPlan>();
            this.SupplyPlans1 = new HashSet<SupplyPlan>();
            this.Vattu_Dikem = new HashSet<Vattu_Dikem>();
        }
    
        public string supply_id { get; set; }
        public string supply_name { get; set; }
        public string unit { get; set; }
        public Nullable<double> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment_SCTX_Detail> Equipment_SCTX_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fuel_activities_consumption> Fuel_activities_consumption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintain_Car_Detail> Maintain_Car_Detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Documentary_Big_Maintain_Equipment> Supply_Documentary_Big_Maintain_Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Documentary_Camera> Supply_Documentary_Camera { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Documentary_Equipment> Supply_Documentary_Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Documentary_Maintain_Equipment> Supply_Documentary_Maintain_Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Documentary_Repair_Equipment> Supply_Documentary_Repair_Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Equipment_DiKem> Supply_Equipment_DiKem { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_SCTX> Supply_SCTX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_tieuhao> Supply_tieuhao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPlan> SupplyPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPlan> SupplyPlans1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vattu_Dikem> Vattu_Dikem { get; set; }
    }
}
