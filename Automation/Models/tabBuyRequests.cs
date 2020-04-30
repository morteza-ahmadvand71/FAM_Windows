//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baran.Ferroalloy.Automation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tabBuyRequests
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tabBuyRequests()
        {
            this.tabBuyRequestItems = new HashSet<tabBuyRequestItems>();
            this.tabInvoiceItems = new HashSet<tabInvoiceItems>();
        }
    
        public int intID { get; set; }
        public Nullable<bool> bitSelect { get; set; }
        public int intNumber { get; set; }
        public int intDepartment { get; set; }
        public Nullable<int> intRowBudget { get; set; }
        public System.DateTime datDate { get; set; }
        public string nvcRequesterCoID { get; set; }
        public string nvcSupervisorCoID { get; set; }
        public string nvcPlantmanagerCoID { get; set; }
        public string nvcCeoCoID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabBuyRequestItems> tabBuyRequestItems { get; set; }
        public virtual tabDepartments tabDepartments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tabInvoiceItems> tabInvoiceItems { get; set; }
    }
}
