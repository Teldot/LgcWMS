//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LgcWMS.Data.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class ASFW_ACTIVESESSION
    {
        public System.Guid ACTIVESESSIONID { get; set; }
        public int USERID { get; set; }
        public System.DateTime LASTACTIVITY { get; set; }
        public int COMPANYID { get; set; }
    
        public virtual ASFW_COMPANY ASFW_COMPANY { get; set; }
        public virtual ASFW_USER ASFW_USER { get; set; }
    }
}
