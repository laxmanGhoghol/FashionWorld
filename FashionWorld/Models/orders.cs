//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FashionWorld.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public orders()
        {
            this.payments1 = new HashSet<payments>();
        }
    
        public int ID { get; set; }
        public int CustID { get; set; }
        public int ProID { get; set; }
        public Nullable<int> PayID { get; set; }
        public System.DateTime Order_Date { get; set; }
        public string IsSuccess { get; set; }
    
        public virtual customers customers { get; set; }
        public virtual payments payments { get; set; }
        public virtual products products { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<payments> payments1 { get; set; }
    }
}
