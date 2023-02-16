namespace Project1
{
    partial class Form_ChiTietHD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ChiTietHD));
            this.lblHeading = new System.Windows.Forms.Label();
            this.gBoxChonNgay = new System.Windows.Forms.GroupBox();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.DTPChonNgay = new System.Windows.Forms.DateTimePicker();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.gBoxDSHD = new System.Windows.Forms.GroupBox();
            this.DGV_DSHD = new System.Windows.Forms.DataGridView();
            this.ColumnMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayLap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.lblXuatFile = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.GBoxChiTiet = new System.Windows.Forms.GroupBox();
            this.DGV_ChiTiet = new System.Windows.Forms.DataGridView();
            this.ColumnMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDTHD = new System.Windows.Forms.Label();
            this.txtTTHD = new System.Windows.Forms.TextBox();
            this.lblXF = new System.Windows.Forms.Label();
            this.btnXF = new System.Windows.Forms.Button();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.gBoxChonNgay.SuspendLayout();
            this.gBoxDSHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DSHD)).BeginInit();
            this.GBoxChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(587, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(320, 42);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Chi Tiết Hóa Đơn";
            // 
            // gBoxChonNgay
            // 
            this.gBoxChonNgay.BackColor = System.Drawing.Color.Transparent;
            this.gBoxChonNgay.Controls.Add(this.btnXem);
            this.gBoxChonNgay.Controls.Add(this.lblGhiChu);
            this.gBoxChonNgay.Controls.Add(this.DTPChonNgay);
            this.gBoxChonNgay.Controls.Add(this.lblChonNgay);
            this.gBoxChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxChonNgay.Location = new System.Drawing.Point(37, 73);
            this.gBoxChonNgay.Name = "gBoxChonNgay";
            this.gBoxChonNgay.Size = new System.Drawing.Size(767, 164);
            this.gBoxChonNgay.TabIndex = 1;
            this.gBoxChonNgay.TabStop = false;
            this.gBoxChonNgay.Text = "Ngày Lập Hóa Đơn:";
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNgay.Location = new System.Drawing.Point(17, 43);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(127, 25);
            this.lblChonNgay.TabIndex = 0;
            this.lblChonNgay.Text = "Chọn Ngày:";
            // 
            // DTPChonNgay
            // 
            this.DTPChonNgay.Location = new System.Drawing.Point(22, 85);
            this.DTPChonNgay.Name = "DTPChonNgay";
            this.DTPChonNgay.Size = new System.Drawing.Size(429, 30);
            this.DTPChonNgay.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.BackColor = System.Drawing.Color.Transparent;
            this.lblGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.Location = new System.Drawing.Point(510, 43);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(180, 20);
            this.lblGhiChu.TabIndex = 2;
            this.lblGhiChu.Text = "Xem HD trong ngày:";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(514, 75);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(189, 55);
            this.btnXem.TabIndex = 3;
            this.btnXem.Text = "Xem Hóa Đơn";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // gBoxDSHD
            // 
            this.gBoxDSHD.BackColor = System.Drawing.Color.Transparent;
            this.gBoxDSHD.Controls.Add(this.btnXuatFile);
            this.gBoxDSHD.Controls.Add(this.lblXuatFile);
            this.gBoxDSHD.Controls.Add(this.txtDoanhThu);
            this.gBoxDSHD.Controls.Add(this.lblTongTien);
            this.gBoxDSHD.Controls.Add(this.DGV_DSHD);
            this.gBoxDSHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxDSHD.Location = new System.Drawing.Point(37, 265);
            this.gBoxDSHD.Name = "gBoxDSHD";
            this.gBoxDSHD.Size = new System.Drawing.Size(767, 430);
            this.gBoxDSHD.TabIndex = 2;
            this.gBoxDSHD.TabStop = false;
            this.gBoxDSHD.Text = "Các Hóa Đơn Trong Ngày:";
            // 
            // DGV_DSHD
            // 
            this.DGV_DSHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DSHD.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_DSHD.BackgroundColor = System.Drawing.Color.White;
            this.DGV_DSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaHD,
            this.ColumnMaNV,
            this.ColumnNgayLap,
            this.ColumnTongTien});
            this.DGV_DSHD.Location = new System.Drawing.Point(32, 121);
            this.DGV_DSHD.Name = "DGV_DSHD";
            this.DGV_DSHD.RowHeadersWidth = 51;
            this.DGV_DSHD.RowTemplate.Height = 24;
            this.DGV_DSHD.Size = new System.Drawing.Size(698, 291);
            this.DGV_DSHD.TabIndex = 0;
            this.DGV_DSHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ChiTiet_CellClick);
            // 
            // ColumnMaHD
            // 
            this.ColumnMaHD.DataPropertyName = "MaHD";
            this.ColumnMaHD.HeaderText = "Mã Hóa Đơn";
            this.ColumnMaHD.MinimumWidth = 6;
            this.ColumnMaHD.Name = "ColumnMaHD";
            this.ColumnMaHD.ReadOnly = true;
            // 
            // ColumnMaNV
            // 
            this.ColumnMaNV.DataPropertyName = "MaNV";
            this.ColumnMaNV.HeaderText = "Mã Nhân Viên";
            this.ColumnMaNV.MinimumWidth = 6;
            this.ColumnMaNV.Name = "ColumnMaNV";
            this.ColumnMaNV.ReadOnly = true;
            // 
            // ColumnNgayLap
            // 
            this.ColumnNgayLap.DataPropertyName = "NgayLap";
            this.ColumnNgayLap.HeaderText = "Ngày Lập Hóa Đơn";
            this.ColumnNgayLap.MinimumWidth = 6;
            this.ColumnNgayLap.Name = "ColumnNgayLap";
            this.ColumnNgayLap.ReadOnly = true;
            // 
            // ColumnTongTien
            // 
            this.ColumnTongTien.DataPropertyName = "DonGia";
            this.ColumnTongTien.HeaderText = "Tổng Tiền";
            this.ColumnTongTien.MinimumWidth = 6;
            this.ColumnTongTien.Name = "ColumnTongTien";
            this.ColumnTongTien.ReadOnly = true;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(27, 38);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(301, 25);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng Doanh Thu Trong Ngày:";
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Location = new System.Drawing.Point(32, 76);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.ReadOnly = true;
            this.txtDoanhThu.Size = new System.Drawing.Size(330, 30);
            this.txtDoanhThu.TabIndex = 2;
            // 
            // lblXuatFile
            // 
            this.lblXuatFile.AutoSize = true;
            this.lblXuatFile.Location = new System.Drawing.Point(447, 50);
            this.lblXuatFile.Name = "lblXuatFile";
            this.lblXuatFile.Size = new System.Drawing.Size(95, 25);
            this.lblXuatFile.TabIndex = 3;
            this.lblXuatFile.Text = "Xuất File:";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(565, 38);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(165, 48);
            this.btnXuatFile.TabIndex = 4;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // GBoxChiTiet
            // 
            this.GBoxChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.GBoxChiTiet.Controls.Add(this.txtTen);
            this.GBoxChiTiet.Controls.Add(this.lblTen);
            this.GBoxChiTiet.Controls.Add(this.btnXF);
            this.GBoxChiTiet.Controls.Add(this.lblXF);
            this.GBoxChiTiet.Controls.Add(this.txtTTHD);
            this.GBoxChiTiet.Controls.Add(this.lblDTHD);
            this.GBoxChiTiet.Controls.Add(this.DGV_ChiTiet);
            this.GBoxChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBoxChiTiet.Location = new System.Drawing.Point(810, 73);
            this.GBoxChiTiet.Name = "GBoxChiTiet";
            this.GBoxChiTiet.Size = new System.Drawing.Size(732, 622);
            this.GBoxChiTiet.TabIndex = 3;
            this.GBoxChiTiet.TabStop = false;
            this.GBoxChiTiet.Text = "Chi Tiết Của Hóa Đơn:";
            // 
            // DGV_ChiTiet
            // 
            this.DGV_ChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_ChiTiet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_ChiTiet.BackgroundColor = System.Drawing.Color.White;
            this.DGV_ChiTiet.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_ChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaSP,
            this.ColumnTenSP,
            this.ColumnSoLuong,
            this.ColumnGia});
            this.DGV_ChiTiet.Location = new System.Drawing.Point(23, 212);
            this.DGV_ChiTiet.Name = "DGV_ChiTiet";
            this.DGV_ChiTiet.RowHeadersWidth = 51;
            this.DGV_ChiTiet.RowTemplate.Height = 24;
            this.DGV_ChiTiet.Size = new System.Drawing.Size(685, 392);
            this.DGV_ChiTiet.TabIndex = 0;
            // 
            // ColumnMaSP
            // 
            this.ColumnMaSP.DataPropertyName = "MaSP";
            this.ColumnMaSP.HeaderText = "Mã Sản Phẩm";
            this.ColumnMaSP.MinimumWidth = 6;
            this.ColumnMaSP.Name = "ColumnMaSP";
            this.ColumnMaSP.ReadOnly = true;
            // 
            // ColumnTenSP
            // 
            this.ColumnTenSP.DataPropertyName = "TenSP";
            this.ColumnTenSP.HeaderText = "Tên Sản Phẩm";
            this.ColumnTenSP.MinimumWidth = 6;
            this.ColumnTenSP.Name = "ColumnTenSP";
            this.ColumnTenSP.ReadOnly = true;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.DataPropertyName = "SoLuong";
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.ReadOnly = true;
            // 
            // ColumnGia
            // 
            this.ColumnGia.DataPropertyName = "Gia";
            this.ColumnGia.HeaderText = "Đơn Giá";
            this.ColumnGia.MinimumWidth = 6;
            this.ColumnGia.Name = "ColumnGia";
            this.ColumnGia.ReadOnly = true;
            // 
            // lblDTHD
            // 
            this.lblDTHD.AutoSize = true;
            this.lblDTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTHD.Location = new System.Drawing.Point(18, 43);
            this.lblDTHD.Name = "lblDTHD";
            this.lblDTHD.Size = new System.Drawing.Size(254, 25);
            this.lblDTHD.TabIndex = 1;
            this.lblDTHD.Text = "Tổng Tiền Của Hóa Đơn:";
            // 
            // txtTTHD
            // 
            this.txtTTHD.Location = new System.Drawing.Point(23, 87);
            this.txtTTHD.Name = "txtTTHD";
            this.txtTTHD.ReadOnly = true;
            this.txtTTHD.Size = new System.Drawing.Size(288, 30);
            this.txtTTHD.TabIndex = 2;
            // 
            // lblXF
            // 
            this.lblXF.AutoSize = true;
            this.lblXF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXF.Location = new System.Drawing.Point(381, 43);
            this.lblXF.Name = "lblXF";
            this.lblXF.Size = new System.Drawing.Size(105, 25);
            this.lblXF.TabIndex = 3;
            this.lblXF.Text = "Xuất File:";
            // 
            // btnXF
            // 
            this.btnXF.BackColor = System.Drawing.Color.White;
            this.btnXF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXF.Location = new System.Drawing.Point(499, 69);
            this.btnXF.Name = "btnXF";
            this.btnXF.Size = new System.Drawing.Size(165, 48);
            this.btnXF.TabIndex = 4;
            this.btnXF.Text = "Xuất File Excel";
            this.btnXF.UseVisualStyleBackColor = false;
            this.btnXF.Click += new System.EventHandler(this.btnXF_Click);
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(18, 153);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(180, 25);
            this.lblTen.TabIndex = 5;
            this.lblTen.Text = "Người Thực Hiện:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(227, 148);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(437, 30);
            this.txtTen.TabIndex = 6;
            // 
            // Form_ChiTietHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1554, 738);
            this.Controls.Add(this.GBoxChiTiet);
            this.Controls.Add(this.gBoxDSHD);
            this.Controls.Add(this.gBoxChonNgay);
            this.Controls.Add(this.lblHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_ChiTietHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.Form_ChiTietHD_Load);
            this.gBoxChonNgay.ResumeLayout(false);
            this.gBoxChonNgay.PerformLayout();
            this.gBoxDSHD.ResumeLayout(false);
            this.gBoxDSHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DSHD)).EndInit();
            this.GBoxChiTiet.ResumeLayout(false);
            this.GBoxChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.GroupBox gBoxChonNgay;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.DateTimePicker DTPChonNgay;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.GroupBox gBoxDSHD;
        private System.Windows.Forms.DataGridView DGV_DSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayLap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTongTien;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label lblXuatFile;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox GBoxChiTiet;
        private System.Windows.Forms.Button btnXF;
        private System.Windows.Forms.Label lblXF;
        private System.Windows.Forms.TextBox txtTTHD;
        private System.Windows.Forms.Label lblDTHD;
        private System.Windows.Forms.DataGridView DGV_ChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
    }
}