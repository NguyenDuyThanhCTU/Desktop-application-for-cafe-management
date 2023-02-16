namespace Project1
{
    partial class Form_DSSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DSSP));
            this.Panel_DS = new System.Windows.Forms.Panel();
            this.lblDS = new System.Windows.Forms.Label();
            this.DGV_Menu = new System.Windows.Forms.DataGridView();
            this.Panel_ChinhSua = new System.Windows.Forms.Panel();
            this.gBoxChinhSua = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.lblVND = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.gBoxThemMoi = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.tztMaSP = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.Column_MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.Panel_DS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).BeginInit();
            this.Panel_ChinhSua.SuspendLayout();
            this.gBoxChinhSua.SuspendLayout();
            this.gBoxThemMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_DS
            // 
            this.Panel_DS.BackColor = System.Drawing.Color.Transparent;
            this.Panel_DS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_DS.Controls.Add(this.btnLoad);
            this.Panel_DS.Controls.Add(this.btnChinhSua);
            this.Panel_DS.Controls.Add(this.btnThemMoi);
            this.Panel_DS.Controls.Add(this.DGV_Menu);
            this.Panel_DS.Controls.Add(this.lblDS);
            this.Panel_DS.Location = new System.Drawing.Point(29, 25);
            this.Panel_DS.Name = "Panel_DS";
            this.Panel_DS.Size = new System.Drawing.Size(818, 738);
            this.Panel_DS.TabIndex = 0;
            // 
            // lblDS
            // 
            this.lblDS.AutoSize = true;
            this.lblDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDS.Location = new System.Drawing.Point(233, 27);
            this.lblDS.Name = "lblDS";
            this.lblDS.Size = new System.Drawing.Size(322, 42);
            this.lblDS.TabIndex = 0;
            this.lblDS.Text = "Danh Sách Menu";
            // 
            // DGV_Menu
            // 
            this.DGV_Menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Menu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_Menu.BackgroundColor = System.Drawing.Color.White;
            this.DGV_Menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Menu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaSP,
            this.ColumnTenSP,
            this.ColumnGia});
            this.DGV_Menu.Location = new System.Drawing.Point(33, 95);
            this.DGV_Menu.Name = "DGV_Menu";
            this.DGV_Menu.RowHeadersWidth = 51;
            this.DGV_Menu.RowTemplate.Height = 24;
            this.DGV_Menu.Size = new System.Drawing.Size(753, 529);
            this.DGV_Menu.TabIndex = 1;
            this.DGV_Menu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChinhSua_CellClick);
            // 
            // Panel_ChinhSua
            // 
            this.Panel_ChinhSua.BackColor = System.Drawing.Color.Transparent;
            this.Panel_ChinhSua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panel_ChinhSua.Controls.Add(this.gBoxThemMoi);
            this.Panel_ChinhSua.Controls.Add(this.gBoxChinhSua);
            this.Panel_ChinhSua.Location = new System.Drawing.Point(873, 25);
            this.Panel_ChinhSua.Name = "Panel_ChinhSua";
            this.Panel_ChinhSua.Size = new System.Drawing.Size(538, 738);
            this.Panel_ChinhSua.TabIndex = 1;
            // 
            // gBoxChinhSua
            // 
            this.gBoxChinhSua.Controls.Add(this.txtGia);
            this.gBoxChinhSua.Controls.Add(this.btnCapNhat);
            this.gBoxChinhSua.Controls.Add(this.lblVND);
            this.gBoxChinhSua.Controls.Add(this.txtTenSP);
            this.gBoxChinhSua.Controls.Add(this.txtMaSP);
            this.gBoxChinhSua.Controls.Add(this.lblGia);
            this.gBoxChinhSua.Controls.Add(this.lblTenSP);
            this.gBoxChinhSua.Controls.Add(this.lblMaSP);
            this.gBoxChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxChinhSua.Location = new System.Drawing.Point(27, 27);
            this.gBoxChinhSua.Name = "gBoxChinhSua";
            this.gBoxChinhSua.Size = new System.Drawing.Size(482, 309);
            this.gBoxChinhSua.TabIndex = 0;
            this.gBoxChinhSua.TabStop = false;
            this.gBoxChinhSua.Text = "Chỉnh Sửa :";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Location = new System.Drawing.Point(6, 45);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(155, 25);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "Mã Sản Phẩm:";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Location = new System.Drawing.Point(6, 102);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(163, 25);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "Tên Sản Phẩm:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(6, 234);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(52, 25);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá:";
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(179, 42);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.ReadOnly = true;
            this.txtMaSP.Size = new System.Drawing.Size(168, 30);
            this.txtMaSP.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(179, 102);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(297, 88);
            this.txtTenSP.TabIndex = 4;
            // 
            // lblVND
            // 
            this.lblVND.AutoSize = true;
            this.lblVND.Location = new System.Drawing.Point(218, 234);
            this.lblVND.Name = "lblVND";
            this.lblVND.Size = new System.Drawing.Size(57, 25);
            this.lblVND.TabIndex = 6;
            this.lblVND.Text = "VNĐ";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(293, 222);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(171, 43);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // gBoxThemMoi
            // 
            this.gBoxThemMoi.Controls.Add(this.txtDonGia);
            this.gBoxThemMoi.Controls.Add(this.btnThem);
            this.gBoxThemMoi.Controls.Add(this.label1);
            this.gBoxThemMoi.Controls.Add(this.txtTen);
            this.gBoxThemMoi.Controls.Add(this.txtMa);
            this.gBoxThemMoi.Controls.Add(this.lblDonGia);
            this.gBoxThemMoi.Controls.Add(this.lblTen);
            this.gBoxThemMoi.Controls.Add(this.tztMaSP);
            this.gBoxThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxThemMoi.Location = new System.Drawing.Point(27, 396);
            this.gBoxThemMoi.Name = "gBoxThemMoi";
            this.gBoxThemMoi.Size = new System.Drawing.Size(482, 305);
            this.gBoxThemMoi.TabIndex = 1;
            this.gBoxThemMoi.TabStop = false;
            this.gBoxThemMoi.Text = "Thêm Mới:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(293, 222);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(171, 43);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "VNĐ";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(179, 102);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(297, 97);
            this.txtTen.TabIndex = 4;
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(179, 42);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(168, 30);
            this.txtMa.TabIndex = 3;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(6, 234);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(52, 25);
            this.lblDonGia.TabIndex = 2;
            this.lblDonGia.Text = "Giá:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(6, 102);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(163, 25);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên Sản Phẩm:";
            // 
            // tztMaSP
            // 
            this.tztMaSP.AutoSize = true;
            this.tztMaSP.Location = new System.Drawing.Point(6, 45);
            this.tztMaSP.Name = "tztMaSP";
            this.tztMaSP.Size = new System.Drawing.Size(155, 25);
            this.tztMaSP.TabIndex = 0;
            this.tztMaSP.Text = "Mã Sản Phẩm:";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.White;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(78, 656);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(148, 45);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm Mới";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.White;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(605, 656);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(148, 45);
            this.btnChinhSua.TabIndex = 3;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.White;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(333, 656);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(148, 45);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load Menu";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Column_MaSP
            // 
            this.Column_MaSP.DataPropertyName = "MaSP";
            this.Column_MaSP.HeaderText = "Mã Sản Phẩm";
            this.Column_MaSP.MinimumWidth = 6;
            this.Column_MaSP.Name = "Column_MaSP";
            this.Column_MaSP.ReadOnly = true;
            // 
            // ColumnTenSP
            // 
            this.ColumnTenSP.DataPropertyName = "TenSP";
            this.ColumnTenSP.HeaderText = "Tên Sản Phẩm";
            this.ColumnTenSP.MinimumWidth = 6;
            this.ColumnTenSP.Name = "ColumnTenSP";
            this.ColumnTenSP.ReadOnly = true;
            // 
            // ColumnGia
            // 
            this.ColumnGia.DataPropertyName = "Gia";
            this.ColumnGia.HeaderText = "Đơn Giá ";
            this.ColumnGia.MinimumWidth = 6;
            this.ColumnGia.Name = "ColumnGia";
            this.ColumnGia.ReadOnly = true;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(64, 228);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(148, 30);
            this.txtGia.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(64, 228);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(148, 30);
            this.txtDonGia.TabIndex = 9;
            // 
            // Form_DSSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1423, 775);
            this.Controls.Add(this.Panel_ChinhSua);
            this.Controls.Add(this.Panel_DS);
            this.MaximizeBox = false;
            this.Name = "Form_DSSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Sản Phẩm";
            this.Load += new System.EventHandler(this.Form_DSSP_Load);
            this.Panel_DS.ResumeLayout(false);
            this.Panel_DS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Menu)).EndInit();
            this.Panel_ChinhSua.ResumeLayout(false);
            this.gBoxChinhSua.ResumeLayout(false);
            this.gBoxChinhSua.PerformLayout();
            this.gBoxThemMoi.ResumeLayout(false);
            this.gBoxThemMoi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_DS;
        private System.Windows.Forms.DataGridView DGV_Menu;
        private System.Windows.Forms.Label lblDS;
        private System.Windows.Forms.Panel Panel_ChinhSua;
        private System.Windows.Forms.GroupBox gBoxChinhSua;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.GroupBox gBoxThemMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label tztMaSP;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Label lblVND;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtDonGia;
    }
}