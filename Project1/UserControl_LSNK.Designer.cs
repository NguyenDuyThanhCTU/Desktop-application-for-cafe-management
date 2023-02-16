namespace Project1
{
    partial class UserControl_LSNK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_LSNK));
            this.panelContain = new System.Windows.Forms.Panel();
            this.gBoxContain = new System.Windows.Forms.GroupBox();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.lblXuatFile = new System.Windows.Forms.Label();
            this.DGV_LSNhapKho = new System.Windows.Forms.DataGridView();
            this.txtNgay = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblVP = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.gBoxSearch = new System.Windows.Forms.GroupBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.lblGoiY = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.DTP_ChonNgay = new System.Windows.Forms.DateTimePicker();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Column_MaVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContain.SuspendLayout();
            this.gBoxContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LSNhapKho)).BeginInit();
            this.gBoxSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.Color.Transparent;
            this.panelContain.Controls.Add(this.gBoxContain);
            this.panelContain.Controls.Add(this.gBoxSearch);
            this.panelContain.Controls.Add(this.lblTitle);
            this.panelContain.Location = new System.Drawing.Point(0, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1166, 851);
            this.panelContain.TabIndex = 0;
            // 
            // gBoxContain
            // 
            this.gBoxContain.Controls.Add(this.btnXuatFile);
            this.gBoxContain.Controls.Add(this.lblXuatFile);
            this.gBoxContain.Controls.Add(this.DGV_LSNhapKho);
            this.gBoxContain.Controls.Add(this.txtNgay);
            this.gBoxContain.Controls.Add(this.txtTen);
            this.gBoxContain.Controls.Add(this.txtMa);
            this.gBoxContain.Controls.Add(this.lblVP);
            this.gBoxContain.Controls.Add(this.lblNgay);
            this.gBoxContain.Controls.Add(this.lblTen);
            this.gBoxContain.Controls.Add(this.lblMa);
            this.gBoxContain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxContain.Location = new System.Drawing.Point(53, 266);
            this.gBoxContain.Name = "gBoxContain";
            this.gBoxContain.Size = new System.Drawing.Size(1059, 513);
            this.gBoxContain.TabIndex = 14;
            this.gBoxContain.TabStop = false;
            this.gBoxContain.Text = "Lịch Sử Nhập Kho Ngày:";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Location = new System.Drawing.Point(837, 150);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(186, 48);
            this.btnXuatFile.TabIndex = 18;
            this.btnXuatFile.Text = "Xuất File ";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // lblXuatFile
            // 
            this.lblXuatFile.AutoSize = true;
            this.lblXuatFile.Location = new System.Drawing.Point(592, 162);
            this.lblXuatFile.Name = "lblXuatFile";
            this.lblXuatFile.Size = new System.Drawing.Size(222, 25);
            this.lblXuatFile.TabIndex = 17;
            this.lblXuatFile.Text = "Chọn Xuất File Excel:";
            // 
            // DGV_LSNhapKho
            // 
            this.DGV_LSNhapKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_LSNhapKho.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_LSNhapKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LSNhapKho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MaVP,
            this.ColumnNameVP,
            this.ColumnSoLuong});
            this.DGV_LSNhapKho.Location = new System.Drawing.Point(38, 237);
            this.DGV_LSNhapKho.Name = "DGV_LSNhapKho";
            this.DGV_LSNhapKho.RowHeadersWidth = 51;
            this.DGV_LSNhapKho.RowTemplate.Height = 24;
            this.DGV_LSNhapKho.Size = new System.Drawing.Size(985, 258);
            this.DGV_LSNhapKho.TabIndex = 16;
            // 
            // txtNgay
            // 
            this.txtNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgay.Location = new System.Drawing.Point(597, 104);
            this.txtNgay.Name = "txtNgay";
            this.txtNgay.ReadOnly = true;
            this.txtNgay.Size = new System.Drawing.Size(426, 30);
            this.txtNgay.TabIndex = 15;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(220, 124);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(326, 30);
            this.txtTen.TabIndex = 14;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(220, 65);
            this.txtMa.Name = "txtMa";
            this.txtMa.ReadOnly = true;
            this.txtMa.Size = new System.Drawing.Size(190, 30);
            this.txtMa.TabIndex = 13;
            // 
            // lblVP
            // 
            this.lblVP.AutoSize = true;
            this.lblVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVP.Location = new System.Drawing.Point(33, 193);
            this.lblVP.Name = "lblVP";
            this.lblVP.Size = new System.Drawing.Size(248, 25);
            this.lblVP.TabIndex = 12;
            this.lblVP.Text = "Các Vật Phẩm Đã Nhập:";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(592, 65);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(174, 25);
            this.lblNgay.TabIndex = 11;
            this.lblNgay.Text = "Ngày Thực Hiện:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(33, 129);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(164, 25);
            this.lblTen.TabIndex = 10;
            this.lblTen.Text = "Tên Nhân Viên:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(33, 72);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(156, 25);
            this.lblMa.TabIndex = 9;
            this.lblMa.Text = "Mã Nhân Viên:";
            // 
            // gBoxSearch
            // 
            this.gBoxSearch.Controls.Add(this.txtMaNV);
            this.gBoxSearch.Controls.Add(this.lblMaNV);
            this.gBoxSearch.Controls.Add(this.lblChonNgay);
            this.gBoxSearch.Controls.Add(this.lblGoiY);
            this.gBoxSearch.Controls.Add(this.btnXem);
            this.gBoxSearch.Controls.Add(this.DTP_ChonNgay);
            this.gBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gBoxSearch.Location = new System.Drawing.Point(53, 83);
            this.gBoxSearch.Name = "gBoxSearch";
            this.gBoxSearch.Size = new System.Drawing.Size(1059, 167);
            this.gBoxSearch.TabIndex = 13;
            this.gBoxSearch.TabStop = false;
            this.gBoxSearch.Text = "Chọn Xem Lịch Sử Nhập Kho:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(201, 40);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(215, 30);
            this.txtMaNV.TabIndex = 14;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Location = new System.Drawing.Point(33, 45);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(156, 25);
            this.lblMaNV.TabIndex = 13;
            this.lblMaNV.Text = "Mã Nhân Viên:";
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNgay.Location = new System.Drawing.Point(33, 108);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(127, 25);
            this.lblChonNgay.TabIndex = 10;
            this.lblChonNgay.Text = "Chọn Ngày:";
            // 
            // lblGoiY
            // 
            this.lblGoiY.AutoSize = true;
            this.lblGoiY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoiY.Location = new System.Drawing.Point(821, 52);
            this.lblGoiY.Name = "lblGoiY";
            this.lblGoiY.Size = new System.Drawing.Size(202, 18);
            this.lblGoiY.TabIndex = 9;
            this.lblGoiY.Text = "Xem các lịch sử nhập kho";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(837, 91);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(170, 42);
            this.btnXem.TabIndex = 12;
            this.btnXem.Text = "Xem Lịch Sử";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // DTP_ChonNgay
            // 
            this.DTP_ChonNgay.Location = new System.Drawing.Point(175, 103);
            this.DTP_ChonNgay.Name = "DTP_ChonNgay";
            this.DTP_ChonNgay.Size = new System.Drawing.Size(491, 30);
            this.DTP_ChonNgay.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(405, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(336, 42);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lịch Sử Nhập Kho";
            // 
            // Column_MaVP
            // 
            this.Column_MaVP.DataPropertyName = "MaVP";
            this.Column_MaVP.HeaderText = "Mã Vật Phẩm";
            this.Column_MaVP.MinimumWidth = 6;
            this.Column_MaVP.Name = "Column_MaVP";
            this.Column_MaVP.ReadOnly = true;
            // 
            // ColumnNameVP
            // 
            this.ColumnNameVP.DataPropertyName = "TenVP";
            this.ColumnNameVP.HeaderText = "Tên Vật Phẩm";
            this.ColumnNameVP.MinimumWidth = 6;
            this.ColumnNameVP.Name = "ColumnNameVP";
            this.ColumnNameVP.ReadOnly = true;
            // 
            // ColumnSoLuong
            // 
            this.ColumnSoLuong.DataPropertyName = "SoLuong";
            this.ColumnSoLuong.HeaderText = "Số Lượng";
            this.ColumnSoLuong.MinimumWidth = 6;
            this.ColumnSoLuong.Name = "ColumnSoLuong";
            this.ColumnSoLuong.ReadOnly = true;
            // 
            // UserControl_LSNK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelContain);
            this.Name = "UserControl_LSNK";
            this.Size = new System.Drawing.Size(1166, 851);
            this.Load += new System.EventHandler(this.UserControl_LSNK_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            this.gBoxContain.ResumeLayout(false);
            this.gBoxContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LSNhapKho)).EndInit();
            this.gBoxSearch.ResumeLayout(false);
            this.gBoxSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker DTP_ChonNgay;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.Label lblGoiY;
        private System.Windows.Forms.GroupBox gBoxSearch;
        private System.Windows.Forms.GroupBox gBoxContain;
        private System.Windows.Forms.TextBox txtNgay;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblVP;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.DataGridView DGV_LSNhapKho;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Label lblXuatFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MaVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSoLuong;
    }
}
