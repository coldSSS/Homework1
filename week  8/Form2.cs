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
    public partial class Form2 : Form
    {
        public int addOrderItemId;
        public int addOrderItemNmber;
        public int addOrderId;
        public Order addOrder;
        List<OrderItem> addItemList = new List<OrderItem>();
        public Form2()
        {
            InitializeComponent();
            bindingSourceOrderItem.DataSource = addItemList;
        }

        private void buttonAddOrderItem_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxAddOrderItemId.Text, out addOrderItemId);
            int.TryParse(textBoxAddOrderItemNumber.Text, out addOrderItemNmber);
            OrderItem addItem = new OrderItem(addOrderItemId, textBoxAddOrderItemProduct.Text, 5, addOrderItemNmber);
            addItemList.Add(addItem);
            bindingSourceOrderItem.ResetBindings(false);
            textBoxAddOrderId.Text = "";
            textBoxAddOrderItemNumber.Text = "";
            textBoxAddOrderItemProduct.Text = "";
            double sum = 0;
            for (int i = 0; i < addItemList.Count; i ++)
            {
                sum += addItemList[i].OrderItemSum;
            }
        }

        private void buttonAddOrderItemDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            int ProductId = (int)dataGridView1.Rows[index].Cells["orderItemIdDataGridViewTextBoxColumn"].Value;
            for(int i = 0; i < addItemList.Count; i ++) 
            {
                if (addItemList[i].OrderItemId == ProductId) 
                {
                    addItemList.Remove(addItemList[i]);
                }
            }
            double sum = 0;
            for (int i = 0; i < addItemList.Count; i++)
            {
                sum += addItemList[i].OrderItemSum;
            }
            bindingSourceOrderItem.ResetBindings(false);
        }

        private void buttonAddOk_Click(object sender, EventArgs e)
        {
            int.TryParse(textBoxAddOrderId.Text, out addOrderId);
            Order addOrder = new Order(addOrderId, textBoxAddSenderName.Text, textBoxAddClientName.Text, addItemList);
            this.addOrder = addOrder;
            this.Close();
        }

        private void buttonAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
