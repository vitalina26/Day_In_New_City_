using System;
using System.Collections.Generic;

#nullable disable

namespace Day_In_New_City_
{
    public partial class CategoriesOfEvent
    {
        public CategoriesOfEvent()
        {
            Events = new HashSet<Event>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
