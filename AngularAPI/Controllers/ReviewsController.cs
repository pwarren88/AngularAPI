using AngularAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularAPI.Controllers
{
    public class ReviewsController : ApiController
    {        
        // POST api/values
        public void Post([FromBody]ProductModel value)
        {
            //TODO: Save to a database next week.
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Dodecahedron"].ConnectionString))
            {
                SqlCommand command = connection.CreateCommand();
                connection.Open();
                //Lambda expression looking for first review with id of 0
                var newReview = value.reviews.First(x => x.id == 0);

                command.CommandText = string.Format("INSERT INTO Review(ProductId, stars, author, body)VALUES({0},{1},'{2}','{3}',)",
                value.id, newReview.stars, newReview.author, newReview.body);



                command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
