namespace SystemInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPUStatusLabel = new System.Windows.Forms.Label();
            this.coreNumberLabel = new System.Windows.Forms.Label();
            this.clockSpeedLabel = new System.Windows.Forms.Label();
            this.CPUNameLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GPUStatusLabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.memoryLabel = new System.Windows.Forms.Label();
            this.GPUNameLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.computerNameLabel = new System.Windows.Forms.Label();
            this.systemVersionLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CPUStatusLabel);
            this.groupBox1.Controls.Add(this.coreNumberLabel);
            this.groupBox1.Controls.Add(this.clockSpeedLabel);
            this.groupBox1.Controls.Add(this.CPUNameLabel);
            this.groupBox1.Location = new System.Drawing.Point(10, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(370, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CPU";
            // 
            // CPUStatusLabel
            // 
            this.CPUStatusLabel.AutoSize = true;
            this.CPUStatusLabel.Location = new System.Drawing.Point(9, 95);
            this.CPUStatusLabel.Margin = new System.Windows.Forms.Padding(2);
            this.CPUStatusLabel.Name = "CPUStatusLabel";
            this.CPUStatusLabel.Size = new System.Drawing.Size(120, 18);
            this.CPUStatusLabel.TabIndex = 3;
            this.CPUStatusLabel.Text = "CPUStatusLabel";
            // 
            // coreNumberLabel
            // 
            this.coreNumberLabel.AutoSize = true;
            this.coreNumberLabel.Location = new System.Drawing.Point(9, 71);
            this.coreNumberLabel.Margin = new System.Windows.Forms.Padding(2);
            this.coreNumberLabel.Name = "coreNumberLabel";
            this.coreNumberLabel.Size = new System.Drawing.Size(128, 18);
            this.coreNumberLabel.TabIndex = 2;
            this.coreNumberLabel.Text = "coreNumberLabel";
            // 
            // clockSpeedLabel
            // 
            this.clockSpeedLabel.AutoSize = true;
            this.clockSpeedLabel.Location = new System.Drawing.Point(9, 47);
            this.clockSpeedLabel.Margin = new System.Windows.Forms.Padding(2);
            this.clockSpeedLabel.Name = "clockSpeedLabel";
            this.clockSpeedLabel.Size = new System.Drawing.Size(128, 18);
            this.clockSpeedLabel.TabIndex = 1;
            this.clockSpeedLabel.Text = "clockSpeedLabel";
            // 
            // CPUNameLabel
            // 
            this.CPUNameLabel.AutoSize = true;
            this.CPUNameLabel.Location = new System.Drawing.Point(9, 24);
            this.CPUNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.CPUNameLabel.Name = "CPUNameLabel";
            this.CPUNameLabel.Size = new System.Drawing.Size(104, 18);
            this.CPUNameLabel.TabIndex = 0;
            this.CPUNameLabel.Text = "CPUNameLabel";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.GPUStatusLabel);
            this.groupBox2.Controls.Add(this.driverLabel);
            this.groupBox2.Controls.Add(this.memoryLabel);
            this.groupBox2.Controls.Add(this.GPUNameLabel);
            this.groupBox2.Location = new System.Drawing.Point(384, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(370, 190);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GPU";
            // 
            // GPUStatusLabel
            // 
            this.GPUStatusLabel.AutoSize = true;
            this.GPUStatusLabel.Location = new System.Drawing.Point(6, 95);
            this.GPUStatusLabel.Margin = new System.Windows.Forms.Padding(2);
            this.GPUStatusLabel.Name = "GPUStatusLabel";
            this.GPUStatusLabel.Size = new System.Drawing.Size(120, 18);
            this.GPUStatusLabel.TabIndex = 7;
            this.GPUStatusLabel.Text = "GPUStatusLabel";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(6, 71);
            this.driverLabel.Margin = new System.Windows.Forms.Padding(2);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(96, 18);
            this.driverLabel.TabIndex = 6;
            this.driverLabel.Text = "driverLabel";
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.Location = new System.Drawing.Point(6, 47);
            this.memoryLabel.Margin = new System.Windows.Forms.Padding(2);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(96, 18);
            this.memoryLabel.TabIndex = 5;
            this.memoryLabel.Text = "memoryLabel";
            // 
            // GPUNameLabel
            // 
            this.GPUNameLabel.AutoSize = true;
            this.GPUNameLabel.Location = new System.Drawing.Point(6, 24);
            this.GPUNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.GPUNameLabel.Name = "GPUNameLabel";
            this.GPUNameLabel.Size = new System.Drawing.Size(104, 18);
            this.GPUNameLabel.TabIndex = 4;
            this.GPUNameLabel.Text = "GPUNameLabel";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.computerNameLabel);
            this.groupBox3.Controls.Add(this.systemVersionLabel);
            this.groupBox3.Controls.Add(this.userNameLabel);
            this.groupBox3.Location = new System.Drawing.Point(10, 221);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(744, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "System";
            // 
            // computerNameLabel
            // 
            this.computerNameLabel.AutoSize = true;
            this.computerNameLabel.Location = new System.Drawing.Point(9, 44);
            this.computerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.computerNameLabel.Name = "computerNameLabel";
            this.computerNameLabel.Padding = new System.Windows.Forms.Padding(2);
            this.computerNameLabel.Size = new System.Drawing.Size(148, 22);
            this.computerNameLabel.TabIndex = 3;
            this.computerNameLabel.Text = "computerNameLabel";
            // 
            // systemVersionLabel
            // 
            this.systemVersionLabel.AutoSize = true;
            this.systemVersionLabel.Location = new System.Drawing.Point(9, 68);
            this.systemVersionLabel.Margin = new System.Windows.Forms.Padding(2);
            this.systemVersionLabel.Name = "systemVersionLabel";
            this.systemVersionLabel.Size = new System.Drawing.Size(152, 18);
            this.systemVersionLabel.TabIndex = 2;
            this.systemVersionLabel.Text = "systemVersionLabel";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(9, 24);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(2);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(112, 18);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "userNameLabel";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(764, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripTimeLabel
            // 
            this.toolStripTimeLabel.Name = "toolStripTimeLabel";
            this.toolStripTimeLabel.Size = new System.Drawing.Size(106, 17);
            this.toolStripTimeLabel.Text = "toolStripTimeLabel";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 342);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(780, 381);
            this.MinimumSize = new System.Drawing.Size(780, 381);
            this.Name = "Form1";
            this.Text = "System Info";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label CPUStatusLabel;
        private Label coreNumberLabel;
        private Label clockSpeedLabel;
        private Label CPUNameLabel;
        private Label GPUStatusLabel;
        private Label driverLabel;
        private Label memoryLabel;
        private Label GPUNameLabel;
        private Label systemVersionLabel;
        private Label userNameLabel;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private Label computerNameLabel;
        private System.Windows.Forms.Timer timer1;
        private ToolStripStatusLabel toolStripTimeLabel;
    }
}