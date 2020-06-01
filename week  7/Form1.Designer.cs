namespace Classwork3_30
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMainLength = new System.Windows.Forms.TextBox();
            this.groupBoxLength = new System.Windows.Forms.GroupBox();
            this.comboBoxRight = new System.Windows.Forms.ComboBox();
            this.comboBoxLeftRate = new System.Windows.Forms.ComboBox();
            this.labelRightRate = new System.Windows.Forms.Label();
            this.labelLeftRate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAngal = new System.Windows.Forms.GroupBox();
            this.hScrollBarRight = new System.Windows.Forms.HScrollBar();
            this.hScrollBarLeft = new System.Windows.Forms.HScrollBar();
            this.labelRight = new System.Windows.Forms.Label();
            this.labelLeft = new System.Windows.Forms.Label();
            this.groupBoxDeepth = new System.Windows.Forms.GroupBox();
            this.textBoxDeepth = new System.Windows.Forms.TextBox();
            this.labelDeepth = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.labelLeftAngal = new System.Windows.Forms.Label();
            this.labelRightAngal = new System.Windows.Forms.Label();
            this.textBoxShowColor = new System.Windows.Forms.TextBox();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.groupBoxLength.SuspendLayout();
            this.groupBoxAngal.SuspendLayout();
            this.groupBoxDeepth.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(84, 396);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 32);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "绘制";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(276, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 416);
            this.panel1.TabIndex = 1;
            // 
            // textBoxMainLength
            // 
            this.textBoxMainLength.Location = new System.Drawing.Point(116, 27);
            this.textBoxMainLength.Name = "textBoxMainLength";
            this.textBoxMainLength.Size = new System.Drawing.Size(126, 25);
            this.textBoxMainLength.TabIndex = 2;
            this.textBoxMainLength.Text = "100";
            this.textBoxMainLength.TextChanged += new System.EventHandler(this.textBoxMainLength_TextChanged);
            // 
            // groupBoxLength
            // 
            this.groupBoxLength.Controls.Add(this.comboBoxRight);
            this.groupBoxLength.Controls.Add(this.comboBoxLeftRate);
            this.groupBoxLength.Controls.Add(this.labelRightRate);
            this.groupBoxLength.Controls.Add(this.labelLeftRate);
            this.groupBoxLength.Controls.Add(this.label1);
            this.groupBoxLength.Controls.Add(this.textBoxMainLength);
            this.groupBoxLength.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLength.Name = "groupBoxLength";
            this.groupBoxLength.Size = new System.Drawing.Size(248, 125);
            this.groupBoxLength.TabIndex = 3;
            this.groupBoxLength.TabStop = false;
            this.groupBoxLength.Text = "长度";
            // 
            // comboBoxRight
            // 
            this.comboBoxRight.FormattingEnabled = true;
            this.comboBoxRight.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9"});
            this.comboBoxRight.Location = new System.Drawing.Point(116, 92);
            this.comboBoxRight.Name = "comboBoxRight";
            this.comboBoxRight.Size = new System.Drawing.Size(126, 23);
            this.comboBoxRight.TabIndex = 9;
            this.comboBoxRight.Text = "0.7";
            this.comboBoxRight.TextChanged += new System.EventHandler(this.comboBoxRight_TextChanged);
            // 
            // comboBoxLeftRate
            // 
            this.comboBoxLeftRate.FormattingEnabled = true;
            this.comboBoxLeftRate.Items.AddRange(new object[] {
            "0.1",
            "0.2",
            "0.3",
            "0.4",
            "0.5",
            "0.6",
            "0.7",
            "0.8",
            "0.9"});
            this.comboBoxLeftRate.Location = new System.Drawing.Point(116, 58);
            this.comboBoxLeftRate.Name = "comboBoxLeftRate";
            this.comboBoxLeftRate.Size = new System.Drawing.Size(126, 23);
            this.comboBoxLeftRate.TabIndex = 8;
            this.comboBoxLeftRate.Text = "0.6";
            this.comboBoxLeftRate.TextChanged += new System.EventHandler(this.comboBoxLeftRate_TextChanged);
            // 
            // labelRightRate
            // 
            this.labelRightRate.AutoSize = true;
            this.labelRightRate.Location = new System.Drawing.Point(15, 92);
            this.labelRightRate.Name = "labelRightRate";
            this.labelRightRate.Size = new System.Drawing.Size(97, 15);
            this.labelRightRate.TabIndex = 5;
            this.labelRightRate.Text = "右分支长度比";
            // 
            // labelLeftRate
            // 
            this.labelLeftRate.AutoSize = true;
            this.labelLeftRate.Location = new System.Drawing.Point(15, 61);
            this.labelLeftRate.Name = "labelLeftRate";
            this.labelLeftRate.Size = new System.Drawing.Size(97, 15);
            this.labelLeftRate.TabIndex = 4;
            this.labelLeftRate.Text = "左分支长度比";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "主干高度";
            // 
            // groupBoxAngal
            // 
            this.groupBoxAngal.Controls.Add(this.labelRightAngal);
            this.groupBoxAngal.Controls.Add(this.labelLeftAngal);
            this.groupBoxAngal.Controls.Add(this.hScrollBarRight);
            this.groupBoxAngal.Controls.Add(this.hScrollBarLeft);
            this.groupBoxAngal.Controls.Add(this.labelRight);
            this.groupBoxAngal.Controls.Add(this.labelLeft);
            this.groupBoxAngal.Location = new System.Drawing.Point(12, 143);
            this.groupBoxAngal.Name = "groupBoxAngal";
            this.groupBoxAngal.Size = new System.Drawing.Size(248, 100);
            this.groupBoxAngal.TabIndex = 4;
            this.groupBoxAngal.TabStop = false;
            this.groupBoxAngal.Text = "角度";
            // 
            // hScrollBarRight
            // 
            this.hScrollBarRight.LargeChange = 1;
            this.hScrollBarRight.Location = new System.Drawing.Point(57, 58);
            this.hScrollBarRight.Maximum = 90;
            this.hScrollBarRight.Name = "hScrollBarRight";
            this.hScrollBarRight.Size = new System.Drawing.Size(159, 21);
            this.hScrollBarRight.TabIndex = 3;
            this.hScrollBarRight.Value = 20;
            this.hScrollBarRight.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarRight_Scroll);
            // 
            // hScrollBarLeft
            // 
            this.hScrollBarLeft.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.hScrollBarLeft.LargeChange = 1;
            this.hScrollBarLeft.Location = new System.Drawing.Point(57, 21);
            this.hScrollBarLeft.Maximum = 90;
            this.hScrollBarLeft.Name = "hScrollBarLeft";
            this.hScrollBarLeft.Size = new System.Drawing.Size(159, 21);
            this.hScrollBarLeft.TabIndex = 2;
            this.hScrollBarLeft.Value = 20;
            this.hScrollBarLeft.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarLeft_Scroll);
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Location = new System.Drawing.Point(7, 58);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(52, 15);
            this.labelRight.TabIndex = 1;
            this.labelRight.Text = "右分支";
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Location = new System.Drawing.Point(7, 27);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(52, 15);
            this.labelLeft.TabIndex = 0;
            this.labelLeft.Text = "左分支";
            // 
            // groupBoxDeepth
            // 
            this.groupBoxDeepth.Controls.Add(this.textBoxDeepth);
            this.groupBoxDeepth.Controls.Add(this.labelDeepth);
            this.groupBoxDeepth.Location = new System.Drawing.Point(12, 260);
            this.groupBoxDeepth.Name = "groupBoxDeepth";
            this.groupBoxDeepth.Size = new System.Drawing.Size(248, 44);
            this.groupBoxDeepth.TabIndex = 5;
            this.groupBoxDeepth.TabStop = false;
            // 
            // textBoxDeepth
            // 
            this.textBoxDeepth.Location = new System.Drawing.Point(116, 13);
            this.textBoxDeepth.Name = "textBoxDeepth";
            this.textBoxDeepth.Size = new System.Drawing.Size(100, 25);
            this.textBoxDeepth.TabIndex = 1;
            this.textBoxDeepth.Text = "10";
            this.textBoxDeepth.TextChanged += new System.EventHandler(this.textBoxDeepth_TextChanged);
            // 
            // labelDeepth
            // 
            this.labelDeepth.AutoSize = true;
            this.labelDeepth.Location = new System.Drawing.Point(37, 21);
            this.labelDeepth.Name = "labelDeepth";
            this.labelDeepth.Size = new System.Drawing.Size(67, 15);
            this.labelDeepth.TabIndex = 0;
            this.labelDeepth.Text = "分支次数";
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(18, 17);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(92, 34);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.Text = "选择颜色";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // labelLeftAngal
            // 
            this.labelLeftAngal.AutoSize = true;
            this.labelLeftAngal.Location = new System.Drawing.Point(219, 21);
            this.labelLeftAngal.Name = "labelLeftAngal";
            this.labelLeftAngal.Size = new System.Drawing.Size(23, 15);
            this.labelLeftAngal.TabIndex = 4;
            this.labelLeftAngal.Text = "20";
            // 
            // labelRightAngal
            // 
            this.labelRightAngal.AutoSize = true;
            this.labelRightAngal.Location = new System.Drawing.Point(219, 58);
            this.labelRightAngal.Name = "labelRightAngal";
            this.labelRightAngal.Size = new System.Drawing.Size(23, 15);
            this.labelRightAngal.TabIndex = 5;
            this.labelRightAngal.Text = "20";
            // 
            // textBoxShowColor
            // 
            this.textBoxShowColor.BackColor = System.Drawing.Color.Red;
            this.textBoxShowColor.Location = new System.Drawing.Point(142, 24);
            this.textBoxShowColor.Name = "textBoxShowColor";
            this.textBoxShowColor.ReadOnly = true;
            this.textBoxShowColor.Size = new System.Drawing.Size(100, 25);
            this.textBoxShowColor.TabIndex = 7;
            this.textBoxShowColor.Text = "当前颜色";
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.buttonColor);
            this.groupBoxColor.Controls.Add(this.textBoxShowColor);
            this.groupBoxColor.Location = new System.Drawing.Point(6, 310);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(248, 62);
            this.groupBoxColor.TabIndex = 8;
            this.groupBoxColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.groupBoxDeepth);
            this.Controls.Add(this.groupBoxAngal);
            this.Controls.Add(this.groupBoxLength);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonDraw);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxLength.ResumeLayout(false);
            this.groupBoxLength.PerformLayout();
            this.groupBoxAngal.ResumeLayout(false);
            this.groupBoxAngal.PerformLayout();
            this.groupBoxDeepth.ResumeLayout(false);
            this.groupBoxDeepth.PerformLayout();
            this.groupBoxColor.ResumeLayout(false);
            this.groupBoxColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMainLength;
        private System.Windows.Forms.GroupBox groupBoxLength;
        private System.Windows.Forms.Label labelRightRate;
        private System.Windows.Forms.Label labelLeftRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAngal;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.GroupBox groupBoxDeepth;
        private System.Windows.Forms.TextBox textBoxDeepth;
        private System.Windows.Forms.Label labelDeepth;
        private System.Windows.Forms.ComboBox comboBoxRight;
        private System.Windows.Forms.ComboBox comboBoxLeftRate;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.HScrollBar hScrollBarRight;
        private System.Windows.Forms.HScrollBar hScrollBarLeft;
        private System.Windows.Forms.Label labelLeftAngal;
        private System.Windows.Forms.Label labelRightAngal;
        private System.Windows.Forms.TextBox textBoxShowColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
    }
}

