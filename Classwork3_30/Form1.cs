using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork3_30
{
    public partial class Form1 : Form
    {
        private ColorDialog colorDialog = new ColorDialog();
        private Graphics graphics;
        double th1 = 20 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Color color = Color.FromArgb(255, 0, 0);
        int deepth = 10;
        double length = 100;
        public Form1()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Size = new Size(this.Size.Width - 250, this.Size.Height - 69);
            graphics = this.panel1.CreateGraphics();
            this.graphics.Clear(Color.FromArgb(255, 255, 255));
            drawCayleyTree(deepth,panel1.Size.Width/2, panel1.Size.Height, length, -Math.PI / 2);
            
        }

        void drawLine(double x0, double y0, double x1, double y1) 
        {
            graphics.DrawLine(new Pen(color), (int)x0, (int)y0, (int)x1, (int)y1);
        }
        void drawCayleyTree(int n, double x0, double y0, double leng, double th) 
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0,y0,x1,y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            this.textBoxShowColor.BackColor = this.colorDialog.Color;
            this.color = this.colorDialog.Color;
        }

        private void textBoxMainLength_TextChanged(object sender, EventArgs e)
        {
           double.TryParse(textBoxMainLength.Text, out this.length);
        }

        private void comboBoxLeftRate_TextChanged(object sender, EventArgs e)
        {
            double. TryParse(comboBoxLeftRate.Text, out this.per1);
        }

        private void comboBoxRight_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(comboBoxRight.Text, out this.per2);
        }

        private void hScrollBarLeft_Scroll(object sender, ScrollEventArgs e)
        {
            this.labelLeftAngal.Text  = hScrollBarLeft.Value.ToString();
            this.th1 = hScrollBarLeft.Value * Math.PI / 180;
        }

        private void hScrollBarRight_Scroll(object sender, ScrollEventArgs e)
        {
            this.labelRightAngal.Text = hScrollBarRight.Value.ToString();
            this.th1 = hScrollBarRight.Value * Math.PI / 180;
        }

        private void textBoxDeepth_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(textBoxDeepth.Text, out this.deepth);
        }

    }
}
