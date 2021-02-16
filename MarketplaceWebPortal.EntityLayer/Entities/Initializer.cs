using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketplaceWebPortal.EntityLayer.Entities
{

    // Initialize DB with test data

    public class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Entities>
    {
        /*
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string ImgUrl { get; set; }
         */
        protected override void Seed(Entities context)
        {
            var user = new List<User>
            {
                new User
                {
                    UserName = "John",
                    Password = "abc123",
                    Email = "tropicalserver501@gmail.com",
                    ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTHKwTOtiKg4sLGmmctI9m7Xa2UhltKFrTyLZ1GH9qiB5MVr4hcuY-uf0ZnYrD8QoKZC87BWaeH&usqp=CAc"
                },

                new User
                {
                    UserName = "Becky",
                    Password = "abc1234",
                    Email = "tropicalserver502@gmail.com",
                    ImgUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTHKwTOtiKg4sLGmmctI9m7Xa2UhltKFrTyLZ1GH9qiB5MVr4hcuY-uf0ZnYrD8QoKZC87BWaeH&usqp=CAc"

                }
            };
            //add each row of records into User table and save changes
            user.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

        }
    }