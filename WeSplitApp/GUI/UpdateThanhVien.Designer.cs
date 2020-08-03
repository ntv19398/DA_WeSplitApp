namespace WeSplitApp.GUI
{
    partial class frmUpdateThanhVien
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
            this.txtTenTV = new System.Windows.Forms.TextBox();
            this.txtMaTV = new System.Windows.Forms.TextBox();
            this.txtMaCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvThanhVien = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenTV
            // 
            this.txtTenTV.Location = new System.Drawing.Point(571, 159);
            this.txtTenTV.Name = "txtTenTV";
            this.txtTenTV.Size = new System.Drawing.Size(214, 20);
            this.txtTenTV.TabIndex = 11;
            // 
            // txtMaTV
            // 
            this.txtMaTV.Location = new System.Drawing.Point(571, 115);
            this.txtMaTV.Name = "txtMaTV";
            this.txtMaTV.Size = new System.Drawing.Size(214, 20);
            this.txtMaTV.TabIndex = 12;
            // 
            // txtMaCD
            // 
            this.txtMaCD.Location = new System.Drawing.Point(571, 70);
            this.txtMaCD.Name = "txtMaCD";
            this.txtMaCD.Size = new System.Drawing.Size(214, 20);
            this.txtMaCD.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên thành viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mã thành viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã chuyến đi:";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(687, 207);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(571, 207);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 207);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvThanhVien
            // 
            this.dgvThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhVien.Location = new System.Drawing.Point(12, 70);
            this.dgvThanhVien.Name = "dgvThanhVien";
            this.dgvThanhVien.ReadOnly = true;
            this.dgvThanhVien.Size = new System.Drawing.Size(385, 223);
            this.dgvThanhVien.TabIndex = 4;
            this.dgvThanhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhVien_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(702, 255);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 38);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.Red;
            this.lbTitle.Location = new System.Drawing.Point(144, 18);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(488, 37);
            this.lbTitle.TabIndex = 26;
            this.lbTitle.Text = "label5";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmUpdateThanhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 305);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTenTV);
            this.Controls.Add(this.txtMaTV);
            this.Controls.Add(this.txtMaCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvThanhVien);
            this.Name = "frmUpdateThanhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateThanhVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenTV;
        private System.Windows.Forms.TextBox txtMaTV;
        private System.Windows.Forms.TextBox txtMaCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvThanhVien;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbTitle;
    }
}