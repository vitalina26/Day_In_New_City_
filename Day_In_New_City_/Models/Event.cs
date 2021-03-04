using System;
using System.Collections.Generic;

#nullable disable

namespace Day_In_New_City_
{
    public partial class Event
    {
        public Event()
        {
            EventComments = new HashSet<EventComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionInfo { get; set; }
        public string Contacts { get; set; }
        public string Address { get; set; }
        public DateTime? EventDay { get; set; }
        public int CategoryOfEventsId { get; set; }
        public int CityId { get; set; }

        public virtual CategoriesOfEvent CategoryOfEvents { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<EventComment> EventComments { get; set; }
    }
}
