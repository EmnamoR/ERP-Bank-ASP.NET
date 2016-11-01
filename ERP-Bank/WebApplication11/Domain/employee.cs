using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Models
{
    public partial class employee
    {
        public employee(string id , string email, string password, string username, string name, string lastname, string role)
        {
            this.id = id;
            this.email = email;
            this.passWord = password;
            this.userName = username;
            this.name = name;
            this.lastName = lastname;
            this.role = role;
        }
        public employee()
        {
            //this.contracts = new List<contract>();
            //this.payrolls = new List<payroll>();
            //this.trainingsessions = new List<trainingsession>();
        }
       
        public string id { get; set; }
        public string email { get; set; }
        public string lastName { get; set; }
        public string name { get; set; }
        public string passWord { get; set; }
        public string role { get; set; }
        public string userName { get; set; }
        public Nullable<int> local_id { get; set; }
        public virtual ICollection<contract> contracts { get; set; }
        public virtual local local { get; set; }
        public virtual ICollection<payroll> payrolls { get; set; }
        public virtual ICollection<trainingsession> trainingsessions { get; set; }
    }
}
