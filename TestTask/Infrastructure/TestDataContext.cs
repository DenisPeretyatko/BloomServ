using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TestTask.Models;

namespace TestTask.Infrastructure
{
    public class TestDataContext : DbContext
    {
        public TestDataContext() : base("name=Testconnectionstring")
       {

        }
        public IDbSet<Item> Items { get; set; }
        public IDbSet<Category> Categories { get; set; }
    }
}