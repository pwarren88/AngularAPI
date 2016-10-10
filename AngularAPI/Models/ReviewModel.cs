using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class ReviewModel
    {
        public string author { get; set; }
        public string body { get; set; }
        public int stars { get; set; }
        public int id { get; set; }
        public int productid { get; set; }
    }
}