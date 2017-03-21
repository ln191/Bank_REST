using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Bank_REST.Models;

namespace Bank_REST.Controllers
{
    public class InterestController : ApiController
    {
        // GET: api/Interest/5
        public Interest Get(double balance)
        {
            Interest amount = new Interest();
            if (balance >= 0 && balance <= 100.00)
            {
                amount.interest = (balance / 100) * 3;
            }
            else if (balance > 100.00 && balance < 1000.00)
            {
                amount.interest = (balance / 100) * 5;
            }
            else if (balance >= 1000.00)
            {
                amount.interest = (balance / 100) * 7;
            }
            else
            {
                amount.interest = 0;
            }
            return amount;
        }
    }
}