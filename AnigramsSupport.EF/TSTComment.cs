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
    
    public partial class TSTComment
    {
        public int CommentID { get; set; }
        public string Comment { get; set; }
        public int PostedBy { get; set; }
        public System.DateTime DatePosted { get; set; }
        public int TicketID { get; set; }
    
        public virtual TSTTicket TSTTicket { get; set; }
        public virtual TSTUser TSTUser { get; set; }
    }
}
