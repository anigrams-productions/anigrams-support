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
    
    public partial class TSTUserContact
    {
        public int ContactID { get; set; }
        public int TSTUserID { get; set; }
        public int FriendID { get; set; }
    
        public virtual TSTUser TSTUser { get; set; }
        public virtual TSTUser TSTUser1 { get; set; }
    }
}
