using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class ImageModel
    {
        public string full { get; set; }
        public int id { get; internal set; }
        public int productid { get; internal set; }
        public string thumb { get; set; }
    }
}