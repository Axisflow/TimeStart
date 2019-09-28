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
    public partial class Form6 : Form
    {
        int day = 0, hour = 0, min = 0, sec = 0,run = 0;

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "已暫停";

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void ToolTipLableTextClean()
        {
            toolStripStatusLabel1.Text = "";
        }

        private void LableTo00()
        {
            label3.Text = "00";
            label5.Text = "00";
            label7.Text = "00";
            label9.Text = "00";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "開始計時";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "暫停";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "停止";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "設置";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "就緒";
            timer1.Enabled = false;
            LableTo00();

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private Point startPoint;

        private void Form6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                //新視窗的位置
                mousePos.Offset(startPoint.X, startPoint.Y);
                //改變視窗位置
                Location = mousePos;
            }
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        public Form6(int d,int h, int m, int s)
        {
            InitializeComponent();
            day = d;
            hour = h;
            min = m;
            sec = s;
            label9.Text = d.ToString();
            label7.Text = h.ToString();
            label5.Text = m.ToString();
            label3.Text = s.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "計時中...";
            run++;
            label9.Text = day.ToString();
            label7.Text = hour.ToString();
            label5.Text = min.ToString();
            label3.Text = sec.ToString();
            if (run == 9)
            {
                run = 0;
                if (sec > 0)
                {
                    sec--;
                }
                else
                {
                    if (min > 0)
                    {
                        min--;
                        sec = 59;
                    }
                    else
                    {
                        if (hour > 0)
                        {
                            hour--;
                            min = 59;
                        }
                        else
                        {
                            if (day > 0)
                            {
                                day--;
                                hour = 23;
                            }
                            else
                            {
                                label1.Text = "就緒";
                                LableTo00();
                                timer1.Enabled = false;

                                button1.Enabled = true;
                                button2.Enabled = false;
                                button3.Enabled = false;
                            }
                        }
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 sacdt = new Form7(day, hour, min, sec);
            sacdt.Show();
            Close();
        }
    }
}
