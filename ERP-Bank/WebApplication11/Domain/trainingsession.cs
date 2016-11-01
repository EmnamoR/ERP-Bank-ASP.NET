using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class trainingsession
    {
        public trainingsession()
        {
            this.employees = new List<employee>();
        }

        public int id { get; set; }
        public string description { get; set; }
        public string endDate { get; set; }
        public string startDate { get; set; }
        public virtual ICollection<employee> employees { get; set; }
    }
}
