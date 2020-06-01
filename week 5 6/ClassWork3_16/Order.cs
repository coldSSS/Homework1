using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_16
{
    public class Order
    {
       public int OrderId { get; set; }
        public string SenderName { get; set; }
        public string ClientName { get; set; }
        public double OrderSum { get; set; }
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

        public Order() 
        {

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

        public bool Exist(string productName) 
        {
            bool flag = false;
            foreach (OrderItem i in orderItemList) 
            {
                flag = flag || (i.Product == productName);
            }

            return flag;
        }
    }
}
