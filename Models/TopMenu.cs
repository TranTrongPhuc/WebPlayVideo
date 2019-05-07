using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebASPNETCore.Models
{
    public enum StatusTopMenu
    {
        AddNewUpdate, Delete
    }
    public class TopMenu
    {
        [Key]
        public int ID { get; set; }
        public string TopMenuName { get; set; }
        public int ParenID { get; set; }
        public StatusTopMenu? Status { get; set; }
    }
}
