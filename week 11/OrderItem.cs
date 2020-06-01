using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_16
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public double OrderItemSum{ get; set; }

        public int OrderId { get; set; }

        public OrderItem(int OrderId, int OrderItemId, string Product, double Price, int Number) 
        {
            this.OrderId = OrderId;
            this.OrderItemId = OrderItemId;
            this.Product = Product;
            this.Price = Price;
            this.Number = Number;
            OrderItemSum = Number * Price;
        }

        public OrderItem() 
        {

        }
        public override bool Equals(object obj)
        {
            if (base.Equals(obj))
            {
                OrderItem order = (OrderItem)obj;
                return  this.OrderItemId == order.OrderItemId;
            }

            return false;
        }


        public override string ToString()
        {
            return  "orderId: " + OrderId + " orderItemId:" + OrderItemId + "  product:" + Product + "  number:" + Number + "  OrderItemSum:" + OrderItemSum;
        }
    }
}
