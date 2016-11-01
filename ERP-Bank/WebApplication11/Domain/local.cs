using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class local
    {
        public local()
        {
            this.employees = new List<employee>();
            this.materials = new List<material>();
        }

        public int id { get; set; }
        public string city { get; set; }
        public string region { get; set; }
        public string typeLocal { get; set; }
        public virtual ICollection<employee> employees { get; set; }
        public virtual ICollection<material> materials { get; set; }
    }
}
