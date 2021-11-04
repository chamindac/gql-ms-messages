using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace messages
{
    public class CustomerOrderCreditAvailableMessage
    {
        public int OrderId { get; set; }
    }

    public class CustomerOrderCreditNotAvailableMessage
    {
        public int OrderId { get; set; }
    }
}
