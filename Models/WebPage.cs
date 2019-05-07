using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebASPNETCore.Models
{
    public enum StatusWebPage
    {
        AddNewUpdate, Delete
    }
    public class WebPage
    {
        [Key]
        public int ID { get; set; }
        public string WebPageName { get; set; }
        public int TopMenuID { get; set; }
        public StatusWebPage? Status { get; set; }
    }
}
