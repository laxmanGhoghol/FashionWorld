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
    
    public partial class stock
    {
        public int ID { get; set; }
        public int PID { get; set; }
        public decimal Size_Small { get; set; }
        public decimal Size_Medium { get; set; }
        public decimal Size_Large { get; set; }
    
        public virtual products products { get; set; }
    }
}
