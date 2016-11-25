using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Swashbuckle.Swagger.Annotations;
using DealShareService.Contract;
using System.Web.Http.Cors;

namespace DealItemsService.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [SwaggerOperation("GetAll")]
        public Items Get()
        {
            var items = new Items();
            items.itemList = new List<Item>();
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem",
                Description = "This is a item",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test.png")
                
            });
            return items;
        }

        // GET api/values/5
        [SwaggerOperation("GetById")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public Items Get(int id)
        {
            var items = new Items();
            items.itemList = new List<Item>();
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem1",
                Description = "This is item1",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem2",
                Description = "This is item 2",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test1.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem3",
                Description = "This is item 3",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test2.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem4",
                Description = "This is item 4",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test3.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem5",
                Description = "This is item 5",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test4.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem6",
                Description = "This is item 6",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test5.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem7",
                Description = "This is item 7",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test6.png")

            });
            items.itemList.Add(new Item()
            {
                Id = Guid.NewGuid().ToString(),
                ShortName = "TestItem8",
                Description = "This is item 8",
                ImageUrl = new Uri("https://dealsharedev.blob.core.windows.net/image/test7.PNG")

            });
            return items;
        }

        // POST api/values
        [SwaggerOperation("Create")]
        [SwaggerResponse(HttpStatusCode.Created)]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [SwaggerOperation("Update")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [SwaggerOperation("Delete")]
        [SwaggerResponse(HttpStatusCode.OK)]
        [SwaggerResponse(HttpStatusCode.NotFound)]
        public void Delete(int id)
        {
        }
    }
}
