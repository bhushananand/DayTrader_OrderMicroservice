using System;

namespace DayTrader_OrderMicroservice
{
    public class Order
    {
        

        public int OrderID { get; set; }

        public DateTime OrderDate { get; set; }

        public int CustomerID { get; set; }

        public string Product { get; set; }
    }
}
