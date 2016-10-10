using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class ProductModel
    {

        public string description { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public List <ImageModel> images { get; set; }
        public List <ReviewModel> reviews { get; set; }
        public bool canPurchase { get; internal set; }
        public bool soldOut { get; internal set; }
        public int id { get; set; }
    }
}