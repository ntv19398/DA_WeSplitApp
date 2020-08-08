namespace WeSplitApp.GUI
{
    partial class frmDetail
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
            this.dgvDSTV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListImages = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbChuyenDi = new System.Windows.Forms.Label();
            this.txtTienTVDong = new System.Windows.Forms.TextBox();
            this.txtTongChiPhi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateThuChi = new System.Windows.Forms.Button();
            this.dgvDSTC = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnUpdateDiaDiem = new System.Windows.Forms.Button();
            this.dgvDSDD = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateThanhVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTV)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTC)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSTV
            // 
            this.dgvDSTV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTV.Location = new System.Drawing.Point(6, 22);
            this.dgvDSTV.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSTV.Name = "dgvDSTV";
            this.dgvDSTV.ReadOnly = true;
            this.dgvDSTV.Size = new System.Drawing.Size(440, 159);
            this.dgvDSTV.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnListImages);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lbChuyenDi);
            this.panel1.Controls.Add(this.txtTienTVDong);
            this.panel1.Controls.Add(this.txtTongChiPhi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 517);
            this.panel1.TabIndex = 1;
            // 
            // btnListImages
            // 
            this.btnListImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListImages.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnListImages.Location = new System.Drawing.Point(583, 298);
            this.btnListImages.Name = "btnListImages";
            this.btnListImages.Size = new System.Drawing.Size(223, 36);
            this.btnListImages.TabIndex = 4;
            this.btnListImages.Text = "Xem danh sách hình ảnh";
            this.btnListImages.UseVisualStyleBackColor = true;
            this.btnListImages.Click += new System.EventHandler(this.btnListImages_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(807, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbChuyenDi
            // 
            this.lbChuyenDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbChuyenDi.ForeColor = System.Drawing.Color.Red;
            this.lbChuyenDi.Location = new System.Drawing.Point(213, 17);
            this.lbChuyenDi.Name = "lbChuyenDi";
            this.lbChuyenDi.Size = new System.Drawing.Size(465, 35);
            this.lbChuyenDi.TabIndex = 2;
            this.lbChuyenDi.Text = "label1";
            this.lbChuyenDi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienTVDong
            // 
            this.txtTienTVDong.Enabled = false;
            this.txtTienTVDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienTVDong.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtTienTVDong.Location = new System.Drawing.Point(695, 406);
            this.txtTienTVDong.Name = "txtTienTVDong";
            this.txtTienTVDong.Size = new System.Drawing.Size(209, 21);
            this.txtTienTVDong.TabIndex = 3;
            // 
            // txtTongChiPhi
            // 
            this.txtTongChiPhi.Enabled = false;
            this.txtTongChiPhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongChiPhi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtTongChiPhi.Location = new System.Drawing.Point(695, 366);
            this.txtTongChiPhi.Name = "txtTongChiPhi";
            this.txtTongChiPhi.Size = new System.Drawing.Size(209, 21);
            this.txtTongChiPhi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(529, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số tiền mà mỗi thành viên\r\n cần đóng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng chi phí chuyến đi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateThuChi);
            this.groupBox2.Controls.Add(this.dgvDSTC);
            this.groupBox2.Location = new System.Drawing.Point(3, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách thu chi";
            // 
            // btnUpdateThuChi
            // 
            this.btnUpdateThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateThuChi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateThuChi.Location = new System.Drawing.Point(372, 183);
            this.btnUpdateThuChi.Name = "btnUpdateThuChi";
            this.btnUpdateThuChi.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateThuChi.TabIndex = 4;
            this.btnUpdateThuChi.Text = "Cập nhật";
            this.btnUpdateThuChi.UseVisualStyleBackColor = true;
            this.btnUpdateThuChi.Click += new System.EventHandler(this.btnUpdateThuChi_Click);
            // 
            // dgvDSTC
            // 
            this.dgvDSTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTC.Location = new System.Drawing.Point(6, 22);
            this.dgvDSTC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSTC.Name = "dgvDSTC";
            this.dgvDSTC.ReadOnly = true;
            this.dgvDSTC.Size = new System.Drawing.Size(440, 159);
            this.dgvDSTC.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnUpdateDiaDiem);
            this.groupBox3.Controls.Add(this.dgvDSDD);
            this.groupBox3.Location = new System.Drawing.Point(477, 55);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(434, 224);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách địa điểm";
            // 
            // btnUpdateDiaDiem
            // 
            this.btnUpdateDiaDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDiaDiem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateDiaDiem.Location = new System.Drawing.Point(353, 182);
            this.btnUpdateDiaDiem.Name = "btnUpdateDiaDiem";
            this.btnUpdateDiaDiem.Size = new System.Drawing.Size(75, 36);
            this.btnUpdateDiaDiem.TabIndex = 4;
            this.btnUpdateDiaDiem.Text = "Cập nhật";
            this.btnUpdateDiaDiem.UseVisualStyleBackColor = true;
            this.btnUpdateDiaDiem.Click += new System.EventHandler(this.btnUpdateDiaDiem_Click);
            // 
            // dgvDSDD
            // 
            this.dgvDSDD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSDD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDD.Location = new System.Drawing.Point(7, 22);
            this.dgvDSDD.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDSDD.Name = "dgvDSDD";
            this.dgvDSDD.ReadOnly = true;
            this.dgvDSDD.Size = new System.Drawing.Size(420, 159);
            this.dgvDSDD.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvDSTV);
            this.groupBox1.Controls.Add(this.btnUpdateThanhVien);
            this.groupBox1.Location = new System.Drawing.Point(3, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thành viên";
            // 
            // btnUpdateThanhVien
            // 
            this.btnUpdateThanhVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateThanhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateThanhVien.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUpdateThanhVien.Location = new System.Drawing.Point(372, 182);
            this.btnUpdateThanhVien.Name = "btnUpdateThanhVien";
            this.btnUpdateThanhVien.Size = new System.Drawing.Size(74, 36);
            this.btnUpdateThanhVien.TabIndex = 4;
            this.btnUpdateThanhVien.Text = "Cập nhật";
            this.btnUpdateThanhVien.UseVisualStyleBackColor = true;
            this.btnUpdateThanhVien.Click += new System.EventHandler(this.btnUpdateThanhVien_Click);
            // 
            // frmDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 540);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết chuyến đi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSTV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvDSTC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSDD;
        private System.Windows.Forms.TextBox txtTienTVDong;
        private System.Windows.Forms.TextBox txtTongChiPhi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbChuyenDi;
        private System.Windows.Forms.Button btnUpdateThuChi;
        private System.Windows.Forms.Button btnUpdateDiaDiem;
        private System.Windows.Forms.Button btnUpdateThanhVien;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnListImages;
    }
}