namespace Project1
{
    partial class Kho_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kho_Form));
            this.panel_Contain = new System.Windows.Forms.Panel();
            this.Menu_VP = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dụngCụPhaChếToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_LS = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.userControl_NgLieu1 = new Project1.UserControl_NgLieu();
            this.userControl_DCPC1 = new Project1.UserControl_DCPC();
            this.userControl_DCDTP1 = new Project1.UserControl_DCDTP();
            this.userControl_LSNK1 = new Project1.UserControl_LSNK();
            this.userControl_LSXK1 = new Project1.UserControl_LSXK();
            this.panel_Contain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Contain
            // 
            this.panel_Contain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Contain.Controls.Add(this.userControl_NgLieu1);
            this.panel_Contain.Controls.Add(this.userControl_DCPC1);
            this.panel_Contain.Controls.Add(this.userControl_DCDTP1);
            this.panel_Contain.Controls.Add(this.userControl_LSNK1);
            this.panel_Contain.Controls.Add(this.userControl_LSXK1);
            this.panel_Contain.Location = new System.Drawing.Point(0, 36);
            this.panel_Contain.Name = "panel_Contain";
            this.panel_Contain.Size = new System.Drawing.Size(1166, 851);
            this.panel_Contain.TabIndex = 1;
            // 
            // Menu_VP
            // 
            this.Menu_VP.BackColor = System.Drawing.SystemColors.Window;
            this.Menu_VP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nguyênLiệuToolStripMenuItem,
            this.dụngCụPhaChếToolStripMenuItem,
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem});
            this.Menu_VP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_VP.Name = "Menu_VP";
            this.Menu_VP.Size = new System.Drawing.Size(210, 29);
            this.Menu_VP.Text = "Vật Phẩm Trong Kho";
            this.Menu_VP.Click += new System.EventHandler(this.Menu_VP_Click);
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            this.nguyênLiệuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            this.nguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.nguyênLiệuToolStripMenuItem.Text = "Nguyên Liệu";
            this.nguyênLiệuToolStripMenuItem.Click += new System.EventHandler(this.nguyênLiệuToolStripMenuItem_Click);
            // 
            // dụngCụPhaChếToolStripMenuItem
            // 
            this.dụngCụPhaChếToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dụngCụPhaChếToolStripMenuItem.Name = "dụngCụPhaChếToolStripMenuItem";
            this.dụngCụPhaChếToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.dụngCụPhaChếToolStripMenuItem.Text = "Dụng Cụ Pha Chế";
            this.dụngCụPhaChếToolStripMenuItem.Click += new System.EventHandler(this.dụngCụPhaChếToolStripMenuItem_Click);
            // 
            // dụngCụĐựngThànhPhẩmToolStripMenuItem
            // 
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem.Name = "dụngCụĐựngThànhPhẩmToolStripMenuItem";
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem.Size = new System.Drawing.Size(304, 26);
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem.Text = "Dụng Cụ Đựng Thành Phẩm";
            this.dụngCụĐựngThànhPhẩmToolStripMenuItem.Click += new System.EventHandler(this.dụngCụĐựngThànhPhẩmToolStripMenuItem_Click);
            // 
            // Menu_LS
            // 
            this.Menu_LS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpKhoToolStripMenuItem1,
            this.xuấtKhoToolStripMenuItem1});
            this.Menu_LS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_LS.Name = "Menu_LS";
            this.Menu_LS.Size = new System.Drawing.Size(92, 29);
            this.Menu_LS.Text = "Lịch Sử";
            // 
            // nhậpKhoToolStripMenuItem1
            // 
            this.nhậpKhoToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhậpKhoToolStripMenuItem1.Name = "nhậpKhoToolStripMenuItem1";
            this.nhậpKhoToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.nhậpKhoToolStripMenuItem1.Text = "Nhập Kho";
            this.nhậpKhoToolStripMenuItem1.Click += new System.EventHandler(this.nhậpKhoToolStripMenuItem1_Click);
            // 
            // xuấtKhoToolStripMenuItem1
            // 
            this.xuấtKhoToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuấtKhoToolStripMenuItem1.Name = "xuấtKhoToolStripMenuItem1";
            this.xuấtKhoToolStripMenuItem1.Size = new System.Drawing.Size(168, 26);
            this.xuấtKhoToolStripMenuItem1.Text = "Xuất Kho";
            this.xuấtKhoToolStripMenuItem1.Click += new System.EventHandler(this.xuấtKhoToolStripMenuItem1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_VP,
            this.Menu_LS});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // userControl_NgLieu1
            // 
            this.userControl_NgLieu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_NgLieu1.BackgroundImage")));
            this.userControl_NgLieu1.Location = new System.Drawing.Point(0, -3);
            this.userControl_NgLieu1.Name = "userControl_NgLieu1";
            this.userControl_NgLieu1.Size = new System.Drawing.Size(1166, 851);
            this.userControl_NgLieu1.TabIndex = 4;
            this.userControl_NgLieu1.Load += new System.EventHandler(this.userControl_NgLieu1_Load_1);
            // 
            // userControl_DCPC1
            // 
            this.userControl_DCPC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_DCPC1.BackgroundImage")));
            this.userControl_DCPC1.Location = new System.Drawing.Point(0, 0);
            this.userControl_DCPC1.Name = "userControl_DCPC1";
            this.userControl_DCPC1.Size = new System.Drawing.Size(1166, 851);
            this.userControl_DCPC1.TabIndex = 3;
            // 
            // userControl_DCDTP1
            // 
            this.userControl_DCDTP1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_DCDTP1.BackgroundImage")));
            this.userControl_DCDTP1.Location = new System.Drawing.Point(0, 0);
            this.userControl_DCDTP1.Name = "userControl_DCDTP1";
            this.userControl_DCDTP1.Size = new System.Drawing.Size(1166, 851);
            this.userControl_DCDTP1.TabIndex = 2;
            // 
            // userControl_LSNK1
            // 
            this.userControl_LSNK1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_LSNK1.BackgroundImage")));
            this.userControl_LSNK1.Location = new System.Drawing.Point(0, -3);
            this.userControl_LSNK1.Name = "userControl_LSNK1";
            this.userControl_LSNK1.Size = new System.Drawing.Size(1166, 851);
            this.userControl_LSNK1.TabIndex = 1;
            // 
            // userControl_LSXK1
            // 
            this.userControl_LSXK1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_LSXK1.BackgroundImage")));
            this.userControl_LSXK1.Location = new System.Drawing.Point(0, -7);
            this.userControl_LSXK1.Name = "userControl_LSXK1";
            this.userControl_LSXK1.Size = new System.Drawing.Size(1166, 851);
            this.userControl_LSXK1.TabIndex = 0;
            this.userControl_LSXK1.Load += new System.EventHandler(this.userControl_LSXK1_Load);
            // 
            // Kho_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1166, 882);
            this.Controls.Add(this.panel_Contain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Kho_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhà Kho";
            this.panel_Contain.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel_Contain;
        private System.Windows.Forms.ToolStripMenuItem Menu_VP;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dụngCụPhaChếToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dụngCụĐựngThànhPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_LS;
        private System.Windows.Forms.ToolStripMenuItem nhậpKhoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xuấtKhoToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private UserControl_LSXK userControl_LSXK1;
        private UserControl_NgLieu userControl_NgLieu1;
        private UserControl_DCPC userControl_DCPC1;
        private UserControl_DCDTP userControl_DCDTP1;
        private UserControl_LSNK userControl_LSNK1;
    }
}