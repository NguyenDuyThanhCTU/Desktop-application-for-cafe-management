namespace Project1
{
    partial class UserControl_DiemDanh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_DiemDanh));
            this.panel_TT = new System.Windows.Forms.Panel();
            this.DTP_Ngaylamviec = new System.Windows.Forms.DateTimePicker();
            this.lblNagy = new System.Windows.Forms.Label();
            this.btnDiemDanh = new System.Windows.Forms.Button();
            this.cbo_CaLV = new System.Windows.Forms.ComboBox();
            this.lbl_CaLV = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lbl_QLCLV = new System.Windows.Forms.Label();
            this.panel_Table = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnLuuTru = new System.Windows.Forms.Button();
            this.DGV_BangCLV = new System.Windows.Forms.DataGridView();
            this.ColMNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCaLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTableCLV = new System.Windows.Forms.Label();
            this.lblLanLT = new System.Windows.Forms.Label();
            this.lblLuutru = new System.Windows.Forms.Label();
            this.panel_TT.SuspendLayout();
            this.panel_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangCLV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TT
            // 
            this.panel_TT.BackColor = System.Drawing.Color.Transparent;
            this.panel_TT.Controls.Add(this.DTP_Ngaylamviec);
            this.panel_TT.Controls.Add(this.lblNagy);
            this.panel_TT.Controls.Add(this.btnDiemDanh);
            this.panel_TT.Controls.Add(this.cbo_CaLV);
            this.panel_TT.Controls.Add(this.lbl_CaLV);
            this.panel_TT.Controls.Add(this.txtHoTen);
            this.panel_TT.Controls.Add(this.lblTenNV);
            this.panel_TT.Controls.Add(this.txtMaNV);
            this.panel_TT.Controls.Add(this.lblMaNV);
            this.panel_TT.Controls.Add(this.lbl_QLCLV);
            this.panel_TT.Location = new System.Drawing.Point(0, 0);
            this.panel_TT.Name = "panel_TT";
            this.panel_TT.Size = new System.Drawing.Size(669, 846);
            this.panel_TT.TabIndex = 1;
            // 
            // DTP_Ngaylamviec
            // 
            this.DTP_Ngaylamviec.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Ngaylamviec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Ngaylamviec.Location = new System.Drawing.Point(212, 572);
            this.DTP_Ngaylamviec.Name = "DTP_Ngaylamviec";
            this.DTP_Ngaylamviec.Size = new System.Drawing.Size(417, 30);
            this.DTP_Ngaylamviec.TabIndex = 9;
            // 
            // lblNagy
            // 
            this.lblNagy.AutoSize = true;
            this.lblNagy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNagy.Location = new System.Drawing.Point(28, 573);
            this.lblNagy.Name = "lblNagy";
            this.lblNagy.Size = new System.Drawing.Size(165, 25);
            this.lblNagy.TabIndex = 8;
            this.lblNagy.Text = "Ngày Làm Việc:";
            // 
            // btnDiemDanh
            // 
            this.btnDiemDanh.BackColor = System.Drawing.Color.White;
            this.btnDiemDanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiemDanh.Location = new System.Drawing.Point(240, 673);
            this.btnDiemDanh.Name = "btnDiemDanh";
            this.btnDiemDanh.Size = new System.Drawing.Size(210, 50);
            this.btnDiemDanh.TabIndex = 7;
            this.btnDiemDanh.Text = "Điểm Danh";
            this.btnDiemDanh.UseVisualStyleBackColor = false;
            this.btnDiemDanh.Click += new System.EventHandler(this.btnDiemDanh_Click);
            // 
            // cbo_CaLV
            // 
            this.cbo_CaLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_CaLV.FormattingEnabled = true;
            this.cbo_CaLV.Items.AddRange(new object[] {
            "Buổi Sáng",
            "Buổi Chiều",
            "Buổi Tối"});
            this.cbo_CaLV.Location = new System.Drawing.Point(190, 454);
            this.cbo_CaLV.Name = "cbo_CaLV";
            this.cbo_CaLV.Size = new System.Drawing.Size(193, 33);
            this.cbo_CaLV.TabIndex = 6;
            // 
            // lbl_CaLV
            // 
            this.lbl_CaLV.AutoSize = true;
            this.lbl_CaLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CaLV.Location = new System.Drawing.Point(28, 457);
            this.lbl_CaLV.Name = "lbl_CaLV";
            this.lbl_CaLV.Size = new System.Drawing.Size(143, 25);
            this.lbl_CaLV.TabIndex = 5;
            this.lbl_CaLV.Text = "Ca Làm Việc:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.Location = new System.Drawing.Point(190, 342);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(417, 30);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.Location = new System.Drawing.Point(28, 344);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(123, 25);
            this.lblTenNV.TabIndex = 3;
            this.lblTenNV.Text = "Họ Và Tên:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(212, 237);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(417, 30);
            this.txtMaNV.TabIndex = 2;
            this.txtMaNV.TextChanged += new System.EventHandler(this.txtMaNV_TextChanged);
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNV.Location = new System.Drawing.Point(28, 240);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(156, 25);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // lbl_QLCLV
            // 
            this.lbl_QLCLV.AutoSize = true;
            this.lbl_QLCLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QLCLV.Location = new System.Drawing.Point(117, 108);
            this.lbl_QLCLV.Name = "lbl_QLCLV";
            this.lbl_QLCLV.Size = new System.Drawing.Size(429, 46);
            this.lbl_QLCLV.TabIndex = 0;
            this.lbl_QLCLV.Text = "Quản Lý Ca Làm Việc";
            // 
            // panel_Table
            // 
            this.panel_Table.BackColor = System.Drawing.Color.Transparent;
            this.panel_Table.Controls.Add(this.lblLuutru);
            this.panel_Table.Controls.Add(this.lblLanLT);
            this.panel_Table.Controls.Add(this.btnXuatFile);
            this.panel_Table.Controls.Add(this.btnLuuTru);
            this.panel_Table.Controls.Add(this.DGV_BangCLV);
            this.panel_Table.Controls.Add(this.lblTableCLV);
            this.panel_Table.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Table.Location = new System.Drawing.Point(665, 0);
            this.panel_Table.Name = "panel_Table";
            this.panel_Table.Size = new System.Drawing.Size(896, 849);
            this.panel_Table.TabIndex = 2;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(588, 627);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(210, 50);
            this.btnXuatFile.TabIndex = 3;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnLuuTru
            // 
            this.btnLuuTru.BackColor = System.Drawing.Color.White;
            this.btnLuuTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuTru.Location = new System.Drawing.Point(123, 627);
            this.btnLuuTru.Name = "btnLuuTru";
            this.btnLuuTru.Size = new System.Drawing.Size(210, 50);
            this.btnLuuTru.TabIndex = 2;
            this.btnLuuTru.Text = "Lưu Trữ";
            this.btnLuuTru.UseVisualStyleBackColor = false;
            this.btnLuuTru.Click += new System.EventHandler(this.btnLuuTru_Click);
            // 
            // DGV_BangCLV
            // 
            this.DGV_BangCLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_BangCLV.BackgroundColor = System.Drawing.Color.White;
            this.DGV_BangCLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BangCLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMNV,
            this.colTenNV,
            this.ColSDT,
            this.ColCaLV,
            this.ColNgay});
            this.DGV_BangCLV.Location = new System.Drawing.Point(32, 105);
            this.DGV_BangCLV.Name = "DGV_BangCLV";
            this.DGV_BangCLV.RowHeadersWidth = 51;
            this.DGV_BangCLV.RowTemplate.Height = 24;
            this.DGV_BangCLV.Size = new System.Drawing.Size(818, 461);
            this.DGV_BangCLV.TabIndex = 1;
            this.DGV_BangCLV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChinhSua_CellClick);
            // 
            // ColMNV
            // 
            this.ColMNV.HeaderText = "Mã Nhân Viên";
            this.ColMNV.MinimumWidth = 6;
            this.ColMNV.Name = "ColMNV";
            // 
            // colTenNV
            // 
            this.colTenNV.HeaderText = "Tên Nhân Viên";
            this.colTenNV.MinimumWidth = 6;
            this.colTenNV.Name = "colTenNV";
            // 
            // ColSDT
            // 
            this.ColSDT.HeaderText = "SDT";
            this.ColSDT.MinimumWidth = 6;
            this.ColSDT.Name = "ColSDT";
            // 
            // ColCaLV
            // 
            this.ColCaLV.HeaderText = "Ca Làm Việc";
            this.ColCaLV.MinimumWidth = 6;
            this.ColCaLV.Name = "ColCaLV";
            // 
            // ColNgay
            // 
            this.ColNgay.HeaderText = "Ngày Làm Việc";
            this.ColNgay.MinimumWidth = 6;
            this.ColNgay.Name = "ColNgay";
            // 
            // lblTableCLV
            // 
            this.lblTableCLV.AutoSize = true;
            this.lblTableCLV.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableCLV.Location = new System.Drawing.Point(251, 29);
            this.lblTableCLV.Name = "lblTableCLV";
            this.lblTableCLV.Size = new System.Drawing.Size(369, 46);
            this.lblTableCLV.TabIndex = 0;
            this.lblTableCLV.Text = "Bảng Ca Làm Việc";
            // 
            // lblLanLT
            // 
            this.lblLanLT.AutoSize = true;
            this.lblLanLT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanLT.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblLanLT.Location = new System.Drawing.Point(215, 749);
            this.lblLanLT.Name = "lblLanLT";
            this.lblLanLT.Size = new System.Drawing.Size(211, 25);
            this.lblLanLT.TabIndex = 4;
            this.lblLanLT.Text = "Lần lưu trữ gần nhất:";
            // 
            // lblLuutru
            // 
            this.lblLuutru.AutoSize = true;
            this.lblLuutru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuutru.Location = new System.Drawing.Point(466, 749);
            this.lblLuutru.Name = "lblLuutru";
            this.lblLuutru.Size = new System.Drawing.Size(187, 25);
            this.lblLuutru.TabIndex = 5;
            this.lblLuutru.Text = "Chưa lưu trữ lần nào";
            // 
            // UserControl_DiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel_Table);
            this.Controls.Add(this.panel_TT);
            this.Name = "UserControl_DiemDanh";
            this.Size = new System.Drawing.Size(1561, 849);
            this.Load += new System.EventHandler(this.UserControl_DiemDanh_Load);
            this.panel_TT.ResumeLayout(false);
            this.panel_TT.PerformLayout();
            this.panel_Table.ResumeLayout(false);
            this.panel_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangCLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TT;
        private System.Windows.Forms.DateTimePicker DTP_Ngaylamviec;
        private System.Windows.Forms.Label lblNagy;
        private System.Windows.Forms.Button btnDiemDanh;
        private System.Windows.Forms.ComboBox cbo_CaLV;
        private System.Windows.Forms.Label lbl_CaLV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.Label lbl_QLCLV;
        private System.Windows.Forms.Panel panel_Table;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnLuuTru;
        private System.Windows.Forms.DataGridView DGV_BangCLV;
        private System.Windows.Forms.Label lblTableCLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCaLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.Label lblLuutru;
        private System.Windows.Forms.Label lblLanLT;
    }
}
