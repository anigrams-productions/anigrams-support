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
    
    public partial class TSTMessage
    {
        public int MessageID { get; set; }
        public int Sender { get; set; }
        public int Recipient { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public System.DateTime DateSent { get; set; }
        public bool IsRead { get; set; }
        public bool IsActive { get; set; }
    
        public virtual TSTUser TSTUser { get; set; }
        public virtual TSTUser TSTUser1 { get; set; }
    }
}
