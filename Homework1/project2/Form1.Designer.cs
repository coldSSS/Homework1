namespace WindowsFormsHelloworld
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.fnum = new System.Windows.Forms.TextBox();
            this.snum = new System.Windows.Forms.TextBox();
            this.labelFnum = new System.Windows.Forms.Label();
            this.labelSnum = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelR = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(347, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fnum
            // 
            this.fnum.Location = new System.Drawing.Point(134, 174);
            this.fnum.Name = "fnum";
            this.fnum.Size = new System.Drawing.Size(100, 25);
            this.fnum.TabIndex = 2;
            // 
            // snum
            // 
            this.snum.Location = new System.Drawing.Point(398, 174);
            this.snum.Name = "snum";
            this.snum.Size = new System.Drawing.Size(100, 25);
            this.snum.TabIndex = 3;
            // 
            // labelFnum
            // 
            this.labelFnum.AutoSize = true;
            this.labelFnum.Location = new System.Drawing.Point(46, 177);
            this.labelFnum.Name = "labelFnum";
            this.labelFnum.Size = new System.Drawing.Size(82, 15);
            this.labelFnum.TabIndex = 4;
            this.labelFnum.Text = "第一个数：";
            // 
            // labelSnum
            // 
            this.labelSnum.AutoSize = true;
            this.labelSnum.Location = new System.Drawing.Point(310, 177);
            this.labelSnum.Name = "labelSnum";
            this.labelSnum.Size = new System.Drawing.Size(82, 15);
            this.labelSnum.TabIndex = 5;
            this.labelSnum.Text = "第二个数：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox1.Location = new System.Drawing.Point(610, 176);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(537, 179);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(67, 15);
            this.label.TabIndex = 7;
            this.label.Text = "操作符：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "计算";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Location = new System.Drawing.Point(182, 332);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(52, 15);
            this.labelR.TabIndex = 9;
            this.labelR.Text = "结果：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelSnum);
            this.Controls.Add(this.labelFnum);
            this.Controls.Add(this.snum);
            this.Controls.Add(this.fnum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fnum;
        private System.Windows.Forms.TextBox snum;
        private System.Windows.Forms.Label labelFnum;
        private System.Windows.Forms.Label labelSnum;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label label2;
    }
}

