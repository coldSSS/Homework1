using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassWork3_16;

namespace OrderServiceForm
{
    public partial class Form1 : Form
    {

        public string SearchWay { get; set; }

        public OrderService orderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
            comboBoxSearchBy.DataBindings.Add("SelectedItem", this, "SearchWay");

            List<OrderItem> list1 = new List<OrderItem>();
            List<OrderItem> list2 = new List<OrderItem>();
            List<OrderItem> list3 = new List<OrderItem>();

            list1.Add(new OrderItem(1,1, "Book", 5, 5));
            list1.Add(new OrderItem(1,2, "watch", 100, 1));
            list1.Add(new OrderItem(1,3, "Pen", 3, 10));
            list2.Add(new OrderItem(2,4, "Book", 5, 6));
            list2.Add(new OrderItem(2,5, "watch", 100, 2));
            list2.Add(new OrderItem(2,6, "pen", 3, 1));
            list3.Add(new OrderItem(3,7, "Book", 5, 10));
            list3.Add(new OrderItem(3,8, "watch", 100, 0));
            list3.Add(new OrderItem(3,9, "pen", 3, 50));

            orderService.AddOrder(1, "Sender1", "Client1", list1);
            orderService.AddOrder(2, "Sender1", "Client2", list2);
            orderService.AddOrder(3, "Sender2", "Client3", list3);

            bindingSourceOrder.DataSource = orderService.orderList;
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            Form2 addOrderDialog = new Form2();
            addOrderDialog.ShowDialog();
            orderService.AddOrder(addOrderDialog.addOrder);

            bindingSourceOrder.ResetBindings(false);
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            int index = dataGridViewOrder.CurrentRow.Index;
            int id = (int)dataGridViewOrder.Rows[index].Cells["orderIdDataGridViewTextBoxColumn"].Value;
            orderService.DeleteOrder(id);
            bindingSourceOrder.ResetBindings(false);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            switch (SearchWay) 
            {
                case "订单号":
                    int id;
                    int.TryParse(textBox1.Text, out id);
                    bindingSourceOrder.DataSource = orderService.SearchOrderInOrderId(id);
                    break;
                case "商家":
                    bindingSourceOrder.DataSource = orderService.SearchOrderInSenderName(textBox1.Text);
                    break;
                case "客户":
                    bindingSourceOrder.DataSource = orderService.SearchOrderInClientName(textBox1.Text);
                    break;
                case "商品名":
                    bindingSourceOrder.DataSource = orderService.SearchOrderInProductName(textBox1.Text);
                    break;
            }
            if (textBox1.Text == "") 
            {
                bindingSourceOrder.DataSource = orderService.orderList;
            }
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            orderService.Export(file.FileName);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            orderService.Import(file.FileName);
            bindingSourceOrder.ResetBindings(false);
        }
    }
}
