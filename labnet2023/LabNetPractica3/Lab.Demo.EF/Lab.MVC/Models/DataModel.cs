using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.MVC.Models
{
    public class DataModel
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int UserId { get; set; }

    }
}