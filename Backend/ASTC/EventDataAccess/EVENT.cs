//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class EVENT
    {
        public int ID { get; set; }
        public string EventTitle { get; set; }
        public string EventDesc { get; set; }
        public Nullable<System.DateTime> EventDate { get; set; }
        public Nullable<System.TimeSpan> EventTime { get; set; }
    }
}
