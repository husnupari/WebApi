using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace husnuWebApi.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string genre { get; set; }

    }
}