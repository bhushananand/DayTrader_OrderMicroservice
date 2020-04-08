using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace DayTrader_OrderMicroservice.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly string[] Product = new[]
        {
            "Mobile", "TV", "Radio", "Calculator", "Laptop", "Mouse", "Server", "Speaker", "Earphone", "Bed"
        };

        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Order> Get()
        {
            int rng=2;
            int num=121;
            return Enumerable.Range(1, 5).Select(index => new Order
            {
                OrderDate = DateTime.Now.AddDays(index),
                OrderID = rng+index,
                CustomerID=num+index,
                Product = Product[index]
            })
            .ToArray();
        }
        
    }
}
