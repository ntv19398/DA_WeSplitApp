namespace WeSplitApp.GUI
{
    partial class frmHomeScreen
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flpDSDangDi = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flpDSDaDi = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNextDangDi = new System.Windows.Forms.Button();
            this.btnNextDaDi = new System.Windows.Forms.Button();
            this.btnPrevDangDi = new System.Windows.Forms.Button();
            this.btnPrevDaDi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flpDSDangDi);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(16, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1035, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách Chuyến đi - Đang đi";
            // 
            // flpDSDangDi
            // 
            this.flpDSDangDi.Location = new System.Drawing.Point(8, 23);
            this.flpDSDangDi.Margin = new System.Windows.Forms.Padding(4);
            this.flpDSDangDi.Name = "flpDSDangDi";
            this.flpDSDangDi.Size = new System.Drawing.Size(1019, 206);
            this.flpDSDangDi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.flpDSDaDi);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(19, 354);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1035, 234);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách Chuyến đi - Đã đi";
            // 
            // flpDSDaDi
            // 
            this.flpDSDaDi.Location = new System.Drawing.Point(8, 23);
            this.flpDSDaDi.Margin = new System.Windows.Forms.Padding(4);
            this.flpDSDaDi.Name = "flpDSDaDi";
            this.flpDSDaDi.Size = new System.Drawing.Size(1019, 206);
            this.flpDSDaDi.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(785, 26);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(176, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(669, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Location = new System.Drawing.Point(360, 23);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 36);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm chuyến đi";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSearch.Location = new System.Drawing.Point(980, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNextDangDi
            // 
            this.btnNextDangDi.Location = new System.Drawing.Point(944, 319);
            this.btnNextDangDi.Name = "btnNextDangDi";
            this.btnNextDangDi.Size = new System.Drawing.Size(107, 28);
            this.btnNextDangDi.TabIndex = 5;
            this.btnNextDangDi.Text = "Next";
            this.btnNextDangDi.UseVisualStyleBackColor = true;
            this.btnNextDangDi.Click += new System.EventHandler(this.btnNextDangDi_Click);
            // 
            // btnNextDaDi
            // 
            this.btnNextDaDi.Location = new System.Drawing.Point(944, 595);
            this.btnNextDaDi.Name = "btnNextDaDi";
            this.btnNextDaDi.Size = new System.Drawing.Size(107, 28);
            this.btnNextDaDi.TabIndex = 5;
            this.btnNextDaDi.Text = "Next";
            this.btnNextDaDi.UseVisualStyleBackColor = true;
            this.btnNextDaDi.Click += new System.EventHandler(this.btnNextDaDi_Click);
            // 
            // btnPrevDangDi
            // 
            this.btnPrevDangDi.Location = new System.Drawing.Point(12, 319);
            this.btnPrevDangDi.Name = "btnPrevDangDi";
            this.btnPrevDangDi.Size = new System.Drawing.Size(107, 28);
            this.btnPrevDangDi.TabIndex = 6;
            this.btnPrevDangDi.Text = "Previous";
            this.btnPrevDangDi.UseVisualStyleBackColor = true;
            this.btnPrevDangDi.Click += new System.EventHandler(this.btnPrevDangDi_Click);
            // 
            // btnPrevDaDi
            // 
            this.btnPrevDaDi.Location = new System.Drawing.Point(12, 595);
            this.btnPrevDaDi.Name = "btnPrevDaDi";
            this.btnPrevDaDi.Size = new System.Drawing.Size(107, 28);
            this.btnPrevDaDi.TabIndex = 6;
            this.btnPrevDaDi.Text = "Previous";
            this.btnPrevDaDi.UseVisualStyleBackColor = true;
            this.btnPrevDaDi.Click += new System.EventHandler(this.btnPrevDaDi_Click);
            // 
            // frmHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 629);
            this.Controls.Add(this.btnPrevDaDi);
            this.Controls.Add(this.btnPrevDangDi);
            this.Controls.Add(this.btnNextDaDi);
            this.Controls.Add(this.btnNextDangDi);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeSplit App";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flpDSDangDi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flpDSDaDi;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNextDangDi;
        private System.Windows.Forms.Button btnNextDaDi;
        private System.Windows.Forms.Button btnPrevDangDi;
        private System.Windows.Forms.Button btnPrevDaDi;
    }
}