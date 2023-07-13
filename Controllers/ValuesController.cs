using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication11.Models;

namespace WebApplication11.Controllers
{
    public class ValuesController : ApiController
    {

        // GET api/values/5
        public int Get()
        {
            return Model.getExpense("ajay");
        }
        // GET api/values
        public int Get(int i)
        {
            return Model.getExpense("ajay");
        }

        

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
