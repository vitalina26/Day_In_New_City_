using System;
using System.Collections.Generic;

#nullable disable

namespace Day_In_New_City_
{
    public partial class CategoriesOfInstitution
    {
        public CategoriesOfInstitution()
        {
            Institutions = new HashSet<Institution>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
