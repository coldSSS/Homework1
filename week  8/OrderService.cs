using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ClassWork3_16
{
    [Serializable]
    public class OrderService
    {
        public List<Order> orderList = new List<Order>();

        public void AddOrder(int OrderId, string SenderName, string ClientName, List<OrderItem> list) 
        {
            bool flag = true;
            Order order = new Order(OrderId, SenderName, ClientName, list);
            foreach (Order o in orderList) 
            {
                flag = flag && !o.Equals(order);
            }
            if (!flag)
            {
                Console.WriteLine("order exists in orderList");
                return;
            }
            orderList.Add(order);
        }

        public void AddOrder(Order addOrder) 
        {
            orderList.Add(addOrder);
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

        public List<Order> SearchOrderInProductName(string productName) 
        {
            List<Order> list = new List<Order>();
            var q = orderList.Where(order => order.orderItemList.Where(item => item.Product == productName).Count() > 0 );
            list = q.ToList();
            return list;
        }

        public void Export(string path) 
        {
            Console.WriteLine("Serializing...");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(path, FileMode.Create)) 
            {
                xmlSerializer.Serialize(fs, orderList);
            }
            Console.WriteLine("Serialized as XML");
        }

        public void Import(string path) 
        {
            using (FileStream fs = new FileStream(path, FileMode.Open)) 
            {
                Console.WriteLine("Deserializing...");
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
                orderList = (List<Order>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("Deserialized as orderList");
            }
        }
    }
}
