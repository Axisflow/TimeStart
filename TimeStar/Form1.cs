using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeStart;

namespace TimeStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int t = 0;
        private Point startPoint;
        private void Form2Timer_Tick(object sender, EventArgs e)
        {
            t++;
            if(t == 1)
            {
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
            }

            if(t == 2)
            {
                Form2Timer.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 TSD = new Form2();
            TSD.ShowDialog();
        }

        private void 計時器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 TSM = new Form3();
            TSM.Show(this);
        }
        
        private void NowTimer_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = "現在時間 · " + DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            Closer.BackColor = Color.Silver;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Closer.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            Closer.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            Closer.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            Minimized.BackColor = Color.Silver;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            Minimized.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            Minimized.BackColor = Color.RoyalBlue;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            Minimized.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Move_MouseDown(object sender, MouseEventArgs e)
        {
            Mover.BackColor = Color.Yellow;
            //當滑鼠擊點到Form1控制項的範圍內時，紀錄目前是窗的位置
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void Move_MouseMove(object sender, MouseEventArgs e)
        {
            //如果使用者使用的是左鍵按下，意旨使用右鍵拖曳無效
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                //新視窗的位置
                mousePos.Offset(startPoint.X, startPoint.Y);
                //改變視窗位置
                Location = mousePos;
            }
        }

        private void Move_MouseEnter(object sender, EventArgs e)
        {
            Mover.BackColor = Color.Silver;
        }

        private void Move_MouseLeave(object sender, EventArgs e)
        {
            Mover.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Move_MouseUp(object sender, MouseEventArgs e)
        {
            Mover.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Helper_Click(object sender, EventArgs e)
        {
            Form4 TSH = new Form4();
            TSH.ShowDialog();
        }

        private void Helper_MouseDown(object sender, MouseEventArgs e)
        {
            Helper.BackColor = Color.Green;
        }

        private void Helper_MouseEnter(object sender, EventArgs e)
        {
            Helper.BackColor = Color.Silver;
        }

        private void Helper_MouseLeave(object sender, EventArgs e)
        {
            Helper.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Helper_MouseUp(object sender, MouseEventArgs e)
        {
            Helper.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Abouter_MouseDown(object sender, MouseEventArgs e)
        {
            Abouter.BackColor = Color.Purple;
        }

        private void Abouter_MouseEnter(object sender, EventArgs e)
        {
            Abouter.BackColor = Color.Silver;
        }

        private void Abouter_MouseLeave(object sender, EventArgs e)
        {
            Abouter.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Abouter_MouseUp(object sender, MouseEventArgs e)
        {
            Abouter.BackColor = Color.FromArgb(192, 255, 255);
        }

        private void Abouter_Click(object sender, EventArgs e)
        {
            Form5 TSA = new Form5();
            TSA.ShowDialog();
        }

        private void 關閉ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 倒數計時器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 cdt = new Form6();
            cdt.Show();
        }
    }
}
