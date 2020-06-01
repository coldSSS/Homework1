namespace OrderServiceForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonAddCancel = new System.Windows.Forms.Button();
            this.buttonAddOk = new System.Windows.Forms.Button();
            this.groupBoxAddOrder = new System.Windows.Forms.GroupBox();
            this.labelOrderSumShow = new System.Windows.Forms.Label();
            this.labelOrderSum = new System.Windows.Forms.Label();
            this.textBoxAddClientName = new System.Windows.Forms.TextBox();
            this.textBoxAddSenderName = new System.Windows.Forms.TextBox();
            this.textBoxAddOrderId = new System.Windows.Forms.TextBox();
            this.labelAddClientName = new System.Windows.Forms.Label();
            this.labelAddSenderName = new System.Windows.Forms.Label();
            this.labelAddOrderId = new System.Windows.Forms.Label();
            this.buttonAddOrderItemDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderItemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceOrderItem = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAddOrderItem = new System.Windows.Forms.Button();
            this.groupBoxAddOrderItem = new System.Windows.Forms.GroupBox();
            this.textBoxAddOrderItemNumber = new System.Windows.Forms.TextBox();
            this.textBoxAddOrderItemProduct = new System.Windows.Forms.TextBox();
            this.textBoxAddOrderItemId = new System.Windows.Forms.TextBox();
            this.labelAddOrderItemNumber = new System.Windows.Forms.Label();
            this.labelAddOrderItemProduct = new System.Windows.Forms.Label();
            this.labelAddOrderItemId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxAddOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderItem)).BeginInit();
            this.groupBoxAddOrderItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddCancel);
            this.splitContainer1.Panel1.Controls.Add(this.buttonAddOk);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxAddOrder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddOrderItemDelete);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonAddOrderItem);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxAddOrderItem);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 0;
            // 
            // buttonAddCancel
            // 
            this.buttonAddCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddCancel.Location = new System.Drawing.Point(200, 338);
            this.buttonAddCancel.Name = "buttonAddCancel";
            this.buttonAddCancel.Size = new System.Drawing.Size(107, 43);
            this.buttonAddCancel.TabIndex = 2;
            this.buttonAddCancel.Text = "取消";
            this.buttonAddCancel.UseVisualStyleBackColor = true;
            this.buttonAddCancel.Click += new System.EventHandler(this.buttonAddCancel_Click);
            // 
            // buttonAddOk
            // 
            this.buttonAddOk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddOk.Location = new System.Drawing.Point(36, 338);
            this.buttonAddOk.Name = "buttonAddOk";
            this.buttonAddOk.Size = new System.Drawing.Size(107, 43);
            this.buttonAddOk.TabIndex = 1;
            this.buttonAddOk.Text = "确认";
            this.buttonAddOk.UseVisualStyleBackColor = true;
            this.buttonAddOk.Click += new System.EventHandler(this.buttonAddOk_Click);
            // 
            // groupBoxAddOrder
            // 
            this.groupBoxAddOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBoxAddOrder.Controls.Add(this.labelOrderSumShow);
            this.groupBoxAddOrder.Controls.Add(this.labelOrderSum);
            this.groupBoxAddOrder.Controls.Add(this.textBoxAddClientName);
            this.groupBoxAddOrder.Controls.Add(this.textBoxAddSenderName);
            this.groupBoxAddOrder.Controls.Add(this.textBoxAddOrderId);
            this.groupBoxAddOrder.Controls.Add(this.labelAddClientName);
            this.groupBoxAddOrder.Controls.Add(this.labelAddSenderName);
            this.groupBoxAddOrder.Controls.Add(this.labelAddOrderId);
            this.groupBoxAddOrder.Location = new System.Drawing.Point(36, 24);
            this.groupBoxAddOrder.Name = "groupBoxAddOrder";
            this.groupBoxAddOrder.Size = new System.Drawing.Size(271, 225);
            this.groupBoxAddOrder.TabIndex = 0;
            this.groupBoxAddOrder.TabStop = false;
            this.groupBoxAddOrder.Text = "订单信息";
            // 
            // labelOrderSumShow
            // 
            this.labelOrderSumShow.AutoSize = true;
            this.labelOrderSumShow.Location = new System.Drawing.Point(111, 192);
            this.labelOrderSumShow.Name = "labelOrderSumShow";
            this.labelOrderSumShow.Size = new System.Drawing.Size(15, 15);
            this.labelOrderSumShow.TabIndex = 7;
            this.labelOrderSumShow.Text = "0";
            // 
            // labelOrderSum
            // 
            this.labelOrderSum.AutoSize = true;
            this.labelOrderSum.Location = new System.Drawing.Point(20, 192);
            this.labelOrderSum.Name = "labelOrderSum";
            this.labelOrderSum.Size = new System.Drawing.Size(52, 15);
            this.labelOrderSum.TabIndex = 6;
            this.labelOrderSum.Text = "总金额";
            // 
            // textBoxAddClientName
            // 
            this.textBoxAddClientName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBoxAddClientName.Location = new System.Drawing.Point(92, 144);
            this.textBoxAddClientName.Name = "textBoxAddClientName";
            this.textBoxAddClientName.Size = new System.Drawing.Size(145, 25);
            this.textBoxAddClientName.TabIndex = 5;
            // 
            // textBoxAddSenderName
            // 
            this.textBoxAddSenderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddSenderName.Location = new System.Drawing.Point(92, 101);
            this.textBoxAddSenderName.Name = "textBoxAddSenderName";
            this.textBoxAddSenderName.Size = new System.Drawing.Size(145, 25);
            this.textBoxAddSenderName.TabIndex = 4;
            // 
            // textBoxAddOrderId
            // 
            this.textBoxAddOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxAddOrderId.Location = new System.Drawing.Point(92, 55);
            this.textBoxAddOrderId.Name = "textBoxAddOrderId";
            this.textBoxAddOrderId.Size = new System.Drawing.Size(145, 25);
            this.textBoxAddOrderId.TabIndex = 3;
            // 
            // labelAddClientName
            // 
            this.labelAddClientName.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelAddClientName.AutoSize = true;
            this.labelAddClientName.Location = new System.Drawing.Point(23, 147);
            this.labelAddClientName.Name = "labelAddClientName";
            this.labelAddClientName.Size = new System.Drawing.Size(37, 15);
            this.labelAddClientName.TabIndex = 2;
            this.labelAddClientName.Text = "客户";
            // 
            // labelAddSenderName
            // 
            this.labelAddSenderName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddSenderName.AutoSize = true;
            this.labelAddSenderName.Location = new System.Drawing.Point(23, 104);
            this.labelAddSenderName.Name = "labelAddSenderName";
            this.labelAddSenderName.Size = new System.Drawing.Size(37, 15);
            this.labelAddSenderName.TabIndex = 1;
            this.labelAddSenderName.Text = "商家";
            // 
            // labelAddOrderId
            // 
            this.labelAddOrderId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAddOrderId.AutoSize = true;
            this.labelAddOrderId.Location = new System.Drawing.Point(23, 58);
            this.labelAddOrderId.Name = "labelAddOrderId";
            this.labelAddOrderId.Size = new System.Drawing.Size(52, 15);
            this.labelAddOrderId.TabIndex = 0;
            this.labelAddOrderId.Text = "订单号";
            // 
            // buttonAddOrderItemDelete
            // 
            this.buttonAddOrderItemDelete.Location = new System.Drawing.Point(226, 255);
            this.buttonAddOrderItemDelete.Name = "buttonAddOrderItemDelete";
            this.buttonAddOrderItemDelete.Size = new System.Drawing.Size(107, 43);
            this.buttonAddOrderItemDelete.TabIndex = 3;
            this.buttonAddOrderItemDelete.Text = "删除";
            this.buttonAddOrderItemDelete.UseVisualStyleBackColor = true;
            this.buttonAddOrderItemDelete.Click += new System.EventHandler(this.buttonAddOrderItemDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderItemIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.orderItemSumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSourceOrderItem;
            this.dataGridView1.Location = new System.Drawing.Point(3, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(416, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // orderItemIdDataGridViewTextBoxColumn
            // 
            this.orderItemIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderItemIdDataGridViewTextBoxColumn.DataPropertyName = "OrderItemId";
            this.orderItemIdDataGridViewTextBoxColumn.HeaderText = "商品号";
            this.orderItemIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderItemIdDataGridViewTextBoxColumn.Name = "orderItemIdDataGridViewTextBoxColumn";
            this.orderItemIdDataGridViewTextBoxColumn.Width = 81;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "商品";
            this.productDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.Width = 66;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "单价";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 66;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "数量";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 66;
            // 
            // orderItemSumDataGridViewTextBoxColumn
            // 
            this.orderItemSumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.orderItemSumDataGridViewTextBoxColumn.DataPropertyName = "OrderItemSum";
            this.orderItemSumDataGridViewTextBoxColumn.HeaderText = "总价";
            this.orderItemSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderItemSumDataGridViewTextBoxColumn.Name = "orderItemSumDataGridViewTextBoxColumn";
            this.orderItemSumDataGridViewTextBoxColumn.Width = 66;
            // 
            // bindingSourceOrderItem
            // 
            this.bindingSourceOrderItem.DataSource = typeof(ClassWork3_16.OrderItem);
            // 
            // buttonAddOrderItem
            // 
            this.buttonAddOrderItem.Location = new System.Drawing.Point(46, 255);
            this.buttonAddOrderItem.Name = "buttonAddOrderItem";
            this.buttonAddOrderItem.Size = new System.Drawing.Size(107, 43);
            this.buttonAddOrderItem.TabIndex = 1;
            this.buttonAddOrderItem.Text = "添加";
            this.buttonAddOrderItem.UseVisualStyleBackColor = true;
            this.buttonAddOrderItem.Click += new System.EventHandler(this.buttonAddOrderItem_Click);
            // 
            // groupBoxAddOrderItem
            // 
            this.groupBoxAddOrderItem.Controls.Add(this.textBoxAddOrderItemNumber);
            this.groupBoxAddOrderItem.Controls.Add(this.textBoxAddOrderItemProduct);
            this.groupBoxAddOrderItem.Controls.Add(this.textBoxAddOrderItemId);
            this.groupBoxAddOrderItem.Controls.Add(this.labelAddOrderItemNumber);
            this.groupBoxAddOrderItem.Controls.Add(this.labelAddOrderItemProduct);
            this.groupBoxAddOrderItem.Controls.Add(this.labelAddOrderItemId);
            this.groupBoxAddOrderItem.Location = new System.Drawing.Point(46, 24);
            this.groupBoxAddOrderItem.Name = "groupBoxAddOrderItem";
            this.groupBoxAddOrderItem.Size = new System.Drawing.Size(336, 225);
            this.groupBoxAddOrderItem.TabIndex = 0;
            this.groupBoxAddOrderItem.TabStop = false;
            this.groupBoxAddOrderItem.Text = "订单明细";
            // 
            // textBoxAddOrderItemNumber
            // 
            this.textBoxAddOrderItemNumber.Location = new System.Drawing.Point(147, 153);
            this.textBoxAddOrderItemNumber.Name = "textBoxAddOrderItemNumber";
            this.textBoxAddOrderItemNumber.Size = new System.Drawing.Size(140, 25);
            this.textBoxAddOrderItemNumber.TabIndex = 5;
            // 
            // textBoxAddOrderItemProduct
            // 
            this.textBoxAddOrderItemProduct.Location = new System.Drawing.Point(147, 101);
            this.textBoxAddOrderItemProduct.Name = "textBoxAddOrderItemProduct";
            this.textBoxAddOrderItemProduct.Size = new System.Drawing.Size(140, 25);
            this.textBoxAddOrderItemProduct.TabIndex = 4;
            // 
            // textBoxAddOrderItemId
            // 
            this.textBoxAddOrderItemId.Location = new System.Drawing.Point(147, 54);
            this.textBoxAddOrderItemId.Name = "textBoxAddOrderItemId";
            this.textBoxAddOrderItemId.Size = new System.Drawing.Size(140, 25);
            this.textBoxAddOrderItemId.TabIndex = 3;
            // 
            // labelAddOrderItemNumber
            // 
            this.labelAddOrderItemNumber.AutoSize = true;
            this.labelAddOrderItemNumber.Location = new System.Drawing.Point(51, 153);
            this.labelAddOrderItemNumber.Name = "labelAddOrderItemNumber";
            this.labelAddOrderItemNumber.Size = new System.Drawing.Size(37, 15);
            this.labelAddOrderItemNumber.TabIndex = 2;
            this.labelAddOrderItemNumber.Text = "数量";
            // 
            // labelAddOrderItemProduct
            // 
            this.labelAddOrderItemProduct.AutoSize = true;
            this.labelAddOrderItemProduct.Location = new System.Drawing.Point(48, 104);
            this.labelAddOrderItemProduct.Name = "labelAddOrderItemProduct";
            this.labelAddOrderItemProduct.Size = new System.Drawing.Size(37, 15);
            this.labelAddOrderItemProduct.TabIndex = 1;
            this.labelAddOrderItemProduct.Text = "商品";
            // 
            // labelAddOrderItemId
            // 
            this.labelAddOrderItemId.AutoSize = true;
            this.labelAddOrderItemId.Location = new System.Drawing.Point(48, 57);
            this.labelAddOrderItemId.Name = "labelAddOrderItemId";
            this.labelAddOrderItemId.Size = new System.Drawing.Size(52, 15);
            this.labelAddOrderItemId.TabIndex = 0;
            this.labelAddOrderItemId.Text = "商品号";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxAddOrder.ResumeLayout(false);
            this.groupBoxAddOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceOrderItem)).EndInit();
            this.groupBoxAddOrderItem.ResumeLayout(false);
            this.groupBoxAddOrderItem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxAddOrder;
        private System.Windows.Forms.Label labelAddClientName;
        private System.Windows.Forms.Label labelAddSenderName;
        private System.Windows.Forms.Label labelAddOrderId;
        private System.Windows.Forms.Button buttonAddCancel;
        private System.Windows.Forms.Button buttonAddOk;
        private System.Windows.Forms.TextBox textBoxAddClientName;
        private System.Windows.Forms.TextBox textBoxAddSenderName;
        private System.Windows.Forms.TextBox textBoxAddOrderId;
        private System.Windows.Forms.GroupBox groupBoxAddOrderItem;
        private System.Windows.Forms.Label labelAddOrderItemId;
        private System.Windows.Forms.Label labelAddOrderItemProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSourceOrderItem;
        private System.Windows.Forms.Button buttonAddOrderItem;
        private System.Windows.Forms.TextBox textBoxAddOrderItemNumber;
        private System.Windows.Forms.TextBox textBoxAddOrderItemProduct;
        private System.Windows.Forms.TextBox textBoxAddOrderItemId;
        private System.Windows.Forms.Label labelAddOrderItemNumber;
        private System.Windows.Forms.Label labelOrderSumShow;
        private System.Windows.Forms.Label labelOrderSum;
        private System.Windows.Forms.Button buttonAddOrderItemDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemSumDataGridViewTextBoxColumn;
    }
}