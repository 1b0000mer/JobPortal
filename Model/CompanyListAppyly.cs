//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CompanyListAppyly
    {
        public int ComID { get; set; }
        public int JobID { get; set; }
        public int USERID { get; set; }
        public Nullable<bool> CHECKUSER { get; set; }
    
        public virtual CompanyInfo CompanyInfo { get; set; }
        public virtual InfoUser InfoUser { get; set; }
        public virtual Job Job { get; set; }
    }
}
