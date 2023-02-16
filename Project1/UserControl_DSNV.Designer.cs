namespace Project1
{
    partial class UserControl_DSNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_DSNV));
            this.panelContaint = new System.Windows.Forms.Panel();
            this.lblChuThich2 = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.cmbHienThi = new System.Windows.Forms.ComboBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.DGV_BangDS = new System.Windows.Forms.DataGridView();
            this.ColumnMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblChuThich1 = new System.Windows.Forms.Label();
            this.panelContaint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContaint
            // 
            this.panelContaint.BackColor = System.Drawing.Color.Transparent;
            this.panelContaint.Controls.Add(this.lblChuThich1);
            this.panelContaint.Controls.Add(this.lblChuThich2);
            this.panelContaint.Controls.Add(this.btnXuatFile);
            this.panelContaint.Controls.Add(this.btnChinhSua);
            this.panelContaint.Controls.Add(this.btnXemDS);
            this.panelContaint.Controls.Add(this.cmbHienThi);
            this.panelContaint.Controls.Add(this.lblHienThi);
            this.panelContaint.Controls.Add(this.DGV_BangDS);
            this.panelContaint.Controls.Add(this.lblHeading);
            this.panelContaint.Location = new System.Drawing.Point(0, 0);
            this.panelContaint.Name = "panelContaint";
            this.panelContaint.Size = new System.Drawing.Size(1561, 849);
            this.panelContaint.TabIndex = 0;
            // 
            // lblChuThich2
            // 
            this.lblChuThich2.AutoSize = true;
            this.lblChuThich2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuThich2.Location = new System.Drawing.Point(1317, 780);
            this.lblChuThich2.Name = "lblChuThich2";
            this.lblChuThich2.Size = new System.Drawing.Size(210, 25);
            this.lblChuThich2.TabIndex = 8;
            this.lblChuThich2.Text = "True(Nam), False(Nữ).";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(997, 688);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(190, 55);
            this.btnXuatFile.TabIndex = 7;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.White;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(369, 688);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(190, 55);
            this.btnChinhSua.TabIndex = 6;
            this.btnChinhSua.Text = "Chỉnh Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnXemDS
            // 
            this.btnXemDS.BackColor = System.Drawing.Color.White;
            this.btnXemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDS.Location = new System.Drawing.Point(923, 90);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(208, 52);
            this.btnXemDS.TabIndex = 4;
            this.btnXemDS.Text = "Xem Danh Sách";
            this.btnXemDS.UseVisualStyleBackColor = false;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // cmbHienThi
            // 
            this.cmbHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHienThi.FormattingEnabled = true;
            this.cmbHienThi.Items.AddRange(new object[] {
            "Tất Cả",
            "Phục Vụ",
            "Pha Chế",
            "Thu Ngân",
            "Bảo Vệ"});
            this.cmbHienThi.Location = new System.Drawing.Point(580, 101);
            this.cmbHienThi.Name = "cmbHienThi";
            this.cmbHienThi.Size = new System.Drawing.Size(254, 33);
            this.cmbHienThi.TabIndex = 3;
            // 
            // lblHienThi
            // 
            this.lblHienThi.AutoSize = true;
            this.lblHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHienThi.Location = new System.Drawing.Point(436, 109);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(103, 25);
            this.lblHienThi.TabIndex = 2;
            this.lblHienThi.Text = "Chức Vụ:";
            // 
            // DGV_BangDS
            // 
            this.DGV_BangDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_BangDS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.DGV_BangDS.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_BangDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_BangDS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMa,
            this.ColumnTen,
            this.ColumnGioiTinh,
            this.ColumnSDT,
            this.ColumnChucVu,
            this.ColumnDiaChi});
            this.DGV_BangDS.Location = new System.Drawing.Point(96, 189);
            this.DGV_BangDS.Name = "DGV_BangDS";
            this.DGV_BangDS.RowHeadersWidth = 51;
            this.DGV_BangDS.RowTemplate.Height = 24;
            this.DGV_BangDS.Size = new System.Drawing.Size(1353, 474);
            this.DGV_BangDS.TabIndex = 1;
            // 
            // ColumnMa
            // 
            this.ColumnMa.DataPropertyName = "MaNV";
            this.ColumnMa.HeaderText = "Mã Nhân Viên";
            this.ColumnMa.MinimumWidth = 6;
            this.ColumnMa.Name = "ColumnMa";
            this.ColumnMa.ReadOnly = true;
            // 
            // ColumnTen
            // 
            this.ColumnTen.DataPropertyName = "TenNV";
            this.ColumnTen.HeaderText = "Tên Nhân Viên";
            this.ColumnTen.MinimumWidth = 6;
            this.ColumnTen.Name = "ColumnTen";
            this.ColumnTen.ReadOnly = true;
            // 
            // ColumnGioiTinh
            // 
            this.ColumnGioiTinh.DataPropertyName = "GT";
            this.ColumnGioiTinh.HeaderText = "Giới Tính";
            this.ColumnGioiTinh.MinimumWidth = 6;
            this.ColumnGioiTinh.Name = "ColumnGioiTinh";
            this.ColumnGioiTinh.ReadOnly = true;
            // 
            // ColumnSDT
            // 
            this.ColumnSDT.DataPropertyName = "SDT";
            this.ColumnSDT.HeaderText = "SĐT";
            this.ColumnSDT.MinimumWidth = 6;
            this.ColumnSDT.Name = "ColumnSDT";
            this.ColumnSDT.ReadOnly = true;
            // 
            // ColumnChucVu
            // 
            this.ColumnChucVu.DataPropertyName = "ChucVu";
            this.ColumnChucVu.HeaderText = "Chức Vụ";
            this.ColumnChucVu.MinimumWidth = 6;
            this.ColumnChucVu.Name = "ColumnChucVu";
            this.ColumnChucVu.ReadOnly = true;
            // 
            // ColumnDiaChi
            // 
            this.ColumnDiaChi.DataPropertyName = "DiaChi";
            this.ColumnDiaChi.HeaderText = "Địa Chỉ";
            this.ColumnDiaChi.MinimumWidth = 6;
            this.ColumnDiaChi.Name = "ColumnDiaChi";
            this.ColumnDiaChi.ReadOnly = true;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(543, 23);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(408, 42);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Danh Sách Nhân Viên";
            // 
            // lblChuThich1
            // 
            this.lblChuThich1.AutoSize = true;
            this.lblChuThich1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuThich1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblChuThich1.Location = new System.Drawing.Point(1202, 780);
            this.lblChuThich1.Name = "lblChuThich1";
            this.lblChuThich1.Size = new System.Drawing.Size(109, 25);
            this.lblChuThich1.TabIndex = 9;
            this.lblChuThich1.Text = "Chú Thích:";
            // 
            // UserControl_DSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelContaint);
            this.Name = "UserControl_DSNV";
            this.Size = new System.Drawing.Size(1561, 849);
            this.Load += new System.EventHandler(this.UserControl_DSNV_Load);
            this.panelContaint.ResumeLayout(false);
            this.panelContaint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContaint;
        private System.Windows.Forms.DataGridView DGV_BangDS;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmbHienThi;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDiaChi;
        private System.Windows.Forms.Label lblChuThich2;
        private System.Windows.Forms.Label lblChuThich1;
    }
}
