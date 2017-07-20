using System.Collections.Generic;
using System.Web.Http;
using TestTask.Models;
using TestTask.Repositories;

namespace TestTask.Controllers
{
    public class ItemController : ApiController
    {
        private readonly IItemRepository _itemrepository;
        public ItemController(IItemRepository itemrepository)
        {
            _itemrepository = itemrepository;
        }
        
        [HttpGet]
        [Route("getItems")]
        public IEnumerable<Item> GetItems()
        {
            return _itemrepository.GetItems();
        }

    }
}
