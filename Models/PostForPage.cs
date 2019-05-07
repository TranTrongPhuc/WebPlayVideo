using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebASPNETCore.Models
{
    public enum StatusPostForPage
    {
        AddNewUpdate, Delete
    }
    public class PostForPage
    {
        [Key]
        public int ID { get; set; }
        public string PostName { get; set; }
        public int WebPageID { get; set; }
        public string Descritption { get; set; }
        public string Content { get; set; }
        public string URLVideo { get; set; }
        public string CreateBy { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        public string ModifyBy { get; set; }
        [DataType(DataType.Date)]
        public DateTime ModifyDate { get; set; }
        public StatusPostForPage? Status { get; set; }
    }
}
