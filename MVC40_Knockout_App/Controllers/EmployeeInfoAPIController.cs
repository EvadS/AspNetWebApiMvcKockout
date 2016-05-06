using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVC40_Knockout_App.Controllers
{
    public class EmployeeInfoAPIController : ApiController
    {
        // GET api/employeeinfoapi
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/employeeinfoapi/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/employeeinfoapi
        public void Post([FromBody]string value)
        {
        }

        // PUT api/employeeinfoapi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/employeeinfoapi/5
        public void Delete(int id)
        {
        }
    }
}
