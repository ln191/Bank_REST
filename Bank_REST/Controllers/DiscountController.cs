using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Bank_REST.Controllers
{
    public class DiscountController : ApiController
    {
        // GET: api/Discount
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Discount/5
        public string Get(int id)
        {
            return "value";
        }
    }
}