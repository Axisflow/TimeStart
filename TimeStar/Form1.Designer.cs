namespace TimeStar
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.計時器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.倒數計時器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.關閉ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Form2Timer = new System.Windows.Forms.Timer(this.components);
            this.TimeNow = new System.Windows.Forms.Label();
            this.NowTimer = new System.Windows.Forms.Timer(this.components);
            this.Closer = new System.Windows.Forms.Label();
            this.Minimized = new System.Windows.Forms.Label();
            this.Mover = new System.Windows.Forms.Label();
            this.Helper = new System.Windows.Forms.Label();
            this.Abouter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(58, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.關閉ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(48, 22);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.計時器ToolStripMenuItem,
            this.倒數計時器ToolStripMenuItem});
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 計時器ToolStripMenuItem
            // 
            this.計時器ToolStripMenuItem.Name = "計時器ToolStripMenuItem";
            this.計時器ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.計時器ToolStripMenuItem.Text = "計時器";
            this.計時器ToolStripMenuItem.Click += new System.EventHandler(this.計時器ToolStripMenuItem_Click);
            // 
            // 倒數計時器ToolStripMenuItem
            // 
            this.倒數計時器ToolStripMenuItem.Name = "倒數計時器ToolStripMenuItem";
            this.倒數計時器ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.倒數計時器ToolStripMenuItem.Text = "倒數計時器";
            this.倒數計時器ToolStripMenuItem.Click += new System.EventHandler(this.倒數計時器ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // 關閉ToolStripMenuItem
            // 
            this.關閉ToolStripMenuItem.Name = "關閉ToolStripMenuItem";
            this.關閉ToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.關閉ToolStripMenuItem.Text = "關閉";
            this.關閉ToolStripMenuItem.Click += new System.EventHandler(this.關閉ToolStripMenuItem_Click);
            // 
            // Form2Timer
            // 
            this.Form2Timer.Enabled = true;
            this.Form2Timer.Interval = 2000;
            this.Form2Timer.Tick += new System.EventHandler(this.Form2Timer_Tick);
            // 
            // TimeNow
            // 
            this.TimeNow.BackColor = System.Drawing.Color.Black;
            this.TimeNow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TimeNow.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.TimeNow.ForeColor = System.Drawing.Color.Yellow;
            this.TimeNow.Location = new System.Drawing.Point(0, 59);
            this.TimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(600, 29);
            this.TimeNow.TabIndex = 1;
            this.TimeNow.Text = "TimeNow";
            this.TimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NowTimer
            // 
            this.NowTimer.Enabled = true;
            this.NowTimer.Interval = 1000;
            this.NowTimer.Tick += new System.EventHandler(this.NowTimer_Tick);
            // 
            // Closer
            // 
            this.Closer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Closer.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Closer.Location = new System.Drawing.Point(584, 0);
            this.Closer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Closer.Name = "Closer";
            this.Closer.Size = new System.Drawing.Size(16, 15);
            this.Closer.TabIndex = 2;
            this.Closer.Text = "X";
            this.Closer.Click += new System.EventHandler(this.label1_Click);
            this.Closer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.Closer.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.Closer.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.Closer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // Minimized
            // 
            this.Minimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Minimized.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Minimized.Location = new System.Drawing.Point(563, 0);
            this.Minimized.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Minimized.Name = "Minimized";
            this.Minimized.Size = new System.Drawing.Size(23, 15);
            this.Minimized.TabIndex = 3;
            this.Minimized.Text = "--";
            this.Minimized.Click += new System.EventHandler(this.label2_Click);
            this.Minimized.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label2_MouseDown);
            this.Minimized.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.Minimized.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            this.Minimized.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label2_MouseUp);
            // 
            // Mover
            // 
            this.Mover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Mover.Image = ((System.Drawing.Image)(resources.GetObject("Mover.Image")));
            this.Mover.Location = new System.Drawing.Point(0, 0);
            this.Mover.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Mover.Name = "Mover";
            this.Mover.Size = new System.Drawing.Size(16, 15);
            this.Mover.TabIndex = 4;
            this.Mover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Move_MouseDown);
            this.Mover.MouseEnter += new System.EventHandler(this.Move_MouseEnter);
            this.Mover.MouseLeave += new System.EventHandler(this.Move_MouseLeave);
            this.Mover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move_MouseMove);
            this.Mover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Move_MouseUp);
            // 
            // Helper
            // 
            this.Helper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Helper.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Helper.Location = new System.Drawing.Point(539, 0);
            this.Helper.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Helper.Name = "Helper";
            this.Helper.Size = new System.Drawing.Size(16, 16);
            this.Helper.TabIndex = 5;
            this.Helper.Text = "?";
            this.Helper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Helper.Click += new System.EventHandler(this.Helper_Click);
            this.Helper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Helper_MouseDown);
            this.Helper.MouseEnter += new System.EventHandler(this.Helper_MouseEnter);
            this.Helper.MouseLeave += new System.EventHandler(this.Helper_MouseLeave);
            this.Helper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Helper_MouseUp);
            // 
            // Abouter
            // 
            this.Abouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Abouter.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Abouter.Location = new System.Drawing.Point(24, 0);
            this.Abouter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Abouter.Name = "Abouter";
            this.Abouter.Size = new System.Drawing.Size(16, 16);
            this.Abouter.TabIndex = 6;
            this.Abouter.Text = "!";
            this.Abouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Abouter.Click += new System.EventHandler(this.Abouter_Click);
            this.Abouter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Abouter_MouseDown);
            this.Abouter.MouseEnter += new System.EventHandler(this.Abouter_MouseEnter);
            this.Abouter.MouseLeave += new System.EventHandler(this.Abouter_MouseLeave);
            this.Abouter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Abouter_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 16);
            this.label1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(600, 88);
            this.Controls.Add(this.Abouter);
            this.Controls.Add(this.Helper);
            this.Controls.Add(this.Mover);
            this.Controls.Add(this.Minimized);
            this.Controls.Add(this.Closer);
            this.Controls.Add(this.TimeNow);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "TimeStart";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer Form2Timer;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 計時器ToolStripMenuItem;
        private System.Windows.Forms.Label TimeNow;
        private System.Windows.Forms.Timer NowTimer;
        private System.Windows.Forms.Label Closer;
        private System.Windows.Forms.Label Minimized;
        private System.Windows.Forms.Label Mover;
        private System.Windows.Forms.Label Helper;
        private System.Windows.Forms.Label Abouter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 關閉ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 倒數計時器ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

