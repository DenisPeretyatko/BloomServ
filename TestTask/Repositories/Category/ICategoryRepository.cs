using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Models;

namespace TestTask.Repositories
{
    public interface ICategoryRepository
    {
        void Add(Category category);
        void Edit(Category category);
        void Remove(int Id);
        IEnumerable<Category> GetCategories();     
    }
}