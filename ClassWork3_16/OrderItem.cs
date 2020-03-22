using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_16
{
    class OrderItem
    {
        public int OrderItemId { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Number { get; set; }
        public double OrderItemSum{get;}

        public OrderItem(int OrderItemId, string Product, double Price, int Number) 
        {
            this.OrderItemId = OrderItemId;
            this.Product = Product;
            this.Price = Price;
            this.Number = Number;
            OrderItemSum = Number * Price;
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
            return  " orderItemId:" + OrderItemId + "  product:" + Product + "  number:" + Number + "  OrderItemSum:" + OrderItemSum;
        }
    }
}
