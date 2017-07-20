using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Infrastructure;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class ItemRepository : IItemRepository
    {
        TestDataContext context = new TestDataContext();
        public void Add(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();

        }

        public void Edit(Item item)
        {
            context.Entry(item).State = System.Data.Entity.EntityState.Modified;
        }

        public void Remove(int Id)
        {
            var item = context.Items.Find(Id);
            context.Items.Remove(item);
            context.SaveChanges();
        }

        public IEnumerable<Item> GetItems()
        {
            return context.Items;
        }
    }
}