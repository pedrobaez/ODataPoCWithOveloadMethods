//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ODataExample.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class EmployeePayHistory
    {
        [Key]
        public int BusinessEntityID { get; set; }
        public System.DateTime RateChangeDate { get; set; }
        public decimal Rate { get; set; }
        public byte PayFrequency { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
