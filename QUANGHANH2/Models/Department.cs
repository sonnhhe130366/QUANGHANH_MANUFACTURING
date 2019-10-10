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
    
    public partial class Department
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Department()
        {
            this.Documentaries = new HashSet<Documentary>();
            this.Documentary_big_maintain_details = new HashSet<Documentary_big_maintain_details>();
            this.Documentary_big_maintain_details1 = new HashSet<Documentary_big_maintain_details>();
            this.Documentary_maintain_details = new HashSet<Documentary_maintain_details>();
            this.Documentary_maintain_details1 = new HashSet<Documentary_maintain_details>();
            this.Documentary_moveline_details = new HashSet<Documentary_moveline_details>();
            this.Documentary_moveline_details1 = new HashSet<Documentary_moveline_details>();
            this.Documentary_repair_details = new HashSet<Documentary_repair_details>();
            this.Documentary_repair_details1 = new HashSet<Documentary_repair_details>();
            this.Equipments = new HashSet<Equipment>();
            this.Incidents = new HashSet<Incident>();
            this.KeHoach_TieuChi = new HashSet<KeHoach_TieuChi>();
            this.Maintain_Car = new HashSet<Maintain_Car>();
            this.MealRegistrations = new HashSet<MealRegistration>();
            this.NhanViens = new HashSet<NhanVien>();
            this.Supply_tieuhao = new HashSet<Supply_tieuhao>();
            this.SupplyPlans = new HashSet<SupplyPlan>();
            this.SupplyPlans1 = new HashSet<SupplyPlan>();
            this.header_ThucHienTheoNgay = new HashSet<header_ThucHienTheoNgay>();
        }
    
        public string department_id { get; set; }
        public string department_name { get; set; }
        public string department_type { get; set; }
        public bool isInside { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary> Documentaries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_big_maintain_details> Documentary_big_maintain_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_big_maintain_details> Documentary_big_maintain_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_maintain_details> Documentary_maintain_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_maintain_details> Documentary_maintain_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_moveline_details> Documentary_moveline_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_moveline_details> Documentary_moveline_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_repair_details> Documentary_repair_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_repair_details> Documentary_repair_details1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment> Equipments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incident> Incidents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KeHoach_TieuChi> KeHoach_TieuChi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintain_Car> Maintain_Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MealRegistration> MealRegistrations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_tieuhao> Supply_tieuhao { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPlan> SupplyPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPlan> SupplyPlans1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<header_ThucHienTheoNgay> header_ThucHienTheoNgay { get; set; }
    }
}
