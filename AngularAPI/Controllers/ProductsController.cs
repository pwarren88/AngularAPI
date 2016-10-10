using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAPI.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/products
        public IEnumerable<ProductModel> Get()
        {
            List<ProductModel> model = new List<ProductModel>();

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString))
            {               
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM Product";
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ProductModel product = new ProductModel();                    
                        product.id = reader.GetInt32(0);
                        product.name = reader.GetString(1);
                        product.canPurchase = reader.GetBoolean(5);
                        product.soldOut = reader.GetBoolean(4);
                        product.price = reader.GetDecimal(2);
                        product.description = reader.GetString(3);
                        product.images = new List<ImageModel>();
                        product.reviews = new List<ReviewModel>();
                        model.Add(product);
                    }
                }
                connection.Close();
            }

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString))
            {
                
                SqlCommand imageCommand = connection.CreateCommand();
                imageCommand.CommandText = "SELECT * FROM Image";
                connection.Open();
                using (SqlDataReader reader = imageCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foreach (ProductModel p in model)
                        {
                            if (p.id == reader.GetInt32(3))
                            {
                                ImageModel image = new ImageModel();
                                string[] imagearray = new string[] { };                                                                
                                image.id = reader.GetInt32(0);
                                image.full = reader.GetString(1);
                                image.thumb = reader.GetString(2);
                                image.productid = reader.GetInt32(3);
                                
                                p.images.Add(image);
                            }
                        }
                    }
                }
                connection.Close();
              
            }

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString))
            {
          
                SqlCommand reviewCommand = connection.CreateCommand();
                reviewCommand.CommandText = "SELECT * FROM Review";
                connection.Open();
                using (SqlDataReader reader = reviewCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        foreach (ProductModel p in model)
                        {
                            if (p.id == reader.GetInt32(4))
                            {
                                ReviewModel review = new ReviewModel();
                                review.id = reader.GetInt32(0);
                                review.stars = reader.GetInt32(1);
                                review.author = reader.GetString(2);
                                review.body = reader.GetString(3);
                                review.productid = reader.GetInt32(4);
                                p.reviews.Add(review);
                            }
                        }
                    }
                }
                connection.Close();
            }
            return model;
        }
    }
}
