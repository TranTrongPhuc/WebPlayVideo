using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebASPNETCore.Models
{
    //public enum StatusAdmin
    //{
    //    AddNewUpdate, Delete
    //}
    public class Admin
    {
        //Class login
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Pass { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
    }
}
