//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kryptos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MessageTransaction
    {
        public int MessageTransactionId { get; set; }
        public int MessageId { get; set; }
        public int USERID { get; set; }
        public int GroupId { get; set; }
        public bool IsSender { get; set; }
        public bool IsDelivered { get; set; }
        public Nullable<System.DateTime> DeliveredTimeStamp { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<System.DateTime> ReadTimeStamp { get; set; }
        public Nullable<bool> IsArchive { get; set; }
        public Nullable<System.DateTime> ArchiveTimeStamp { get; set; }
        public Nullable<bool> IsUrgent { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
        public string CreatedById { get; set; }
        public string ModifiedById { get; set; }
    }
}
