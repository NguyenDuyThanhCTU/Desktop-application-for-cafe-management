namespace Project1
{
    partial class Form_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhanVien));
            this.Menu_QLNV = new System.Windows.Forms.MenuStrip();
            this.Menu_QLCLV = new System.Windows.Forms.ToolStripMenuItem();
            this.điểmDanhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhsachcalamviectoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContain = new System.Windows.Forms.Panel();
            this.userControl_DiemDanh1 = new Project1.UserControl_DiemDanh();
            this.userControl_DSCLV1 = new Project1.UserControl_DSCLV();
            this.userControl_DSNV1 = new Project1.UserControl_DSNV();
            this.Menu_QLNV.SuspendLayout();
            this.panelContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_QLNV
            // 
            this.Menu_QLNV.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Menu_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_QLNV.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_QLNV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_QLCLV,
            this.quảnLýNhânViênToolStripMenuItem});
            this.Menu_QLNV.Location = new System.Drawing.Point(0, 0);
            this.Menu_QLNV.Name = "Menu_QLNV";
            this.Menu_QLNV.Size = new System.Drawing.Size(1561, 30);
            this.Menu_QLNV.TabIndex = 0;
            this.Menu_QLNV.Tag = "Quản Lý Nhân Viên";
            this.Menu_QLNV.Text = "menuStrip1";
            // 
            // Menu_QLCLV
            // 
            this.Menu_QLCLV.BackColor = System.Drawing.SystemColors.Window;
            this.Menu_QLCLV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điểmDanhToolStripMenuItem,
            this.danhsachcalamviectoolStripMenuItem});
            this.Menu_QLCLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_QLCLV.Name = "Menu_QLCLV";
            this.Menu_QLCLV.Size = new System.Drawing.Size(188, 26);
            this.Menu_QLCLV.Text = "Quản Lý Ca Làm Việc";
            // 
            // điểmDanhToolStripMenuItem
            // 
            this.điểmDanhToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.điểmDanhToolStripMenuItem.Name = "điểmDanhToolStripMenuItem";
            this.điểmDanhToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.điểmDanhToolStripMenuItem.Text = "Điểm Danh";
            this.điểmDanhToolStripMenuItem.Click += new System.EventHandler(this.điểmDanhToolStripMenuItem_Click);
            // 
            // danhsachcalamviectoolStripMenuItem
            // 
            this.danhsachcalamviectoolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhsachcalamviectoolStripMenuItem.Name = "danhsachcalamviectoolStripMenuItem";
            this.danhsachcalamviectoolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.danhsachcalamviectoolStripMenuItem.Text = "Danh Sách Ca Làm Việc";
            this.danhsachcalamviectoolStripMenuItem.Click += new System.EventHandler(this.danhsachcalamviectoolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.BackColor = System.Drawing.SystemColors.Window;
            this.quảnLýNhânViênToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchNhânViênToolStripMenuItem,
            this.thêmMớiToolStripMenuItem});
            this.quảnLýNhânViênToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản Lý Nhân Viên";
            // 
            // danhSáchNhânViênToolStripMenuItem
            // 
            this.danhSáchNhânViênToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.danhSáchNhânViênToolStripMenuItem.Name = "danhSáchNhânViênToolStripMenuItem";
            this.danhSáchNhânViênToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.danhSáchNhânViênToolStripMenuItem.Text = "Danh Sách Nhân Viên";
            this.danhSáchNhânViênToolStripMenuItem.Click += new System.EventHandler(this.danhSáchNhânViênToolStripMenuItem_Click);
            // 
            // thêmMớiToolStripMenuItem
            // 
            this.thêmMớiToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thêmMớiToolStripMenuItem.Name = "thêmMớiToolStripMenuItem";
            this.thêmMớiToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.thêmMớiToolStripMenuItem.Text = "Thêm Mới";
            this.thêmMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmMớiToolStripMenuItem_Click);
            // 
            // panelContain
            // 
            this.panelContain.Controls.Add(this.userControl_DiemDanh1);
            this.panelContain.Controls.Add(this.userControl_DSCLV1);
            this.panelContain.Controls.Add(this.userControl_DSNV1);
            this.panelContain.Location = new System.Drawing.Point(0, 30);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1561, 849);
            this.panelContain.TabIndex = 1;
            // 
            // userControl_DiemDanh1
            // 
            this.userControl_DiemDanh1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_DiemDanh1.BackgroundImage")));
            this.userControl_DiemDanh1.Location = new System.Drawing.Point(0, 0);
            this.userControl_DiemDanh1.Name = "userControl_DiemDanh1";
            this.userControl_DiemDanh1.Size = new System.Drawing.Size(1561, 849);
            this.userControl_DiemDanh1.TabIndex = 2;
            // 
            // userControl_DSCLV1
            // 
            this.userControl_DSCLV1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.userControl_DSCLV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_DSCLV1.BackgroundImage")));
            this.userControl_DSCLV1.Location = new System.Drawing.Point(0, 0);
            this.userControl_DSCLV1.Name = "userControl_DSCLV1";
            this.userControl_DSCLV1.Size = new System.Drawing.Size(1561, 849);
            this.userControl_DSCLV1.TabIndex = 1;
            // 
            // userControl_DSNV1
            // 
            this.userControl_DSNV1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userControl_DSNV1.BackgroundImage")));
            this.userControl_DSNV1.Location = new System.Drawing.Point(0, 1);
            this.userControl_DSNV1.Name = "userControl_DSNV1";
            this.userControl_DSNV1.Size = new System.Drawing.Size(1561, 849);
            this.userControl_DSNV1.TabIndex = 0;
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1561, 877);
            this.Controls.Add(this.panelContain);
            this.Controls.Add(this.Menu_QLNV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu_QLNV;
            this.MaximizeBox = false;
            this.Name = "Form_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Menu_QLNV.ResumeLayout(false);
            this.Menu_QLNV.PerformLayout();
            this.panelContain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu_QLNV;
        private System.Windows.Forms.ToolStripMenuItem Menu_QLCLV;
        private System.Windows.Forms.ToolStripMenuItem điểmDanhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhsachcalamviectoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmMớiToolStripMenuItem;
        private System.Windows.Forms.Panel panelContain;
        private UserControl_DSNV userControl_DSNV1;
        private UserControl_DiemDanh userControl_DiemDanh1;
        private UserControl_DSCLV userControl_DSCLV1;
    }
}