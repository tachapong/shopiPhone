using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shopapi.Models;

namespace shopapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private static List<Order> orders = new List<Order>();
        private static int Counter = 1;

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Order order)
        {
            var ordergroup = new Order
            {
                Id = $"Order0{Counter++}",
                Name = "iPhone",
                Amount = order.Amount,
                Price = order.Price,
                Sum = order.Amount * order.Price,
                Group = new logic().result(order.Amount * order.Price)

            };
            orders.Add(ordergroup);

        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Order>> Get()
        {
            return orders;
        }

        // // GET api/values
        // [HttpGet]
        // public ActionResult<Grouporder> Get()
        // {
        //     var od = new Grouporder
        //     {
        //         ordergroup = orders,
        //         Average = Math.Round(orders.Average(it => it.Sum), 2)

        //     };
        //     return od;


        // }


    }
}
