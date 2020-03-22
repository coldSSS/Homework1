using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_16
{
    class OrderService
    {
        List<Order> orderList = new List<Order>();

        public void AddOrder(int OrderId, string SenderName, string ClientName, List<OrderItem> list) 
        {
            orderList.Add(new Order(OrderId, SenderName, ClientName, list));
        }

        public void DeleteOrder(int orderId) 
        {
            try
            {
                Order orderDelete = SearchOrderInOrderId(orderId);
                orderList.Remove(orderDelete);
            }
            catch (NullReferenceException) 
            {
                Console.WriteLine("Sorry, there is no such order");
            }
        }

        public void ChangeOrder(int oldOrderId, int newOrderId, string newSenderName, string newClientName, List<OrderItem> list) 
        {
            try
            {
                DeleteOrder(oldOrderId);
                AddOrder(newOrderId, newSenderName, newClientName, list);
            }
            catch (NullReferenceException) 
            {
                Console.WriteLine("Sorry, there is no such order");
            }
        }

        public Order SearchOrderInOrderId(int orderId) 
        {
            var q = from order in orderList
                    where order.OrderId == orderId
                    orderby order.OrderSum
                    select order;
            try
            {
                return q.ToList()[0];
            }
            catch (ArgumentOutOfRangeException) 
            {
                Console.WriteLine("Sorry, NO Result");
                return null;
            }
           
           
        }

        public List<Order> SearchOrderInSenderName(string senderName)
        {
            var q = from order in orderList
                    where order.SenderName == senderName
                    orderby order.OrderSum
                    select order;
            return q.ToList();
        }
        public List<Order> SearchOrderInClientName(string clientName)
        {
            var q = from order in orderList
                    where order.ClientName == clientName
                    orderby order.OrderSum
                    select order;
            return q.ToList();
        }
    }
}
