namespace ssj
{
    partial class frmMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.喷射器种类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.气气喷射器SSJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.气液喷射器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.液气喷射器WSJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.液液喷射器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加介质ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.喷射器种类ToolStripMenuItem,
            this.数据库管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 喷射器种类ToolStripMenuItem
            // 
            this.喷射器种类ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.气气喷射器SSJToolStripMenuItem,
            this.气液喷射器ToolStripMenuItem,
            this.液气喷射器WSJToolStripMenuItem,
            this.液液喷射器ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.退出EToolStripMenuItem});
            this.喷射器种类ToolStripMenuItem.Name = "喷射器种类ToolStripMenuItem";
            this.喷射器种类ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.喷射器种类ToolStripMenuItem.Text = "喷射器种类";
            // 
            // 气气喷射器SSJToolStripMenuItem
            // 
            this.气气喷射器SSJToolStripMenuItem.Name = "气气喷射器SSJToolStripMenuItem";
            this.气气喷射器SSJToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.气气喷射器SSJToolStripMenuItem.Text = "气-气喷射器（SSJ）";
            this.气气喷射器SSJToolStripMenuItem.Click += new System.EventHandler(this.气气喷射器SSJToolStripMenuItem_Click);
            // 
            // 气液喷射器ToolStripMenuItem
            // 
            this.气液喷射器ToolStripMenuItem.Name = "气液喷射器ToolStripMenuItem";
            this.气液喷射器ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.气液喷射器ToolStripMenuItem.Text = "气-液喷射器（SWJ）";
            // 
            // 液气喷射器WSJToolStripMenuItem
            // 
            this.液气喷射器WSJToolStripMenuItem.Name = "液气喷射器WSJToolStripMenuItem";
            this.液气喷射器WSJToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.液气喷射器WSJToolStripMenuItem.Text = "液-气喷射器（WSJ）";
            // 
            // 液液喷射器ToolStripMenuItem
            // 
            this.液液喷射器ToolStripMenuItem.Name = "液液喷射器ToolStripMenuItem";
            this.液液喷射器ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.液液喷射器ToolStripMenuItem.Text = "液-液喷射器（WWJ）";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(191, 6);
            // 
            // 退出EToolStripMenuItem
            // 
            this.退出EToolStripMenuItem.Name = "退出EToolStripMenuItem";
            this.退出EToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.退出EToolStripMenuItem.Text = "退出&E";
            // 
            // 数据库管理ToolStripMenuItem
            // 
            this.数据库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加介质ToolStripMenuItem});
            this.数据库管理ToolStripMenuItem.Name = "数据库管理ToolStripMenuItem";
            this.数据库管理ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.数据库管理ToolStripMenuItem.Text = "数据库管理";
            // 
            // 添加介质ToolStripMenuItem
            // 
            this.添加介质ToolStripMenuItem.Name = "添加介质ToolStripMenuItem";
            this.添加介质ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加介质ToolStripMenuItem.Text = "添加介质";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 437);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "蒸汽喷射器设计软件";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 喷射器种类ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 气气喷射器SSJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 气液喷射器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 液气喷射器WSJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 液液喷射器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加介质ToolStripMenuItem;
    }
}