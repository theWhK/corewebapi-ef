using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiV1.Infra.Context;
using WebApiV1.Infra.Models;

namespace WebApiV1.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<TodoItem>> Get()
        {
            var contexto = new TodoContext();
            var items = contexto.TodoItems.ToList();

            return items;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value2";
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
