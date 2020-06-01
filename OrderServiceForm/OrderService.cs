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
        public List<Order> orderList { get; set; }
        public void AddOrder(int OrderId, string SenderName, string ClientName, List<OrderItem> list) 
        {
            Order order = new Order(OrderId, SenderName, ClientName, list);
            try
            {
                using (var db = new OrderContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException($"添加错误!");
            }
        }

        public void AddOrder(Order addOrder) 
        {
            using (var db = new OrderContext())
            {
                db.Orders.Add(addOrder);
                db.SaveChanges();
            }
        }

        public void DeleteOrder(int orderId) 
        {
            try
            {
                using (var db = new OrderContext())
                {
                    var order = db.Orders.Include("Items").
                        Where(o => o.OrderId == orderId).FirstOrDefault();
                    db.Orders.Remove(order);
                    db.SaveChanges();
                }
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
            using (var db = new OrderContext())
            {
                return db.Orders.Include("OrderItem").FirstOrDefault(o => o.OrderId == orderId);
            }


        }

        public List<Order> SearchOrderInSenderName(string senderName)
        {
            using (var db = new OrderContext())
            {
                var q = db.Orders.Include("OrderItem").
                    Where(o => o.SenderName == senderName).
                    OrderBy(o => o.OrderSum);

                return q.ToList();
            }
        }
        public List<Order> SearchOrderInClientName(string clientName)
        {
            using (var db = new OrderContext())
            {
                var q = db.Orders.Include("OrderItem").
                    Where(o => o.ClientName == clientName).
                    OrderBy(o => o.OrderSum);

                return q.ToList();
            }
        }

        public List<Order> SearchOrderInProductName(string productName)
        {
            List<Order> list = new List<Order>();
            var q = orderList.Where(order => order.orderItemList.Where(item => item.Product == productName).Count() > 0);
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
