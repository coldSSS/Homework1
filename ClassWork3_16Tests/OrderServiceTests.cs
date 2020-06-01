using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassWork3_16;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace ClassWork3_16.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService testSevice = new OrderService();
        [TestInitialize()]
        public void Initialize() 
        {
            List<OrderItem> list1 = new List<OrderItem>();
            List<OrderItem> list2 = new List<OrderItem>();
            List<OrderItem> list3 = new List<OrderItem>();

            list1.Add(new OrderItem(1, "Book", 5, 5));
            list1.Add(new OrderItem(2, "watch", 100, 1));
            list1.Add(new OrderItem(3, "Pen", 3, 10));
            list2.Add(new OrderItem(4, "Book", 5, 6));
            list2.Add(new OrderItem(5, "watch", 100, 2));
            list2.Add(new OrderItem(6, "pen", 3, 1));
            list3.Add(new OrderItem(7, "Book", 5, 10));
            list3.Add(new OrderItem(8, "watch", 100, 0));
            list3.Add(new OrderItem(9, "pen", 3, 50));

            testSevice.AddOrder(10, "Sender1", "Client1", list1);
            testSevice.AddOrder(11, "Sender1", "Client2", list2);
            testSevice.AddOrder(12, "Sender2", "Client3", list3);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            List<OrderItem> list1 = new List<OrderItem>();
            list1.Add(new OrderItem(1, "Book", 5, 5));
            testSevice.AddOrder(10, "Sender1", "Client1", list1);

            Assert.IsNotNull(testSevice.SearchOrderInOrderId(10)) ;
        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            testSevice.DeleteOrder(10);

            Assert.IsNull(testSevice.SearchOrderInOrderId(10));
        }

        [TestMethod()]
        public void ChangeOrderTest()
        {
            List<OrderItem> list4 = new List<OrderItem>();
            list4.Add(new OrderItem(1, "Book", 5, 5));
            list4.Add(new OrderItem(2, "watch", 100, 1));
            list4.Add(new OrderItem(3, "Pen", 3, 10));
            testSevice.ChangeOrder(11, 14, "Sender3", "Client4", list4);

            Assert.IsNull(testSevice.SearchOrderInOrderId(11));
            Assert.IsNotNull(testSevice.SearchOrderInOrderId(14));
        }

        [TestMethod()]
        public void SearchOrderInOrderIdTest()
        {
            Assert.AreEqual(testSevice.SearchOrderInOrderId(10).OrderId, 10);
        }

        [TestMethod()]
        public void SearchOrderInSenderNameTest()
        {
            List<Order> ls = testSevice.SearchOrderInSenderName("Sender1");
            foreach (Order i in ls)
            {
                Assert.AreEqual(i.SenderName, "Sender1");
            }
        }

        [TestMethod()]
        public void SearchOrderInClientNameTest()
        {
            List<Order> ls = testSevice.SearchOrderInClientName("Client1");
            foreach (Order i in ls)
            {
                Assert.AreEqual(i.ClientName, "Client1");
            }
        }

        [TestMethod()]
        public void SearchOrderInProductNameTest()
        {
            bool flag = false;
            List<Order> ls = testSevice.SearchOrderInProductName("Book");
            foreach (Order i in ls)
            {
                foreach (OrderItem j in i.orderItemList) 
                {
                    flag = flag || String.Equals(j.Product,"Book");
                }
                Assert.IsTrue(flag);
                flag = false;
            }

        }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "orders.xml";
            testSevice.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("expectedOrders.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            testSevice.Import("orders.xml");
            Assert.AreEqual(testSevice.orderList.Count, 3);
        }
    }
}