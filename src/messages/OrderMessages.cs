using EasyNetQ;
using System;

namespace messages
{
    //[Queue("OrderCreatedQueue",ExchangeName = "OrderCreatedExchange")]
    public class OrderCreatedMessage
    {
        public int OrderId { get; set; }
        public string CustomerCode { get; set; }
        public string OrderNumber { get; set; }
        public decimal OrderAmount { get; set; }
    }
}
