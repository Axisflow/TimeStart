using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeStar;

namespace TimeStart
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void About_Click(object sender, EventArgs e)
        {
            Form5 TSA = new Form5();
            TSA.ShowDialog();
        }
    }
}
