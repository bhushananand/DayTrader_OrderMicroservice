using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DayTrader_OrderMicroservice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DayTrader_OrderMicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static readonly string[] Product = new[]
        {
            "Mobile", "TV", "Radio", "Calculator", "Laptop", "Mouse", "Server", "Speaker", "Earphone", "Bed"
        };
       
        
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(ILogger<OrdersController> logger)
        {
            _logger = logger;
        }
 // GET: api/Orders
        [HttpGet]
        public IEnumerable<Orders> Get()
        {
            int rng = 2;
            int num = 121;
            return Enumerable.Range(1, 5).Select(index => new Orders
            {
                OrderDate = DateTime.Now.AddDays(index),
                OrderID = rng + index,
                CustomerID = num + index,
                Product = Product[index]
            })
            .ToArray();
        }

        // GET: api/Orders/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<Orders> Get(int id)
        {
            return Enumerable.Range(1, 1).Select(index => new Orders
            {
                OrderDate = DateTime.Now.AddDays(index),
                OrderID = 2,
                CustomerID = 1211,
                Product = Product[index]
            })
            .ToArray();
        }

        // POST: api/Orders
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Orders/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
