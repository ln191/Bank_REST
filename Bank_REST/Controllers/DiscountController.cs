using Bank_REST.Models;
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
        // GET: api/Discount/5
        public Discount Get(string customerType)
        {
            Discount dis = new Discount();
            switch (customerType)
            {
                case "New Customer":
                    dis.DiscountPercentage = 15;
                    break;

                case "Loyalty card":
                    dis.DiscountPercentage = 10;
                    break;

                case "Coupon":
                    dis.DiscountPercentage = 20;
                    break;

                default:
                    dis.DiscountPercentage = 0;
                    break;
            }
            return dis;
        }
    }
}