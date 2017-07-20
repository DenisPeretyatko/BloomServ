using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestTask.Models;

namespace TestTask.Infrastructure
{
    public class CityDbInitalize : DropCreateDatabaseIfModelChanges<TestDataContext>
    {
        protected override void Seed(TestDataContext context)
        {
            context.Items.Add(
                  new Item
                  {
                      Id = 1,
                      Title = "Delhi",
                      Description = "Russia",
                      CategoryId = 1
                  });

            context.Items.Add(
                  new Item
                  {
                      Id = 2,
                      Title = ".NET",
                      Description = "Poland",
                      CategoryId = 1
                  });

            context.Items.Add(
                   new Item
                   {
                       Id = 3,
                       Title = "Java",
                       Description = "USA",
                       CategoryId = 2
                   });
            context.Categories.Add(
                  new Category
                  {
                      Id = 1,
                      Title = "Asia",
                      Description = "created in 2012"
                  });
            context.Categories.Add(
                   new Category
                   {
                       Id = 2,
                       Title = "America",
                       Description = "created in 2005"
                   });

            context.SaveChanges();

            base.Seed(context);

        }
    }
}