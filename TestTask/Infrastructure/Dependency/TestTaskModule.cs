using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestTask.Repositories;

namespace TestTask.Infrastructure.Dependency
{
    public class TestTaskModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IItemRepository>().To<ItemRepository>();
            Bind<ICategoryRepository>().To<CategoryRepository>();
        }
    }
}