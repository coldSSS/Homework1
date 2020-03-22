using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_16
{
    class Order
    {
        public int OrderId { get; }
        public string SenderName { get; }
        public string ClientName { get; }
        public double OrderSum { get; }
        public List<OrderItem> orderItemList;

        public Order(int OrderId, string SenderName, string ClientName, List<OrderItem> list) 
        {
            this.OrderId = OrderId;
            this.SenderName = SenderName;
            this.ClientName = ClientName;
            this.orderItemList = list;
            foreach (OrderItem i in orderItemList)
            {
                OrderSum += i.OrderItemSum;
            }

        }
        public override bool Equals(object obj)
        {
            if (base.Equals(obj)) 
            {
                Order order = (Order)obj;
                return this.OrderId == order.OrderId;
            }

            return false;
        }

        public override string ToString()
        {
            return "OrderId: " + OrderId + "  SenderName: " + SenderName + "  ClientName: " + ClientName + "  OrderSum" + OrderSum;
        }
    }
}
