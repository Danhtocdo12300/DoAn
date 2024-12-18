namespace DoAnTinHoc1.Form_ChucNang
{
    partial class FormKhoHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhoHang));
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLuu_KhoHang = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKhoHang = new System.Windows.Forms.DataGridView();
            this.txt_ProductFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa_SPtrongKho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(8, 6);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MinimumSize = new System.Drawing.Size(7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(453, 50);
            this.label7.TabIndex = 52;
            this.label7.Text = "Sản Phẩm Có Trong Kho\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnNhapHang);
            this.panel1.Location = new System.Drawing.Point(8, 435);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 122);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoa_SPtrongKho);
            this.panel2.Controls.Add(this.btnLuu_KhoHang);
            this.panel2.Location = new System.Drawing.Point(394, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 96);
            this.panel2.TabIndex = 6;
            // 
            // btnLuu_KhoHang
            // 
            this.btnLuu_KhoHang.BackColor = System.Drawing.Color.White;
            this.btnLuu_KhoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_KhoHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_KhoHang.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_KhoHang.Image")));
            this.btnLuu_KhoHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_KhoHang.Location = new System.Drawing.Point(22, 23);
            this.btnLuu_KhoHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu_KhoHang.Name = "btnLuu_KhoHang";
            this.btnLuu_KhoHang.Size = new System.Drawing.Size(155, 54);
            this.btnLuu_KhoHang.TabIndex = 20;
            this.btnLuu_KhoHang.Text = "Lưu Kho Hàng";
            this.btnLuu_KhoHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_KhoHang.UseVisualStyleBackColor = false;
            this.btnLuu_KhoHang.Click += new System.EventHandler(this.btnLuu_KhachHang_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.Color.Cyan;
            this.btnNhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNhapHang.FlatAppearance.BorderSize = 0;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.ForeColor = System.Drawing.Color.White;
            this.btnNhapHang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhapHang.Image")));
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(55, 31);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(207, 54);
            this.btnNhapHang.TabIndex = 4;
            this.btnNhapHang.Text = "      Nhập Hàng";
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ngày Nhập";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Số Lượng Tồn";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên Phụ Tùng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Phụ Tùng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // dgvKhoHang
            // 
            this.dgvKhoHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhoHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvKhoHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhoHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKhoHang.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhoHang.Location = new System.Drawing.Point(8, 78);
            this.dgvKhoHang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvKhoHang.Name = "dgvKhoHang";
            this.dgvKhoHang.RowHeadersWidth = 62;
            this.dgvKhoHang.RowTemplate.Height = 28;
            this.dgvKhoHang.Size = new System.Drawing.Size(1055, 345);
            this.dgvKhoHang.TabIndex = 53;
            // 
            // txt_ProductFilter
            // 
            this.txt_ProductFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ProductFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ProductFilter.Location = new System.Drawing.Point(906, 46);
            this.txt_ProductFilter.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ProductFilter.Name = "txt_ProductFilter";
            this.txt_ProductFilter.Size = new System.Drawing.Size(158, 35);
            this.txt_ProductFilter.TabIndex = 55;
            this.txt_ProductFilter.TextChanged += new System.EventHandler(this.txt_ProductFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(822, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Tìm theo:";
            // 
            // btnXoa_SPtrongKho
            // 
            this.btnXoa_SPtrongKho.BackColor = System.Drawing.Color.White;
            this.btnXoa_SPtrongKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_SPtrongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_SPtrongKho.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_SPtrongKho.Image")));
            this.btnXoa_SPtrongKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_SPtrongKho.Location = new System.Drawing.Point(296, 18);
            this.btnXoa_SPtrongKho.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa_SPtrongKho.Name = "btnXoa_SPtrongKho";
            this.btnXoa_SPtrongKho.Size = new System.Drawing.Size(213, 63);
            this.btnXoa_SPtrongKho.TabIndex = 21;
            this.btnXoa_SPtrongKho.Text = "Xóa SP Trong Kho";
            this.btnXoa_SPtrongKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_SPtrongKho.UseVisualStyleBackColor = false;
            this.btnXoa_SPtrongKho.Click += new System.EventHandler(this.btnXoa_SPtrongKho_Click);
            // 
            // FormKhoHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ProductFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvKhoHang);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormKhoHang";
            this.Text = "FormKhoHang";
            this.Load += new System.EventHandler(this.FormKhoHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhoHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dgvKhoHang;
        private System.Windows.Forms.TextBox txt_ProductFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLuu_KhoHang;
        private System.Windows.Forms.Button btnXoa_SPtrongKho;
    }
}