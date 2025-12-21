namespace EveningLearningCaretaker
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            还原窗口ToolStripMenuItem = new ToolStripMenuItem();
            退出ToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 21F);
            label1.Location = new Point(294, 70);
            label1.Name = "label1";
            label1.Size = new Size(230, 46);
            label1.TabIndex = 0;
            label1.Text = "晚自习看护器";
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "晚自习看护器";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += notifyIcon1_MouseDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 还原窗口ToolStripMenuItem, 退出ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(139, 52);
            // 
            // 还原窗口ToolStripMenuItem
            // 
            还原窗口ToolStripMenuItem.Name = "还原窗口ToolStripMenuItem";
            还原窗口ToolStripMenuItem.Size = new Size(138, 24);
            还原窗口ToolStripMenuItem.Text = "还原窗口";
            还原窗口ToolStripMenuItem.Click += 还原窗口ToolStripMenuItem_Click;
            // 
            // 退出ToolStripMenuItem
            // 
            退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            退出ToolStripMenuItem.Size = new Size(138, 24);
            退出ToolStripMenuItem.Text = "退出";
            退出ToolStripMenuItem.Click += 退出ToolStripMenuItem_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(86, 152);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(179, 215);
            textBox1.TabIndex = 1;
            textBox1.TabStop = false;
            textBox1.Text = "使用说明：\r\n点击右下角的设置按钮进行设置，设置好触发语音提醒的音量阈值与语音后，点X关闭窗口即可\r\n退出方式：\r\n右击托盘图标并点击“退出”按钮彻底关闭程序";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Location = new Point(634, 402);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 0;
            button1.TabStop = false;
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(672, 383);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "设置";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(440, 188);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "当前分贝：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(530, 188);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 4;
            label3.Text = "db";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "晚自习看护器";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 还原窗口ToolStripMenuItem;
        private ToolStripMenuItem 退出ToolStripMenuItem;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}
