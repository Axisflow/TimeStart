using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TimeStar
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int s = 0, m = 0, h = 0, d = 0, w = 0, o = 0, a = 0, y = 0, c = 0;

        private void Closer_MouseDown(object sender, MouseEventArgs e)
        {
            Closer.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void Closer_MouseEnter(object sender, EventArgs e)
        {
            Closer.BackColor = Color.Silver;
        }

        private void Closer_MouseLeave(object sender, EventArgs e)
        {
            Closer.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void Closer_MouseUp(object sender, MouseEventArgs e)
        {
            Closer.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void Closer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NowTimer_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void CrazyShake()
        {
            // 設定震動範圍
            Int32 offset = 25;
            // 先記錄目前的位置
            Point ori = this.Location;
            // 取得亂數表
            Random r = new Random(DateTime.Now.Millisecond);
            // 隨機變換目前視窗位置 (以原始座標為原點)
            for (int i = 0; i < 30; i++)
            {
                Point tmp = new Point(ori.X + r.Next(-offset, offset), ori.Y + r.Next(-offset, offset));
                this.Location = tmp;
                Thread.Sleep(25);
            }
            // 震動效果結束 還原座標位置
            this.Location = ori;
        }
        int p = 0,t = 0;
        private void Play_Timer_Tick(object sender, EventArgs e)
        {
            p++;

            if (p == 1)
            {
                Msg.Text = "預備中...";
            }
            if (p == 2)
            {
                CrazyShake();
            }
            if (p == 3)
            {
                Msg.Text = "計時中...";
                StartTimer.Enabled = true;
            }
            if (p == 4)
            {
                p = 0;
                NowTimer.Enabled = false;
                Play_Timer.Enabled = false;
            }
        }

        private void ToolTipLableTextClean()
        {
            ToolTipLable.Text = "";
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ToolTipLable.Text = "開始計時";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ToolTipLable.Text = "暫停";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            ToolTipLable.Text = "停止";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            ToolTipLableTextClean();
        }

        private void Stop_Timer_Tick(object sender, EventArgs e)
        {
            t++;

            if (t == 1)
            {
                Msg.Text = "停止中...";
                StartTimer.Enabled = false;
            }
            if (t == 2)
            {
                CrazyShake();
            }
            if (t == 3)
            {
                Msg.Text = "就緒";
            }
            if (t == 4)
            {
                t = 0;
                Stop_Timer.Enabled = false;
            }
        }

        int da = 0, mo = 1, ye = 1;
        private Point startPoint;

        private void button1_Click(object sender, EventArgs e)
        {
            Play_Timer.Enabled = true;

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            StartTimer.Enabled = false;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = true;

            Msg.Text = "暫停中...";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NowTimer.Enabled = true;
            Stop_Timer.Enabled = true;

            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;

            s = 0;
            m = 0;
            h = 0;
            d = 0;
            w = 0;
            o = 0;
            a = 0;
            y = 0;
            c = 0;

            da = 0;
            mo = 1;
            ye = 1;

            Sec.Text = "00";
            Min.Text = "00";
            Hr.Text = "00";
            Day.Text = "00";
            We.Text = "00";
            Mon.Text = "00";
            Sea.Text = "00";
            Year.Text = "00";
            Cent.Text = "00";
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            //當滑鼠擊點到Form1控制項的範圍內時，紀錄目前是窗的位置
            startPoint = new Point(-e.X + SystemInformation.FrameBorderSize.Width, -e.Y - SystemInformation.FrameBorderSize.Height);
        }

        private void StraTimer_Tick(object sender, EventArgs e)
        {
            s++;
            Sec.Text = s.ToString();
            Min.Text = m.ToString();
            Hr.Text = h.ToString();
            Day.Text = d.ToString();
            We.Text = w.ToString();
            Mon.Text = o.ToString();
            Sea.Text = a.ToString();
            Year.Text = y.ToString();
            Cent.Text = c.ToString();
            
            if(s == 60)
            {
                s = 0;
                m++;
            }
            if(m == 60)
            {
                m = 0;
                h++;
            }
            if(h == 24)
            {
                h = 0;
                d++;
                da++;
            }
            if(d == 7)
            {
                d = 0;
                w++;
            }
            if (mo == 1 || mo == 3 || mo == 5 || mo == 7 || mo == 8 || mo == 10 || mo == 12)
            {
                if (da == 31)
                {
                    da = 0;
                    w = 0;
                    d = 0;
                    o++;
                    mo++;
                }
            }
            if (mo == 2)
            {
                if (ye == 4)
                {
                    ye = 1;
                    if (da == 29)
                    {
                        da = 0;
                        w = 0;
                        d = 0;
                        o++;
                        mo++;
                    }
                }
                else
                {
                    if (da == 28)
                    {
                        da = 0;
                        w = 0;
                        d = 0;
                        o++;
                        mo++;
                    }
                }
            }
            if (mo == 4 || mo == 6 || mo == 9 || mo == 11)
            {
                if(da == 30)
                {
                    da = 0;
                    w = 0;
                    d = 0;
                    o++;
                    mo++;
                }
            }
            if (mo == 13)
            {
                da = 0;
                w = 0;
                d = 0;
                o++;
                y++;
                mo = 1;
            }
            if (o == 3)
            {
                o = 0;
                a++;
            }
            if (a == 4)
            {
                a = 0;
                y++;
                ye++;
            }
            if (y == 100)
            {
                y = 0;
                c++;
            }
        }
    }
}
