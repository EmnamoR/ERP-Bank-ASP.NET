using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class contract
    {
        public int id { get; set; }
        public string contractType { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public string employee_id { get; set; }
        public virtual employee employee { get; set; }
    }
}
