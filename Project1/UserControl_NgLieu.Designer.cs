namespace Project1
{
    partial class UserControl_NgLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_NgLieu));
            this.panelContain = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuatNhapKho = new System.Windows.Forms.Button();
            this.DGV_NguyenLieu = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.ColumnMaVP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgayNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NguyenLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.Color.Transparent;
            this.panelContain.Controls.Add(this.btnXuatFile);
            this.panelContain.Controls.Add(this.btnCapNhat);
            this.panelContain.Controls.Add(this.btnXuatNhapKho);
            this.panelContain.Controls.Add(this.DGV_NguyenLieu);
            this.panelContain.Controls.Add(this.lbl_Title);
            this.panelContain.Location = new System.Drawing.Point(3, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1166, 905);
            this.panelContain.TabIndex = 0;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXuatFile.Location = new System.Drawing.Point(861, 685);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(200, 50);
            this.btnXuatFile.TabIndex = 5;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Snow;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Location = new System.Drawing.Point(501, 685);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 50);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXuatNhapKho
            // 
            this.btnXuatNhapKho.BackColor = System.Drawing.Color.Snow;
            this.btnXuatNhapKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatNhapKho.Location = new System.Drawing.Point(110, 685);
            this.btnXuatNhapKho.Name = "btnXuatNhapKho";
            this.btnXuatNhapKho.Size = new System.Drawing.Size(220, 50);
            this.btnXuatNhapKho.TabIndex = 2;
            this.btnXuatNhapKho.Text = "Nhập/Xuất Kho";
            this.btnXuatNhapKho.UseVisualStyleBackColor = false;
            this.btnXuatNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // DGV_NguyenLieu
            // 
            this.DGV_NguyenLieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_NguyenLieu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_NguyenLieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.DGV_NguyenLieu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_NguyenLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_NguyenLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMaVP,
            this.Column_Ten,
            this.Column_Loai,
            this.Column_SoLuong,
            this.Column_NgayNK});
            this.DGV_NguyenLieu.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_NguyenLieu.Location = new System.Drawing.Point(55, 123);
            this.DGV_NguyenLieu.Name = "DGV_NguyenLieu";
            this.DGV_NguyenLieu.RowHeadersWidth = 51;
            this.DGV_NguyenLieu.RowTemplate.Height = 24;
            this.DGV_NguyenLieu.Size = new System.Drawing.Size(1046, 500);
            this.DGV_NguyenLieu.TabIndex = 1;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(201, 33);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(722, 42);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Danh Sách Các Nguyên Liệu Trong Kho";
            // 
            // ColumnMaVP
            // 
            this.ColumnMaVP.DataPropertyName = "MaVP";
            this.ColumnMaVP.HeaderText = "Mã Vật Phẩm";
            this.ColumnMaVP.MinimumWidth = 6;
            this.ColumnMaVP.Name = "ColumnMaVP";
            this.ColumnMaVP.ReadOnly = true;
            // 
            // Column_Ten
            // 
            this.Column_Ten.DataPropertyName = "TenVP";
            this.Column_Ten.HeaderText = "Tên Vật Phẩm";
            this.Column_Ten.MinimumWidth = 6;
            this.Column_Ten.Name = "Column_Ten";
            this.Column_Ten.ReadOnly = true;
            // 
            // Column_Loai
            // 
            this.Column_Loai.DataPropertyName = "PhanLoai";
            this.Column_Loai.HeaderText = "Phân Loại";
            this.Column_Loai.MinimumWidth = 6;
            this.Column_Loai.Name = "Column_Loai";
            this.Column_Loai.ReadOnly = true;
            // 
            // Column_SoLuong
            // 
            this.Column_SoLuong.DataPropertyName = "SoLuong";
            this.Column_SoLuong.HeaderText = "Số Lượng";
            this.Column_SoLuong.MinimumWidth = 6;
            this.Column_SoLuong.Name = "Column_SoLuong";
            this.Column_SoLuong.ReadOnly = true;
            // 
            // Column_NgayNK
            // 
            this.Column_NgayNK.DataPropertyName = "NgayNhap";
            this.Column_NgayNK.HeaderText = "Ngày Nhập Kho";
            this.Column_NgayNK.MinimumWidth = 6;
            this.Column_NgayNK.Name = "Column_NgayNK";
            this.Column_NgayNK.ReadOnly = true;
            // 
            // UserControl_NgLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelContain);
            this.Name = "UserControl_NgLieu";
            this.Size = new System.Drawing.Size(1166, 905);
            this.Load += new System.EventHandler(this.UserControl_NgLieu_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NguyenLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.DataGridView DGV_NguyenLieu;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXuatNhapKho;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaVP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayNK;
    }
}
