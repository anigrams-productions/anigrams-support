//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TST.DATA.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class TSTProjects_Users
    {
        public int Projects_UsersID { get; set; }
        public int ProjectID { get; set; }
        public int TSTUserID { get; set; }
    
        public virtual TSTProject TSTProject { get; set; }
        public virtual TSTUser TSTUser { get; set; }
    }
}
