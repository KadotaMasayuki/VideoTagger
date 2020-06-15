namespace VideoTagger
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelInterval = new System.Windows.Forms.Label();
            this.labelFPS = new System.Windows.Forms.Label();
            this.labelPosFrame = new System.Windows.Forms.Label();
            this.labelTotalFrame = new System.Windows.Forms.Label();
            this.labelPosSec = new System.Windows.Forms.Label();
            this.labelTotalSec = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxFPSToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFps = new System.Windows.Forms.ToolStripMenuItem();
            this.tagsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemT9 = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.trackBar1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(775, 472);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // trackBar1
            // 
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar1.LargeChange = 10;
            this.trackBar1.Location = new System.Drawing.Point(3, 405);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(769, 34);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.labelSpeed);
            this.flowLayoutPanel1.Controls.Add(this.labelInterval);
            this.flowLayoutPanel1.Controls.Add(this.labelFPS);
            this.flowLayoutPanel1.Controls.Add(this.labelPosFrame);
            this.flowLayoutPanel1.Controls.Add(this.labelTotalFrame);
            this.flowLayoutPanel1.Controls.Add(this.labelPosSec);
            this.flowLayoutPanel1.Controls.Add(this.labelTotalSec);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 445);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(769, 24);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPACE=\"START/STOP\"\r\nA=\"SLOW\", S=\"NORMAL\", D=\"FAST\"";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(209, 0);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(36, 12);
            this.labelSpeed.TabIndex = 5;
            this.labelSpeed.Text = "Speed";
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(251, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(43, 12);
            this.labelInterval.TabIndex = 6;
            this.labelInterval.Text = "Interval";
            // 
            // labelFPS
            // 
            this.labelFPS.AutoSize = true;
            this.labelFPS.Location = new System.Drawing.Point(300, 0);
            this.labelFPS.Name = "labelFPS";
            this.labelFPS.Size = new System.Drawing.Size(26, 12);
            this.labelFPS.TabIndex = 6;
            this.labelFPS.Text = "FPS";
            // 
            // labelPosFrame
            // 
            this.labelPosFrame.AutoSize = true;
            this.labelPosFrame.Location = new System.Drawing.Point(332, 0);
            this.labelPosFrame.Name = "labelPosFrame";
            this.labelPosFrame.Size = new System.Drawing.Size(83, 12);
            this.labelPosFrame.TabIndex = 7;
            this.labelPosFrame.Text = "Position[frame]";
            // 
            // labelTotalFrame
            // 
            this.labelTotalFrame.AutoSize = true;
            this.labelTotalFrame.Location = new System.Drawing.Point(421, 0);
            this.labelTotalFrame.Name = "labelTotalFrame";
            this.labelTotalFrame.Size = new System.Drawing.Size(68, 12);
            this.labelTotalFrame.TabIndex = 1;
            this.labelTotalFrame.Text = "Total[frame]";
            // 
            // labelPosSec
            // 
            this.labelPosSec.AutoSize = true;
            this.labelPosSec.Location = new System.Drawing.Point(495, 0);
            this.labelPosSec.Name = "labelPosSec";
            this.labelPosSec.Size = new System.Drawing.Size(60, 12);
            this.labelPosSec.TabIndex = 8;
            this.labelPosSec.Text = "Position[s]";
            // 
            // labelTotalSec
            // 
            this.labelTotalSec.AutoSize = true;
            this.labelTotalSec.Location = new System.Drawing.Point(561, 0);
            this.labelTotalSec.Name = "labelTotalSec";
            this.labelTotalSec.Size = new System.Drawing.Size(45, 12);
            this.labelTotalSec.TabIndex = 4;
            this.labelTotalSec.Text = "Total[s]";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 396);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 279);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.maxFPSToolStripMenuItem1,
            this.tagsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // maxFPSToolStripMenuItem1
            // 
            this.maxFPSToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFps});
            this.maxFPSToolStripMenuItem1.Name = "maxFPSToolStripMenuItem1";
            this.maxFPSToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
            this.maxFPSToolStripMenuItem1.Text = "Max FPS";
            // 
            // toolStripMenuItemFps
            // 
            this.toolStripMenuItemFps.Name = "toolStripMenuItemFps";
            this.toolStripMenuItemFps.Size = new System.Drawing.Size(86, 22);
            this.toolStripMenuItemFps.Text = "30";
            this.toolStripMenuItemFps.Click += new System.EventHandler(this.toolStripMenuItemFps_Click);
            // 
            // tagsToolStripMenuItem
            // 
            this.tagsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemT1,
            this.toolStripMenuItemT2,
            this.toolStripMenuItemT3,
            this.toolStripMenuItemT4,
            this.toolStripMenuItemT5,
            this.toolStripMenuItemT6,
            this.toolStripMenuItemT7,
            this.toolStripMenuItemT8,
            this.toolStripMenuItemT9});
            this.tagsToolStripMenuItem.Name = "tagsToolStripMenuItem";
            this.tagsToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.tagsToolStripMenuItem.Text = "Tags";
            // 
            // toolStripMenuItemT1
            // 
            this.toolStripMenuItemT1.Name = "toolStripMenuItemT1";
            this.toolStripMenuItemT1.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT1.Text = "1";
            this.toolStripMenuItemT1.Click += new System.EventHandler(this.toolStripMenuItemT1_Click);
            // 
            // toolStripMenuItemT2
            // 
            this.toolStripMenuItemT2.Name = "toolStripMenuItemT2";
            this.toolStripMenuItemT2.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT2.Text = "2";
            this.toolStripMenuItemT2.Click += new System.EventHandler(this.toolStripMenuItemT2_Click);
            // 
            // toolStripMenuItemT3
            // 
            this.toolStripMenuItemT3.Name = "toolStripMenuItemT3";
            this.toolStripMenuItemT3.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT3.Text = "3";
            this.toolStripMenuItemT3.Click += new System.EventHandler(this.toolStripMenuItemT3_Click);
            // 
            // toolStripMenuItemT4
            // 
            this.toolStripMenuItemT4.Name = "toolStripMenuItemT4";
            this.toolStripMenuItemT4.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT4.Text = "4";
            this.toolStripMenuItemT4.Click += new System.EventHandler(this.toolStripMenuItemT4_Click);
            // 
            // toolStripMenuItemT5
            // 
            this.toolStripMenuItemT5.Name = "toolStripMenuItemT5";
            this.toolStripMenuItemT5.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT5.Text = "5";
            this.toolStripMenuItemT5.Click += new System.EventHandler(this.toolStripMenuItemT5_Click);
            // 
            // toolStripMenuItemT6
            // 
            this.toolStripMenuItemT6.Name = "toolStripMenuItemT6";
            this.toolStripMenuItemT6.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT6.Text = "6";
            this.toolStripMenuItemT6.Click += new System.EventHandler(this.toolStripMenuItemT6_Click);
            // 
            // toolStripMenuItemT7
            // 
            this.toolStripMenuItemT7.Name = "toolStripMenuItemT7";
            this.toolStripMenuItemT7.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT7.Text = "7";
            this.toolStripMenuItemT7.Click += new System.EventHandler(this.toolStripMenuItemT7_Click);
            // 
            // toolStripMenuItemT8
            // 
            this.toolStripMenuItemT8.Name = "toolStripMenuItemT8";
            this.toolStripMenuItemT8.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT8.Text = "8";
            this.toolStripMenuItemT8.Click += new System.EventHandler(this.toolStripMenuItemT8_Click);
            // 
            // toolStripMenuItemT9
            // 
            this.toolStripMenuItemT9.Name = "toolStripMenuItemT9";
            this.toolStripMenuItemT9.Size = new System.Drawing.Size(80, 22);
            this.toolStripMenuItemT9.Text = "9";
            this.toolStripMenuItemT9.Click += new System.EventHandler(this.toolStripMenuItemT9_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(931, 478);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.listBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(784, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 472);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(138, 426);
            this.listBox1.TabIndex = 1;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(138, 34);
            this.panel2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(78, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "読出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 502);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTotalFrame;
        private System.Windows.Forms.Label labelTotalSec;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.Label labelFPS;
        private System.Windows.Forms.ToolStripMenuItem maxFPSToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFps;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ToolStripMenuItem tagsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemT9;
        private System.Windows.Forms.Label labelPosFrame;
        private System.Windows.Forms.Label labelPosSec;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

