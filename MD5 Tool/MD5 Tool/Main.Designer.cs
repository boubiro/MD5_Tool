namespace MD5_Tool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringOutputtxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5OutputhshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.stringGroup = new System.Windows.Forms.GroupBox();
            this.md5Group = new System.Windows.Forms.GroupBox();
            this.md5Box = new System.Windows.Forms.TextBox();
            this.stringToMd5Button = new System.Windows.Forms.Button();
            this.md5ToStringButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.stringGroup.SuspendLayout();
            this.md5Group.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.proxyListToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringFileToolStripMenuItem,
            this.mD5ToolStripMenuItem});
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // stringFileToolStripMenuItem
            // 
            this.stringFileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.stringFileToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.stringFileToolStripMenuItem.Name = "stringFileToolStripMenuItem";
            this.stringFileToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.stringFileToolStripMenuItem.Text = "String File (*.txt)";
            this.stringFileToolStripMenuItem.ToolTipText = "Open text file containing strings to hash";
            this.stringFileToolStripMenuItem.Click += new System.EventHandler(this.stringFileToolStripMenuItem_Click);
            // 
            // mD5ToolStripMenuItem
            // 
            this.mD5ToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mD5ToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.mD5ToolStripMenuItem.Name = "mD5ToolStripMenuItem";
            this.mD5ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.mD5ToolStripMenuItem.Text = "MD5 File (*.hsh)";
            this.mD5ToolStripMenuItem.ToolTipText = "Open hash file with MD5 hases one per line";
            this.mD5ToolStripMenuItem.Click += new System.EventHandler(this.mD5ToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stringOutputtxtToolStripMenuItem,
            this.mD5OutputhshToolStripMenuItem});
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            // 
            // stringOutputtxtToolStripMenuItem
            // 
            this.stringOutputtxtToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.stringOutputtxtToolStripMenuItem.Enabled = false;
            this.stringOutputtxtToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.stringOutputtxtToolStripMenuItem.Name = "stringOutputtxtToolStripMenuItem";
            this.stringOutputtxtToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.stringOutputtxtToolStripMenuItem.Text = "String output (*.txt)";
            this.stringOutputtxtToolStripMenuItem.ToolTipText = "Save string window as text file";
            this.stringOutputtxtToolStripMenuItem.Click += new System.EventHandler(this.stringOutputtxtToolStripMenuItem_Click);
            // 
            // mD5OutputhshToolStripMenuItem
            // 
            this.mD5OutputhshToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.mD5OutputhshToolStripMenuItem.Enabled = false;
            this.mD5OutputhshToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.mD5OutputhshToolStripMenuItem.Name = "mD5OutputhshToolStripMenuItem";
            this.mD5OutputhshToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.mD5OutputhshToolStripMenuItem.Text = "MD5 output (*.hsh)";
            this.mD5OutputhshToolStripMenuItem.ToolTipText = "Save MD5 window as hsh file";
            this.mD5OutputhshToolStripMenuItem.Click += new System.EventHandler(this.mD5OutputhshToolStripMenuItem_Click);
            // 
            // proxyListToolStripMenuItem
            // 
            this.proxyListToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.proxyListToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.proxyListToolStripMenuItem.Name = "proxyListToolStripMenuItem";
            this.proxyListToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.proxyListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proxyListToolStripMenuItem.Text = "Proxy List";
            this.proxyListToolStripMenuItem.ToolTipText = "Manage proxy list";
            this.proxyListToolStripMenuItem.Click += new System.EventHandler(this.proxyListToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.closeToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.ToolTipText = "Exit application";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // stringBox
            // 
            this.stringBox.BackColor = System.Drawing.Color.Black;
            this.stringBox.ForeColor = System.Drawing.Color.Lime;
            this.stringBox.Location = new System.Drawing.Point(6, 19);
            this.stringBox.Multiline = true;
            this.stringBox.Name = "stringBox";
            this.stringBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stringBox.Size = new System.Drawing.Size(322, 440);
            this.stringBox.TabIndex = 0;
            this.stringBox.TextChanged += new System.EventHandler(this.stringBox_TextChanged);
            // 
            // stringGroup
            // 
            this.stringGroup.Controls.Add(this.stringBox);
            this.stringGroup.ForeColor = System.Drawing.Color.Lime;
            this.stringGroup.Location = new System.Drawing.Point(12, 27);
            this.stringGroup.Name = "stringGroup";
            this.stringGroup.Size = new System.Drawing.Size(334, 465);
            this.stringGroup.TabIndex = 2;
            this.stringGroup.TabStop = false;
            this.stringGroup.Text = "Strings";
            // 
            // md5Group
            // 
            this.md5Group.Controls.Add(this.md5Box);
            this.md5Group.ForeColor = System.Drawing.Color.Lime;
            this.md5Group.Location = new System.Drawing.Point(451, 27);
            this.md5Group.Name = "md5Group";
            this.md5Group.Size = new System.Drawing.Size(337, 465);
            this.md5Group.TabIndex = 3;
            this.md5Group.TabStop = false;
            this.md5Group.Text = "MD5";
            // 
            // md5Box
            // 
            this.md5Box.BackColor = System.Drawing.Color.Black;
            this.md5Box.ForeColor = System.Drawing.Color.Lime;
            this.md5Box.Location = new System.Drawing.Point(6, 19);
            this.md5Box.Multiline = true;
            this.md5Box.Name = "md5Box";
            this.md5Box.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.md5Box.Size = new System.Drawing.Size(325, 440);
            this.md5Box.TabIndex = 1;
            this.md5Box.TextChanged += new System.EventHandler(this.md5Box_TextChanged);
            // 
            // stringToMd5Button
            // 
            this.stringToMd5Button.BackColor = System.Drawing.Color.Lime;
            this.stringToMd5Button.ForeColor = System.Drawing.Color.Black;
            this.stringToMd5Button.Location = new System.Drawing.Point(361, 174);
            this.stringToMd5Button.Name = "stringToMd5Button";
            this.stringToMd5Button.Size = new System.Drawing.Size(75, 58);
            this.stringToMd5Button.TabIndex = 3;
            this.stringToMd5Button.Text = "-->";
            this.stringToMd5Button.UseVisualStyleBackColor = false;
            this.stringToMd5Button.Click += new System.EventHandler(this.stringToMd5Button_Click);
            // 
            // md5ToStringButton
            // 
            this.md5ToStringButton.BackColor = System.Drawing.Color.Black;
            this.md5ToStringButton.ForeColor = System.Drawing.Color.Lime;
            this.md5ToStringButton.Location = new System.Drawing.Point(361, 265);
            this.md5ToStringButton.Name = "md5ToStringButton";
            this.md5ToStringButton.Size = new System.Drawing.Size(75, 58);
            this.md5ToStringButton.TabIndex = 4;
            this.md5ToStringButton.Text = "<--";
            this.md5ToStringButton.UseVisualStyleBackColor = false;
            this.md5ToStringButton.Click += new System.EventHandler(this.md5ToStringButton_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Enabled = false;
            this.startButton.ForeColor = System.Drawing.Color.Gray;
            this.startButton.Location = new System.Drawing.Point(361, 451);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 35);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.EnabledChanged += new System.EventHandler(this.startButton_EnabledChanged);
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Paint += new System.Windows.Forms.PaintEventHandler(this.startButton_Paint);
            // 
            // Main
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.md5ToStringButton);
            this.Controls.Add(this.stringToMd5Button);
            this.Controls.Add(this.md5Group);
            this.Controls.Add(this.stringGroup);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "MD5 Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.stringGroup.ResumeLayout(false);
            this.stringGroup.PerformLayout();
            this.md5Group.ResumeLayout(false);
            this.md5Group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.TextBox stringBox;
        private System.Windows.Forms.GroupBox stringGroup;
        private System.Windows.Forms.GroupBox md5Group;
        private System.Windows.Forms.TextBox md5Box;
        private System.Windows.Forms.Button stringToMd5Button;
        private System.Windows.Forms.Button md5ToStringButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringOutputtxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mD5OutputhshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyListToolStripMenuItem;
    }
}

