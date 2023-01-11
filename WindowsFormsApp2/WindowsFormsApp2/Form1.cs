using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
            if (xx1.Text != "" && xx2.Text != "" && yy1.Text != "" && yy2.Text != "")
            {
                x1 = Convert.ToDouble(xx1.Text);
                x2 = Convert.ToDouble(xx2.Text);
                y1 = Convert.ToDouble(yy1.Text);
                y2 = Convert.ToDouble(yy2.Text);
                MessageBox.Show(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)).ToString());
            }
            else
                MessageBox.Show("data is not valid");
        }
    }
}
