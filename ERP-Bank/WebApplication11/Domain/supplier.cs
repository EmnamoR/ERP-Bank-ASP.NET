using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class supplier
    {
        public supplier()
        {
            this.materials = new List<material>();
        }

        public int id_supp { get; set; }
        public string adress { get; set; }
        public string email { get; set; }
        public string name { get; set; }
        public virtual ICollection<material> materials { get; set; }
    }
}
