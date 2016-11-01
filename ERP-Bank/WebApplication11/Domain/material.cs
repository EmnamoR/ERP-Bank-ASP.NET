using System;
using System.Collections.Generic;

namespace Data.Models
{
    public partial class material
    {
        public int idMat { get; set; }
        public string designation { get; set; }
        public int quantite { get; set; }
        public Nullable<int> local_id { get; set; }
        public Nullable<int> supplier_id_supp { get; set; }
        public virtual local local { get; set; }
        public virtual supplier supplier { get; set; }
    }
}
