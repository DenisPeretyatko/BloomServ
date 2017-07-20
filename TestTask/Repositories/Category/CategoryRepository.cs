using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Infrastructure;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        TestDataContext context = new TestDataContext();
        public void Add(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();

        }

        public void Edit(Category category)
        {
            context.Entry(category).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            var category = context.Categories.Find(Id);
            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories;
        }
    }
}