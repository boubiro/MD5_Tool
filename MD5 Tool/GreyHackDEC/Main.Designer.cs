namespace GreyHackDEC
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
            this.decypherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proxyListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringBox = new System.Windows.Forms.TextBox();
            this.stringGroup = new System.Windows.Forms.GroupBox();
            this.md5Group = new System.Windows.Forms.GroupBox();
            this.md5Box = new System.Windows.Forms.TextBox();
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
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.decypherToolStripMenuItem,
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
            this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // decypherToolStripMenuItem
            // 
            this.decypherToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.decypherToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.decypherToolStripMenuItem.Name = "decypherToolStripMenuItem";
            this.decypherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.decypherToolStripMenuItem.Text = "Decypher";
            this.decypherToolStripMenuItem.Click += new System.EventHandler(this.decypherToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
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
            this.stringBox.ReadOnly = true;
            this.stringBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stringBox.Size = new System.Drawing.Size(322, 402);
            this.stringBox.TabIndex = 0;
            this.stringBox.TextChanged += new System.EventHandler(this.stringBox_TextChanged);
            // 
            // stringGroup
            // 
            this.stringGroup.Controls.Add(this.stringBox);
            this.stringGroup.ForeColor = System.Drawing.Color.Lime;
            this.stringGroup.Location = new System.Drawing.Point(355, 27);
            this.stringGroup.Name = "stringGroup";
            this.stringGroup.Size = new System.Drawing.Size(334, 427);
            this.stringGroup.TabIndex = 2;
            this.stringGroup.TabStop = false;
            this.stringGroup.Text = "Strings";
            // 
            // md5Group
            // 
            this.md5Group.Controls.Add(this.md5Box);
            this.md5Group.ForeColor = System.Drawing.Color.Lime;
            this.md5Group.Location = new System.Drawing.Point(12, 27);
            this.md5Group.Name = "md5Group";
            this.md5Group.Size = new System.Drawing.Size(337, 427);
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
            this.md5Box.Size = new System.Drawing.Size(325, 402);
            this.md5Box.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(702, 465);
            this.Controls.Add(this.stringGroup);
            this.Controls.Add(this.md5Group);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Grey Hack MD5 Decipher Tool";
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
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proxyListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decypherToolStripMenuItem;
    }
}

