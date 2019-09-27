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
    
    public partial class Equipment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Equipment()
        {
            this.Acceptances = new HashSet<Acceptance>();
            this.Activities = new HashSet<Activity>();
            this.Category_attribute_value = new HashSet<Category_attribute_value>();
            this.Documentary_big_maintain_details = new HashSet<Documentary_big_maintain_details>();
            this.Documentary_liquidation_details = new HashSet<Documentary_liquidation_details>();
            this.Documentary_maintain_details = new HashSet<Documentary_maintain_details>();
            this.Documentary_moveline_details = new HashSet<Documentary_moveline_details>();
            this.Documentary_repair_details = new HashSet<Documentary_repair_details>();
            this.Documentary_revoke_details = new HashSet<Documentary_revoke_details>();
            this.Equipment_attribute = new HashSet<Equipment_attribute>();
            this.Equipment_Inspection = new HashSet<Equipment_Inspection>();
            this.Fuel_activities_consumption = new HashSet<Fuel_activities_consumption>();
            this.Incidents = new HashSet<Incident>();
            this.Maintain_Car = new HashSet<Maintain_Car>();
            this.Supply_Documentary_Equipment = new HashSet<Supply_Documentary_Equipment>();
            this.SupplyPlans = new HashSet<SupplyPlan>();
            this.SupplyPlans1 = new HashSet<SupplyPlan>();
        }
    
        public string equipmentId { get; set; }
        public string equipment_name { get; set; }
        public string supplier { get; set; }
        public System.DateTime date_import { get; set; }
        public double depreciation_estimate { get; set; }
        public double depreciation_present { get; set; }
        public System.DateTime durationOfInspection { get; set; }
        public System.DateTime durationOfInsurance { get; set; }
        public System.DateTime usedDay { get; set; }
        public System.DateTime nearest_Maintenance_Day { get; set; }
        public int total_operating_hours { get; set; }
        public string current_Status { get; set; }
        public Nullable<double> fabrication_number { get; set; }
        public string mark_code { get; set; }
        public string quality_type { get; set; }
        public string input_channel { get; set; }
        public string Equipment_category_id { get; set; }
        public string department_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Acceptance> Acceptances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Activity> Activities { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Category_attribute_value> Category_attribute_value { get; set; }
        public virtual Department Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_big_maintain_details> Documentary_big_maintain_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_liquidation_details> Documentary_liquidation_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_maintain_details> Documentary_maintain_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_moveline_details> Documentary_moveline_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_repair_details> Documentary_repair_details { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentary_revoke_details> Documentary_revoke_details { get; set; }
        public virtual Equipment_category Equipment_category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment_attribute> Equipment_attribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Equipment_Inspection> Equipment_Inspection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fuel_activities_consumption> Fuel_activities_consumption { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Incident> Incidents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Maintain_Car> Maintain_Car { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Documentary_Equipment> Supply_Documentary_Equipment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPlan> SupplyPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SupplyPlan> SupplyPlans1 { get; set; }
    }
}
