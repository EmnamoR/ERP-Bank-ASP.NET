using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class candidature
    {
        public int id { get; set; }
        public string cv { get; set; }
        public string email { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string role { get; set; }
        public string state { get; set; }
    }
}
