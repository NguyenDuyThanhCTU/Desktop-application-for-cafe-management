namespace Project1
{
    partial class UserControl_DSCLV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_DSCLV));
            this.panelDSCLV = new System.Windows.Forms.Panel();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.DGV_BangDS = new System.Windows.Forms.DataGridView();
            this.btnXemDS = new System.Windows.Forms.Button();
            this.DTP_ChonNgay = new System.Windows.Forms.DateTimePicker();
            this.lblChonNgay = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.ColumnMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelDSCLV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangDS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDSCLV
            // 
            this.panelDSCLV.BackColor = System.Drawing.Color.Transparent;
            this.panelDSCLV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDSCLV.Controls.Add(this.btnXuatFile);
            this.panelDSCLV.Controls.Add(this.DGV_BangDS);
            this.panelDSCLV.Controls.Add(this.btnXemDS);
            this.panelDSCLV.Controls.Add(this.DTP_ChonNgay);
            this.panelDSCLV.Controls.Add(this.lblChonNgay);
            this.panelDSCLV.Controls.Add(this.lblHeading);
            this.panelDSCLV.Location = new System.Drawing.Point(0, 0);
            this.panelDSCLV.Name = "panelDSCLV";
            this.panelDSCLV.Size = new System.Drawing.Size(1561, 849);
            this.panelDSCLV.TabIndex = 0;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.White;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(678, 714);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(231, 54);
            this.btnXuatFile.TabIndex = 5;
            this.btnXuatFile.Text = "Xuất File Excel";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
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
            this.ColumnSDT,
            this.ColumnBuoi,
            this.ColumnNgay});
            this.DGV_BangDS.Location = new System.Drawing.Point(116, 229);
            this.DGV_BangDS.Name = "DGV_BangDS";
            this.DGV_BangDS.RowHeadersWidth = 51;
            this.DGV_BangDS.RowTemplate.Height = 24;
            this.DGV_BangDS.Size = new System.Drawing.Size(1321, 448);
            this.DGV_BangDS.TabIndex = 4;
            // 
            // btnXemDS
            // 
            this.btnXemDS.BackColor = System.Drawing.Color.White;
            this.btnXemDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDS.Location = new System.Drawing.Point(963, 124);
            this.btnXemDS.Name = "btnXemDS";
            this.btnXemDS.Size = new System.Drawing.Size(198, 51);
            this.btnXemDS.TabIndex = 3;
            this.btnXemDS.Text = "Xem Danh Sách";
            this.btnXemDS.UseVisualStyleBackColor = false;
            this.btnXemDS.Click += new System.EventHandler(this.btnXemDS_Click);
            // 
            // DTP_ChonNgay
            // 
            this.DTP_ChonNgay.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_ChonNgay.Location = new System.Drawing.Point(459, 132);
            this.DTP_ChonNgay.Name = "DTP_ChonNgay";
            this.DTP_ChonNgay.Size = new System.Drawing.Size(430, 30);
            this.DTP_ChonNgay.TabIndex = 2;
            // 
            // lblChonNgay
            // 
            this.lblChonNgay.AutoSize = true;
            this.lblChonNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonNgay.Location = new System.Drawing.Point(316, 137);
            this.lblChonNgay.Name = "lblChonNgay";
            this.lblChonNgay.Size = new System.Drawing.Size(127, 25);
            this.lblChonNgay.TabIndex = 1;
            this.lblChonNgay.Text = "Chọn Ngày:";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(473, 29);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(529, 42);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Danh Sách Các Ca Làm Việc";
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
            // ColumnSDT
            // 
            this.ColumnSDT.DataPropertyName = "SDT";
            this.ColumnSDT.HeaderText = "SĐT";
            this.ColumnSDT.MinimumWidth = 6;
            this.ColumnSDT.Name = "ColumnSDT";
            this.ColumnSDT.ReadOnly = true;
            // 
            // ColumnBuoi
            // 
            this.ColumnBuoi.DataPropertyName = "CaLV";
            this.ColumnBuoi.HeaderText = "Ca Làm Việc";
            this.ColumnBuoi.MinimumWidth = 6;
            this.ColumnBuoi.Name = "ColumnBuoi";
            this.ColumnBuoi.ReadOnly = true;
            // 
            // ColumnNgay
            // 
            this.ColumnNgay.DataPropertyName = "NgayLV";
            this.ColumnNgay.HeaderText = "Ngày Làm Việc";
            this.ColumnNgay.MinimumWidth = 6;
            this.ColumnNgay.Name = "ColumnNgay";
            this.ColumnNgay.ReadOnly = true;
            // 
            // UserControl_DSCLV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panelDSCLV);
            this.Name = "UserControl_DSCLV";
            this.Size = new System.Drawing.Size(1561, 849);
            this.Load += new System.EventHandler(this.UserControl_DSCLV_Load);
            this.panelDSCLV.ResumeLayout(false);
            this.panelDSCLV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_BangDS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDSCLV;
        private System.Windows.Forms.Button btnXemDS;
        private System.Windows.Forms.DateTimePicker DTP_ChonNgay;
        private System.Windows.Forms.Label lblChonNgay;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.DataGridView DGV_BangDS;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgay;
    }
}
