using System;
using System.Collections.Generic;

#nullable disable

namespace Day_In_New_City_
{
    public partial class InstitutionComment
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public DateTime DateOfСreation { get; set; }
        public int InstitutionId { get; set; }

        public virtual Institution Institution { get; set; }
    }
}
