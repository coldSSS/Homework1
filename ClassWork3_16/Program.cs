using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_16
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService testSevice = new OrderService();

            List<OrderItem> list1 = new List<OrderItem>();
            List<OrderItem> list2 = new List<OrderItem>();
            List<OrderItem> list3 = new List<OrderItem>();

            list1.Add(new OrderItem(1,"Book",5,5));
            list1.Add(new OrderItem(2,"watch",100,1));
            list1.Add(new OrderItem(3, "Pen", 3, 10));
            list2.Add(new OrderItem(4, "Book", 5, 6));
            list2.Add(new OrderItem(5, "watch", 100, 2));
            list2.Add(new OrderItem(6, "pen", 3, 1));
            list3.Add(new OrderItem(7, "Book", 5, 10));
            list3.Add(new OrderItem(8, "watch", 100, 0));
            list3.Add(new OrderItem(9, "pen", 3, 50));

            testSevice.AddOrder(10, "Sender1", "Client1", list1);
            testSevice.AddOrder(11, "Sender1", "Client2", list2);
            Console.WriteLine(testSevice.SearchOrderInOrderId(10).OrderId);
           

            foreach (Order i in testSevice.SearchOrderInSenderName("Sender1")) 
            {
                Console.WriteLine(i);
            }

            testSevice.ChangeOrder(15, 14, "Sender2", "Client3", list3);
            testSevice.ChangeOrder(10, 14, "Sender2", "Client3", list3);

            foreach (Order i in testSevice.SearchOrderInSenderName("Sender1"))
            {
                Console.WriteLine(i);
            }

            testSevice.Export("orders.xml");
            testSevice.Import("orders.xml");
            Console.ReadLine();
        }
    }
}
