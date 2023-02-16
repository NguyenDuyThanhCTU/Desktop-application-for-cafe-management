namespace Project1
{
    partial class UserControl_DCPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_DCPC));
            this.panelContain = new System.Windows.Forms.Panel();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnNhapXuat_Kho = new System.Windows.Forms.Button();
            this.DGV_DCPC = new System.Windows.Forms.DataGridView();
            this.lblTitile = new System.Windows.Forms.Label();
            this.ColumnMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_NgayNK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DCPC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.Color.Transparent;
            this.panelContain.Controls.Add(this.btnCapNhat);
            this.panelContain.Controls.Add(this.btnXuatFile);
            this.panelContain.Controls.Add(this.btnNhapXuat_Kho);
            this.panelContain.Controls.Add(this.DGV_DCPC);
            this.panelContain.Controls.Add(this.lblTitile);
            this.panelContain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelContain.Location = new System.Drawing.Point(0, 0);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(1166, 851);
            this.panelContain.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.White;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(489, 692);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(200, 50);
            this.btnCapNhat.TabIndex = 4;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXuatFile.Location = new System.Drawing.Point(897, 692);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(200, 50);
            this.btnXuatFile.TabIndex = 3;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnNhapXuat_Kho
            // 
            this.btnNhapXuat_Kho.BackColor = System.Drawing.Color.White;
            this.btnNhapXuat_Kho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapXuat_Kho.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhapXuat_Kho.Location = new System.Drawing.Point(79, 692);
            this.btnNhapXuat_Kho.Name = "btnNhapXuat_Kho";
            this.btnNhapXuat_Kho.Size = new System.Drawing.Size(200, 50);
            this.btnNhapXuat_Kho.TabIndex = 2;
            this.btnNhapXuat_Kho.Text = "Nhập/Xuất Kho";
            this.btnNhapXuat_Kho.UseVisualStyleBackColor = false;
            this.btnNhapXuat_Kho.Click += new System.EventHandler(this.btnNhapXuat_Kho_Click);
            // 
            // DGV_DCPC
            // 
            this.DGV_DCPC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_DCPC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.DGV_DCPC.BackgroundColor = System.Drawing.Color.White;
            this.DGV_DCPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV_DCPC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DCPC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMa,
            this.Column_Ten,
            this.Column_Loai,
            this.Column_SoLuong,
            this.Column_NgayNK});
            this.DGV_DCPC.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.DGV_DCPC.Location = new System.Drawing.Point(32, 112);
            this.DGV_DCPC.Name = "DGV_DCPC";
            this.DGV_DCPC.RowHeadersWidth = 51;
            this.DGV_DCPC.RowTemplate.Height = 24;
            this.DGV_DCPC.Size = new System.Drawing.Size(1097, 500);
            this.DGV_DCPC.TabIndex = 1;
            // 
            // lblTitile
            // 
            this.lblTitile.AutoSize = true;
            this.lblTitile.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitile.Location = new System.Drawing.Point(216, 29);
            this.lblTitile.Name = "lblTitile";
            this.lblTitile.Size = new System.Drawing.Size(738, 42);
            this.lblTitile.TabIndex = 0;
            this.lblTitile.Text = "Danh Sách Dụng Cụ Pha Chế Trong Kho";
            // 
            // ColumnMa
            // 
            this.ColumnMa.DataPropertyName = "MaVP";
            this.ColumnMa.HeaderText = "Mã Vật Phẩm";
            this.ColumnMa.MinimumWidth = 6;
            this.ColumnMa.Name = "ColumnMa";
            this.ColumnMa.ReadOnly = true;
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
            // UserControl_DCPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelContain);
            this.Name = "UserControl_DCPC";
            this.Size = new System.Drawing.Size(1166, 851);
            this.Load += new System.EventHandler(this.UserControl_DCPC_Load);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DCPC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.Label lblTitile;
        private System.Windows.Forms.DataGridView DGV_DCPC;
        private System.Windows.Forms.Button btnNhapXuat_Kho;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NgayNK;
    }
}
