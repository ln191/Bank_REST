using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;

namespace Bank_REST.Controllers
{
    public class InterestController : ApiController
    {
        // GET: api/Interest
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Interest/5
        public string Get(double balance)
        {
            double amount;
            string answer;
            if (balance >= 0 && balance <= 100.00)
            {
                amount = (balance / 100) * 3;
            }
            else if (balance > 100.00 && balance < 1000.00)
            {
                amount = (balance / 100) * 5;
            }
            else if (balance >= 1000.00)
            {
                amount = (balance / 100) * 7;
            }
            else
            {
                return "invalid balance";
            }

            answer = "Monthly interest amount: " + amount + " $";

            return answer;
            //JsonSerializer json = new JsonSerializer();

            //return json.Serialize(answer);
        }
    }
}