//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminPanel4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class family
    {
        public string EMPNO { get; set; }
        public string MEMNAME { get; set; }
        public string NRICNO { get; set; }
        public string SEX { get; set; }
        public Nullable<System.DateTime> DATEBIRTH { get; set; }
    
        public virtual pmast pmast { get; set; }
    }
}