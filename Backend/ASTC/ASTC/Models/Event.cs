using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASTC.Models
{
    public class Event
    {
        public int ID { get; set; }

        public string EventTitle { get; set; }

        public string EventDesc { get; set; }

        public DateTime EventStart { get; set; }

        public DateTime EventEnd { get; set; }

        ////Foreign key

        //public int StudentID { get; set; }

        ////Navigation property
        //public virtual Student Student { get; set; }    
    }
}