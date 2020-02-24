using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHelloworld
{
    public partial class Form1 : Form
    {
        double? result;//声明结果
        char s;
        double? finum = 0, senum = 0;//两个操作数
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void sign_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                finum = double.Parse(fnum.Text);
                senum = double.Parse(snum.Text);
                s = comboBox1.SelectedItem.ToString().ToCharArray()[0];
                switch (s)
                {
                    case '+':
                        result = finum + senum;
                        break;
                    case '-':
                        result = finum - senum;
                        break;
                    case '*':
                        result = finum * senum;
                        break;
                    case '/':
                        result = finum / senum;
                        break;
                }
                label2.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
                label2.Text = "除数不能为零！！！";
            }
            catch (OverflowException) 
            {
                label2.Text = "数值过大！！！";
            }
            catch (Exception)
            {
                label2.Text = "输入为空或非法输入！！！";
            }
        }
    }
}
