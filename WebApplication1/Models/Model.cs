using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Model
    {
        public string Username { get; set; }
        public List<string> Products { get; set; }
        public string SingleProduct { get; internal set; }
    }
}