using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class payroll
    {
        public int id { get; set; }
        public float addsAmount { get; set; }
        public string endDate { get; set; }
        public int extraWorkedHours { get; set; }
        public string startDate { get; set; }
        public int workedHours { get; set; }
        public string employee_id { get; set; }
        public virtual employee employee { get; set; }
    }
}
