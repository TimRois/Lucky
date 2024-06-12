using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Lucky.Date.Models;
using Lucky.Date.Models.Account;

namespace Lucky.Date
{
    public class DBobjects
    {
        public static void initial(AppDbContent content)
        {

            //if (!content.Role.Any())
            //{
            //    content.Role.AddRange(
            //       new Role
            //       {
            //           Id = 1,
            //           Name = "admin"
            //       },
            //       new Role
            //       {
            //           Id = 2,
            //           Name = "user"
            //       }
            //    );
            //}
            //if (!content.User.Any())
            //{
            //    content.User.AddRange(
            //       new User
            //       {
            //           Id = 1,
            //           Login = "admin",
            //           Password = "admin",
            //           RoleId = 1

            //       }
            //    );
            //}






            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Pet.Any())
            {
                content.AddRange(
                     new Pet
                     {
                         name = "Собачка 1",
                         shortDesc = "Просто собачка",
                         img = "/img/1.jpg",
                         vaccinations = "Да",
                         breed = "дворняга",
                         Category = Categories["Dogs"]
                     },
                 new Pet
                 {
                     name = "Собачка 2",
                     shortDesc = "Просто собачка",
                     img = "/img/2.jpg",
                     vaccinations = "Да",
                     breed = "дворняга",
                     Category = Categories["Dogs"]
                 },
                  new Pet
                  {
                      name = "Котик 1",
                      shortDesc = "Просто котик",
                      img = "/img/3.jpg",
                      vaccinations = "Да",
                      breed = "дворовой кот",
                      Category = Categories["Cats"]
                  }
                 );
            }


            content.SaveChanges();
        }


        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                            {
                          new Category { category_name= "Dogs", desc = "Собачки" },
                          new Category { category_name= "Cats", desc = "Котики" }
                            };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.category_name, el);
                    }
                }
                return category;
            }
        }

    }


}

