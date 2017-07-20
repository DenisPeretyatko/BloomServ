using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Models;

namespace TestTask.Repositories
{
    public interface IItemRepository
    {
        void Add(Item product);
        void Edit(Item product);
        void Remove(int Id);
        IEnumerable<Item> GetItems();     
    }
}