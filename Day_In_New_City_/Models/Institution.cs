﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Day_In_New_City_
{
    public partial class Institution
    {
        public Institution()
        {
            InstitutionComments = new HashSet<InstitutionComment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string DescriptionInfo { get; set; }
        public string Contacts { get; set; }
        public string Address { get; set; }
        public int CategoryOfInstitutionsId { get; set; }
        public int CityId { get; set; }

        public virtual CategoriesOfInstitution CategoryOfInstitutions { get; set; }
        public virtual City City { get; set; }
        public virtual ICollection<InstitutionComment> InstitutionComments { get; set; }
    }
}
