namespace Store_manage
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.LoginTS = new System.Windows.Forms.ToolStripMenuItem();
            this.FileTS = new System.Windows.Forms.ToolStripMenuItem();
            this.biodataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CategoryTS = new System.Windows.Forms.ToolStripMenuItem();
            this.StorageTS = new System.Windows.Forms.ToolStripMenuItem();
            this.SellTS = new System.Windows.Forms.ToolStripMenuItem();
            this.SellInfoTS = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ComplaintTS = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTS = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoginTS,
            this.FileTS,
            this.CategoryTS,
            this.StorageTS,
            this.SellTS,
            this.SellInfoTS,
            this.IssueTS,
            this.ComplaintTS,
            this.LogoutTS,
            this.ExitTS});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(788, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // LoginTS
            // 
            this.LoginTS.Name = "LoginTS";
            this.LoginTS.Size = new System.Drawing.Size(57, 20);
            this.LoginTS.Text = "LOG IN";
            this.LoginTS.Click += new System.EventHandler(this.LoginTS_Click);
            // 
            // FileTS
            // 
            this.FileTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biodataToolStripMenuItem});
            this.FileTS.Name = "FileTS";
            this.FileTS.Size = new System.Drawing.Size(37, 20);
            this.FileTS.Text = "File";
//            this.FileTS.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // biodataToolStripMenuItem
            // 
            this.biodataToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.biodataToolStripMenuItem.Name = "biodataToolStripMenuItem";
            this.biodataToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.biodataToolStripMenuItem.Text = "Biodata";
            this.biodataToolStripMenuItem.Click += new System.EventHandler(this.biodataToolStripMenuItem_Click);
            // 
            // CategoryTS
            // 
            this.CategoryTS.Name = "CategoryTS";
            this.CategoryTS.Size = new System.Drawing.Size(78, 20);
            this.CategoryTS.Text = "CATEGORY";
            this.CategoryTS.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // StorageTS
            // 
            this.StorageTS.Name = "StorageTS";
            this.StorageTS.Size = new System.Drawing.Size(82, 20);
            this.StorageTS.Text = "INVENTORY";
            this.StorageTS.Click += new System.EventHandler(this.aDDPRODUCTToolStripMenuItem_Click);
            // 
            // SellTS
            // 
            this.SellTS.Name = "SellTS";
            this.SellTS.Size = new System.Drawing.Size(43, 20);
            this.SellTS.Text = "SELL";
            this.SellTS.Click += new System.EventHandler(this.sELLToolStripMenuItem_Click);
            // 
            // SellInfoTS
            // 
            this.SellInfoTS.Name = "SellInfoTS";
            this.SellInfoTS.Size = new System.Drawing.Size(93, 20);
            this.SellInfoTS.Text = "SELLING INFO";
            this.SellInfoTS.Click += new System.EventHandler(this.sELLINGINToolStripMenuItem_Click);
            // 
            // IssueTS
            // 
            this.IssueTS.Name = "IssueTS";
            this.IssueTS.Size = new System.Drawing.Size(48, 20);
            this.IssueTS.Text = "ISSUE";
            this.IssueTS.Click += new System.EventHandler(this.iSSUEToolStripMenuItem_Click);
            // 
            // ComplaintTS
            // 
            this.ComplaintTS.Name = "ComplaintTS";
            this.ComplaintTS.Size = new System.Drawing.Size(151, 20);
            this.ComplaintTS.Text = "CUSTOMER COMPLAINT";
            this.ComplaintTS.Click += new System.EventHandler(this.cUSTOMERCOMPLAINTToolStripMenuItem_Click);
            // 
            // LogoutTS
            // 
            this.LogoutTS.Name = "LogoutTS";
            this.LogoutTS.Size = new System.Drawing.Size(69, 20);
            this.LogoutTS.Text = "LOG OUT";
            this.LogoutTS.Click += new System.EventHandler(this.lOGOUTToolStripMenuItem_Click);
            // 
            // ExitTS
            // 
            this.ExitTS.Name = "ExitTS";
            this.ExitTS.Size = new System.Drawing.Size(42, 20);
            this.ExitTS.Text = "EXIT";
            this.ExitTS.Click += new System.EventHandler(this.ExitTS_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 546);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(788, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Status";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(125, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.UseCompatibleTextRendering = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Store_manage.Properties.Resources._17201365_10155106748801018_671568913605358518_n1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(788, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STORE";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem FileTS;
        private System.Windows.Forms.ToolStripMenuItem biodataToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem StorageTS;
        private System.Windows.Forms.ToolStripMenuItem IssueTS;
        private System.Windows.Forms.ToolStripMenuItem CategoryTS;
        private System.Windows.Forms.ToolStripMenuItem SellTS;
        private System.Windows.Forms.ToolStripMenuItem ComplaintTS;
        private System.Windows.Forms.ToolStripMenuItem SellInfoTS;
        private System.Windows.Forms.ToolStripMenuItem LogoutTS;
        private System.Windows.Forms.ToolStripMenuItem ExitTS;
        private System.Windows.Forms.ToolStripMenuItem LoginTS;
        private System.Windows.Forms.Label label2;
    }
}



