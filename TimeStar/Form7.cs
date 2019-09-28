using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeStar
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        public Form7(int d,int h,int m,int s)
        {
            InitializeComponent();
            numericUpDown1.Value = Convert.ToDecimal(d);
            numericUpDown2.Value = Convert.ToDecimal(h);
            numericUpDown3.Value = Convert.ToDecimal(m);
            numericUpDown4.Value = Convert.ToDecimal(s);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 cdt = new Form6(Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), Convert.ToInt32(numericUpDown4.Value));
            cdt.Show();
            Close();
        }
    }
}
