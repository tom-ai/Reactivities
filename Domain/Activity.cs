using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Activity
    {
        // Entity Framework recognises Id as the primary key
        public Guid Id { get; set; } // generate Id on client side for zero response time
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string City { get; set; }
        public string Venue { get; set; }

        public string Category { get; set; }


    }
}