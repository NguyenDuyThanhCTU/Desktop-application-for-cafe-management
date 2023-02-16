namespace Project1
{
    partial class Xuat_NhapKho_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xuat_NhapKho_Form));
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.PanelTT = new System.Windows.Forms.Panel();
            this.grBCV = new System.Windows.Forms.GroupBox();
            this.rbtnNK = new System.Windows.Forms.RadioButton();
            this.rbtnXK = new System.Windows.Forms.RadioButton();
            this.DTPNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNgay = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.PanelSuaDoi = new System.Windows.Forms.Panel();
            this.txtMaVP = new System.Windows.Forms.TextBox();
            this.lblMaVP = new System.Windows.Forms.Label();
            this.cmbPhanLoai = new System.Windows.Forms.ComboBox();
            this.numUpDow_SL = new System.Windows.Forms.NumericUpDown();
            this.lblPhanLoai = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtTenVP = new System.Windows.Forms.TextBox();
            this.lblTenVP = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.PanelTT.SuspendLayout();
            this.grBCV.SuspendLayout();
            this.PanelSuaDoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDow_SL)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.White;
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(659, 589);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(169, 45);
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Window;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1092, 589);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(169, 45);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy Bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.Window;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(226, 589);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(169, 45);
            this.btnLamMoi.TabIndex = 19;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // PanelTT
            // 
            this.PanelTT.BackColor = System.Drawing.Color.Transparent;
            this.PanelTT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTT.Controls.Add(this.grBCV);
            this.PanelTT.Controls.Add(this.DTPNgay);
            this.PanelTT.Controls.Add(this.lblNgay);
            this.PanelTT.Controls.Add(this.txtTen);
            this.PanelTT.Controls.Add(this.lblTen);
            this.PanelTT.Controls.Add(this.txtMa);
            this.PanelTT.Controls.Add(this.lblMa);
            this.PanelTT.Location = new System.Drawing.Point(43, 117);
            this.PanelTT.Name = "PanelTT";
            this.PanelTT.Size = new System.Drawing.Size(698, 450);
            this.PanelTT.TabIndex = 23;
            // 
            // grBCV
            // 
            this.grBCV.BackColor = System.Drawing.Color.White;
            this.grBCV.Controls.Add(this.rbtnNK);
            this.grBCV.Controls.Add(this.rbtnXK);
            this.grBCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBCV.Location = new System.Drawing.Point(109, 296);
            this.grBCV.Name = "grBCV";
            this.grBCV.Size = new System.Drawing.Size(517, 119);
            this.grBCV.TabIndex = 22;
            this.grBCV.TabStop = false;
            this.grBCV.Text = "Công Việc:";
            // 
            // rbtnNK
            // 
            this.rbtnNK.AutoSize = true;
            this.rbtnNK.Location = new System.Drawing.Point(324, 57);
            this.rbtnNK.Name = "rbtnNK";
            this.rbtnNK.Size = new System.Drawing.Size(121, 29);
            this.rbtnNK.TabIndex = 1;
            this.rbtnNK.Text = "Nhập Kho";
            this.rbtnNK.UseVisualStyleBackColor = true;
            this.rbtnNK.CheckedChanged += new System.EventHandler(this.rbtnNK_CheckedChanged);
            // 
            // rbtnXK
            // 
            this.rbtnXK.AutoSize = true;
            this.rbtnXK.Location = new System.Drawing.Point(77, 57);
            this.rbtnXK.Name = "rbtnXK";
            this.rbtnXK.Size = new System.Drawing.Size(115, 29);
            this.rbtnXK.TabIndex = 0;
            this.rbtnXK.Text = "Xuất Kho";
            this.rbtnXK.UseVisualStyleBackColor = true;
            this.rbtnXK.CheckedChanged += new System.EventHandler(this.rbtnXK_CheckedChanged);
            // 
            // DTPNgay
            // 
            this.DTPNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTPNgay.Location = new System.Drawing.Point(242, 197);
            this.DTPNgay.Name = "DTPNgay";
            this.DTPNgay.Size = new System.Drawing.Size(411, 30);
            this.DTPNgay.TabIndex = 21;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.BackColor = System.Drawing.Color.Transparent;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(46, 202);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(174, 25);
            this.lblNgay.TabIndex = 20;
            this.lblNgay.Text = "Ngày Thực Hiện:";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(242, 117);
            this.txtTen.Name = "txtTen";
            this.txtTen.ReadOnly = true;
            this.txtTen.Size = new System.Drawing.Size(411, 30);
            this.txtTen.TabIndex = 19;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(46, 122);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(164, 25);
            this.lblTen.TabIndex = 18;
            this.lblTen.Text = "Tên Nhân Viên:";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(242, 36);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(295, 30);
            this.txtMa.TabIndex = 17;
            this.txtMa.TextChanged += new System.EventHandler(this.txtMa_TextChanged);
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.BackColor = System.Drawing.Color.Transparent;
            this.lblMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMa.Location = new System.Drawing.Point(46, 39);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(156, 25);
            this.lblMa.TabIndex = 16;
            this.lblMa.Text = "Mã Nhân Viên:";
            // 
            // PanelSuaDoi
            // 
            this.PanelSuaDoi.BackColor = System.Drawing.Color.Transparent;
            this.PanelSuaDoi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSuaDoi.Controls.Add(this.txtMaVP);
            this.PanelSuaDoi.Controls.Add(this.lblMaVP);
            this.PanelSuaDoi.Controls.Add(this.cmbPhanLoai);
            this.PanelSuaDoi.Controls.Add(this.numUpDow_SL);
            this.PanelSuaDoi.Controls.Add(this.lblPhanLoai);
            this.PanelSuaDoi.Controls.Add(this.lblSoLuong);
            this.PanelSuaDoi.Controls.Add(this.txtTenVP);
            this.PanelSuaDoi.Controls.Add(this.lblTenVP);
            this.PanelSuaDoi.Location = new System.Drawing.Point(798, 117);
            this.PanelSuaDoi.Name = "PanelSuaDoi";
            this.PanelSuaDoi.Size = new System.Drawing.Size(604, 450);
            this.PanelSuaDoi.TabIndex = 24;
            // 
            // txtMaVP
            // 
            this.txtMaVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaVP.Location = new System.Drawing.Point(216, 300);
            this.txtMaVP.Name = "txtMaVP";
            this.txtMaVP.Size = new System.Drawing.Size(194, 30);
            this.txtMaVP.TabIndex = 30;
            this.txtMaVP.TextChanged += new System.EventHandler(this.txtMaVP_TextChanged);
            // 
            // lblMaVP
            // 
            this.lblMaVP.AutoSize = true;
            this.lblMaVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaVP.Location = new System.Drawing.Point(14, 305);
            this.lblMaVP.Name = "lblMaVP";
            this.lblMaVP.Size = new System.Drawing.Size(149, 25);
            this.lblMaVP.TabIndex = 29;
            this.lblMaVP.Text = "Mã Vật Phẩm:";
            // 
            // cmbPhanLoai
            // 
            this.cmbPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPhanLoai.FormattingEnabled = true;
            this.cmbPhanLoai.Items.AddRange(new object[] {
            "Nguyên Liệu",
            "Dụng Cụ Pha Chế",
            "Dụng Cụ Đựng Thành Phẩm"});
            this.cmbPhanLoai.Location = new System.Drawing.Point(216, 112);
            this.cmbPhanLoai.Name = "cmbPhanLoai";
            this.cmbPhanLoai.Size = new System.Drawing.Size(323, 33);
            this.cmbPhanLoai.TabIndex = 28;
            // 
            // numUpDow_SL
            // 
            this.numUpDow_SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUpDow_SL.Location = new System.Drawing.Point(216, 197);
            this.numUpDow_SL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDow_SL.Name = "numUpDow_SL";
            this.numUpDow_SL.Size = new System.Drawing.Size(120, 30);
            this.numUpDow_SL.TabIndex = 27;
            this.numUpDow_SL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPhanLoai
            // 
            this.lblPhanLoai.AutoSize = true;
            this.lblPhanLoai.BackColor = System.Drawing.Color.Transparent;
            this.lblPhanLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhanLoai.Location = new System.Drawing.Point(14, 120);
            this.lblPhanLoai.Name = "lblPhanLoai";
            this.lblPhanLoai.Size = new System.Drawing.Size(116, 25);
            this.lblPhanLoai.TabIndex = 26;
            this.lblPhanLoai.Text = "Phân Loại:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.lblSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(14, 202);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(112, 25);
            this.lblSoLuong.TabIndex = 25;
            this.lblSoLuong.Text = "Số Lượng:";
            // 
            // txtTenVP
            // 
            this.txtTenVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenVP.Location = new System.Drawing.Point(216, 36);
            this.txtTenVP.Name = "txtTenVP";
            this.txtTenVP.Size = new System.Drawing.Size(368, 30);
            this.txtTenVP.TabIndex = 24;
            this.txtTenVP.TextChanged += new System.EventHandler(this.txtTenVP_TextChanged);
            // 
            // lblTenVP
            // 
            this.lblTenVP.AutoSize = true;
            this.lblTenVP.BackColor = System.Drawing.Color.Transparent;
            this.lblTenVP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenVP.Location = new System.Drawing.Point(14, 39);
            this.lblTenVP.Name = "lblTenVP";
            this.lblTenVP.Size = new System.Drawing.Size(157, 25);
            this.lblTenVP.TabIndex = 23;
            this.lblTenVP.Text = "Tên Vật Phẩm:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(593, 28);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(285, 42);
            this.lblHeading.TabIndex = 25;
            this.lblHeading.Text = "Xuất/Nhập Kho";
            // 
            // Xuat_NhapKho_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1423, 681);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.PanelSuaDoi);
            this.Controls.Add(this.PanelTT);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Xuat_NhapKho_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất/Nhập Kho";
            this.Load += new System.EventHandler(this.NhapKho_Form_Load);
            this.PanelTT.ResumeLayout(false);
            this.PanelTT.PerformLayout();
            this.grBCV.ResumeLayout(false);
            this.grBCV.PerformLayout();
            this.PanelSuaDoi.ResumeLayout(false);
            this.PanelSuaDoi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDow_SL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Panel PanelTT;
        private System.Windows.Forms.GroupBox grBCV;
        private System.Windows.Forms.RadioButton rbtnNK;
        private System.Windows.Forms.RadioButton rbtnXK;
        private System.Windows.Forms.DateTimePicker DTPNgay;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.Panel PanelSuaDoi;
        private System.Windows.Forms.ComboBox cmbPhanLoai;
        private System.Windows.Forms.NumericUpDown numUpDow_SL;
        private System.Windows.Forms.Label lblPhanLoai;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtTenVP;
        private System.Windows.Forms.Label lblTenVP;
        private System.Windows.Forms.TextBox txtMaVP;
        private System.Windows.Forms.Label lblMaVP;
        private System.Windows.Forms.Label lblHeading;
    }
}