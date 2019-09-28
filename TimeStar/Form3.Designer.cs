namespace TimeStar
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.StartTimer = new System.Windows.Forms.Timer(this.components);
            this.TimeStart = new System.Windows.Forms.Label();
            this.Sec = new System.Windows.Forms.Label();
            this.Min = new System.Windows.Forms.Label();
            this.Hr = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Time_Start = new System.Windows.Forms.Label();
            this.Day = new System.Windows.Forms.Label();
            this.Sea = new System.Windows.Forms.Label();
            this.We = new System.Windows.Forms.Label();
            this.Mon = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.Cent = new System.Windows.Forms.Label();
            this.Closer = new System.Windows.Forms.Label();
            this.TimeNow = new System.Windows.Forms.Label();
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.Msg = new System.Windows.Forms.Label();
            this.Stop_Timer = new System.Windows.Forms.Timer(this.components);
            this.Play_Timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolTipLable = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartTimer
            // 
            this.StartTimer.Interval = 1000;
            this.StartTimer.Tick += new System.EventHandler(this.StraTimer_Tick);
            // 
            // TimeStart
            // 
            this.TimeStart.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.TimeStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeStart.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeStart.Location = new System.Drawing.Point(0, 94);
            this.TimeStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(740, 38);
            this.TimeStart.TabIndex = 0;
            this.TimeStart.Text = "     季     月/     週     日．     時:     分:     秒";
            this.TimeStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sec
            // 
            this.Sec.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sec.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sec.ForeColor = System.Drawing.Color.Red;
            this.Sec.Location = new System.Drawing.Point(593, 100);
            this.Sec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sec.Name = "Sec";
            this.Sec.Size = new System.Drawing.Size(44, 31);
            this.Sec.TabIndex = 2;
            this.Sec.Text = "00";
            this.Sec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Min
            // 
            this.Min.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Min.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Min.ForeColor = System.Drawing.Color.Lime;
            this.Min.Location = new System.Drawing.Point(506, 100);
            this.Min.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(44, 31);
            this.Min.TabIndex = 3;
            this.Min.Text = "00";
            this.Min.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Hr
            // 
            this.Hr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Hr.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Hr.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Hr.Location = new System.Drawing.Point(415, 100);
            this.Hr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hr.Name = "Hr";
            this.Hr.Size = new System.Drawing.Size(44, 31);
            this.Hr.TabIndex = 4;
            this.Hr.Text = "00";
            this.Hr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 44);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(60, 6);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 44);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(113, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 44);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseEnter += new System.EventHandler(this.button3_MouseEnter);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            // 
            // Time_Start
            // 
            this.Time_Start.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Time_Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Time_Start.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time_Start.Location = new System.Drawing.Point(0, 56);
            this.Time_Start.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Time_Start.Name = "Time_Start";
            this.Time_Start.Size = new System.Drawing.Size(740, 38);
            this.Time_Start.TabIndex = 8;
            this.Time_Start.Text = "     世紀     年/";
            this.Time_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Day.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Day.ForeColor = System.Drawing.Color.Yellow;
            this.Day.Location = new System.Drawing.Point(311, 100);
            this.Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(48, 31);
            this.Day.TabIndex = 9;
            this.Day.Text = "00";
            this.Day.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sea
            // 
            this.Sea.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Sea.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Sea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Sea.Location = new System.Drawing.Point(90, 100);
            this.Sea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Sea.Name = "Sea";
            this.Sea.Size = new System.Drawing.Size(17, 31);
            this.Sea.TabIndex = 10;
            this.Sea.Text = "0";
            this.Sea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // We
            // 
            this.We.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.We.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.We.ForeColor = System.Drawing.Color.Fuchsia;
            this.We.Location = new System.Drawing.Point(249, 100);
            this.We.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.We.Name = "We";
            this.We.Size = new System.Drawing.Size(17, 31);
            this.We.TabIndex = 11;
            this.We.Text = "0";
            this.We.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Mon
            // 
            this.Mon.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Mon.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Mon.ForeColor = System.Drawing.Color.Firebrick;
            this.Mon.Location = new System.Drawing.Point(148, 100);
            this.Mon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mon.Name = "Mon";
            this.Mon.Size = new System.Drawing.Size(48, 31);
            this.Mon.TabIndex = 12;
            this.Mon.Text = "00";
            this.Mon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Year
            // 
            this.Year.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Year.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Year.ForeColor = System.Drawing.Color.Green;
            this.Year.Location = new System.Drawing.Point(380, 62);
            this.Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(48, 31);
            this.Year.TabIndex = 13;
            this.Year.Text = "00";
            this.Year.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cent
            // 
            this.Cent.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Cent.Font = new System.Drawing.Font("新細明體", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Cent.ForeColor = System.Drawing.Color.SlateBlue;
            this.Cent.Location = new System.Drawing.Point(266, 62);
            this.Cent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cent.Name = "Cent";
            this.Cent.Size = new System.Drawing.Size(48, 31);
            this.Cent.TabIndex = 14;
            this.Cent.Text = "00";
            this.Cent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Closer.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Closer.Location = new System.Drawing.Point(724, 0);
            this.Closer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(16, 15);
            this.Closer.TabIndex = 15;
            this.Closer.Text = "X";
            this.Closer.Click += new System.EventHandler(this.Closer_Click);
            this.Closer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Closer_MouseDown);
            this.Closer.MouseEnter += new System.EventHandler(this.Closer_MouseEnter);
            this.Closer.MouseLeave += new System.EventHandler(this.Closer_MouseLeave);
            this.Closer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Closer_MouseUp);
            // 
            // TimeNow
            // 
            this.TimeNow.BackColor = System.Drawing.Color.White;
            this.TimeNow.Font = new System.Drawing.Font("新細明體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeNow.ForeColor = System.Drawing.Color.Blue;
            this.TimeNow.Location = new System.Drawing.Point(168, 21);
            this.TimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(572, 29);
            this.TimeNow.TabIndex = 16;
            this.TimeNow.Text = "TimeNow";
            this.TimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NowTimer
            // 
            this.NowTimer.Enabled = true;
            this.NowTimer.Interval = 1000;
            this.NowTimer.Tick += new System.EventHandler(this.NowTimer_Tick);
            // 
            // Msg
            // 
            this.Msg.BackColor = System.Drawing.SystemColors.Control;
            this.Msg.Font = new System.Drawing.Font("新細明體", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Msg.Location = new System.Drawing.Point(584, 135);
            this.Msg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(133, 21);
            this.Msg.TabIndex = 17;
            this.Msg.Text = "就緒";
            this.Msg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Stop_Timer
            // 
            this.Stop_Timer.Tick += new System.EventHandler(this.Stop_Timer_Tick);
            // 
            // Play_Timer
            // 
            this.Play_Timer.Tick += new System.EventHandler(this.Play_Timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolTipLable});
            this.statusStrip1.Location = new System.Drawing.Point(0, 132);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(740, 24);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolTipLable
            // 
            this.ToolTipLable.AutoSize = false;
            this.ToolTipLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolTipLable.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8F);
            this.ToolTipLable.Name = "ToolTipLable";
            this.ToolTipLable.Size = new System.Drawing.Size(50, 19);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(740, 156);
            this.Controls.Add(this.Msg);
            this.Controls.Add(this.TimeNow);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.Cent);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Mon);
            this.Controls.Add(this.We);
            this.Controls.Add(this.Sea);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Time_Start);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Hr);
            this.Controls.Add(this.Min);
            this.Controls.Add(this.Sec);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Opacity = 0.9D;
            this.Text = "計時器";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer StartTimer;
        private System.Windows.Forms.Label TimeStart;
        private System.Windows.Forms.Label Sec;
        private System.Windows.Forms.Label Min;
        private System.Windows.Forms.Label Hr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Time_Start;
        private System.Windows.Forms.Label Day;
        private System.Windows.Forms.Label Sea;
        private System.Windows.Forms.Label We;
        private System.Windows.Forms.Label Mon;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label Cent;
        private System.Windows.Forms.Label Closer;
        private System.Windows.Forms.Label TimeNow;
        private System.Windows.Forms.Timer NowTimer;
        private System.Windows.Forms.Label Msg;
        private System.Windows.Forms.Timer Stop_Timer;
        private System.Windows.Forms.Timer Play_Timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolTipLable;
    }
}