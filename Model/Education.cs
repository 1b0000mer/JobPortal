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
    
    public partial class Education
    {
        public int USERID { get; set; }
        public int EduID { get; set; }
        public string NameEdu { get; set; }
        public string FromEdu { get; set; }
        public string DecripEdu { get; set; }
    
        public virtual InfoUser InfoUser { get; set; }
    }
}