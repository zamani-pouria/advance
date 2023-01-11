using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chapter12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tax=0, insurance=0, endsallary=0,cid,csallary;
            string cfname, clname, message;

            if(id.Text != "" && fname.Text != "" && lname.Text != "" && sallary.Text != "" )
            {
                cid = Convert.ToDouble(id.Text);
                csallary = Convert.ToDouble(sallary.Text);
                cfname = fname.Text;
                clname = lname.Text;
                if(csallary>6500)
                {
                    tax = (csallary * 10) / 100;
                }
                insurance = (csallary * 7) / 100;
                endsallary = csallary - (tax + insurance);
                message= ("hi dear "+ cfname+" "+ clname+" with id "+ cid+". your sallary without insurance and tax is: "+ endsallary);
                MessageBox.Show(message);

            }
        }
    }
}
