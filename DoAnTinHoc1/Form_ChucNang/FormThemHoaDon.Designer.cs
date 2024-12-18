namespace DoAnTinHoc1.Form_ChucNang
{
    partial class FormThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormThemHoaDon));
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.cboMaPhuTung = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_KhachHang = new System.Windows.Forms.TextBox();
            this.cbDiaChiKhachHang = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.btnXoa_HoaDon = new System.Windows.Forms.Button();
            this.btnThem_PT = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_AddHD = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaHoaDon.Enabled = false;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHoaDon.Location = new System.Drawing.Point(19, 58);
            this.txtMaHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.Size = new System.Drawing.Size(201, 41);
            this.txtMaHoaDon.TabIndex = 15;
            this.txtMaHoaDon.Text = "HD Số";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ngày Lập Hóa Đơn";
            // 
            // dtNgayLapHoaDon
            // 
            this.dtNgayLapHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayLapHoaDon.Location = new System.Drawing.Point(244, 123);
            this.dtNgayLapHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayLapHoaDon.Name = "dtNgayLapHoaDon";
            this.dtNgayLapHoaDon.Size = new System.Drawing.Size(221, 35);
            this.dtNgayLapHoaDon.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 18;
            this.label3.Text = "Khách hàng:";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.AllowUserToAddRows = false;
            this.dgvHoaDon.AllowUserToDeleteRows = false;
            this.dgvHoaDon.AllowUserToResizeRows = false;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvHoaDon.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoaDon.Location = new System.Drawing.Point(19, 251);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 62;
            this.dgvHoaDon.RowTemplate.Height = 28;
            this.dgvHoaDon.Size = new System.Drawing.Size(1029, 251);
            this.dgvHoaDon.TabIndex = 44;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // cboMaPhuTung
            // 
            this.cboMaPhuTung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaPhuTung.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.cboMaPhuTung.FormattingEnabled = true;
            this.cboMaPhuTung.Location = new System.Drawing.Point(20, 49);
            this.cboMaPhuTung.Margin = new System.Windows.Forms.Padding(2);
            this.cboMaPhuTung.Name = "cboMaPhuTung";
            this.cboMaPhuTung.Size = new System.Drawing.Size(148, 42);
            this.cboMaPhuTung.TabIndex = 45;
            this.cboMaPhuTung.SelectedIndexChanged += new System.EventHandler(this.cboMaPhuTung_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 48;
            this.label7.Text = "Địa Chỉ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.txt_KhachHang);
            this.groupBox1.Controls.Add(this.cbDiaChiKhachHang);
            this.groupBox1.Controls.Add(this.txtMaHoaDon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtNgayLapHoaDon);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(495, 175);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Khách Hàng";
            // 
            // txt_KhachHang
            // 
            this.txt_KhachHang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_KhachHang.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KhachHang.Location = new System.Drawing.Point(245, 58);
            this.txt_KhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.txt_KhachHang.Name = "txt_KhachHang";
            this.txt_KhachHang.Size = new System.Drawing.Size(220, 41);
            this.txt_KhachHang.TabIndex = 53;
            // 
            // cbDiaChiKhachHang
            // 
            this.cbDiaChiKhachHang.Enabled = false;
            this.cbDiaChiKhachHang.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.cbDiaChiKhachHang.FormattingEnabled = true;
            this.cbDiaChiKhachHang.Location = new System.Drawing.Point(19, 125);
            this.cbDiaChiKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.cbDiaChiKhachHang.Name = "cbDiaChiKhachHang";
            this.cbDiaChiKhachHang.Size = new System.Drawing.Size(201, 42);
            this.cbDiaChiKhachHang.TabIndex = 52;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_Number);
            this.groupBox2.Controls.Add(this.btnXoa_HoaDon);
            this.groupBox2.Controls.Add(this.btnThem_PT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtGiaTien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cboMaPhuTung);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox2.Location = new System.Drawing.Point(533, 47);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(515, 175);
            this.groupBox2.TabIndex = 51;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn Sản Phẩm PT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.Location = new System.Drawing.Point(341, 29);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 27);
            this.label4.TabIndex = 53;
            this.label4.Text = "Số lượng";
            // 
            // txt_Number
            // 
            this.txt_Number.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Number.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Number.Location = new System.Drawing.Point(345, 49);
            this.txt_Number.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(153, 41);
            this.txt_Number.TabIndex = 54;
            // 
            // btnXoa_HoaDon
            // 
            this.btnXoa_HoaDon.BackColor = System.Drawing.Color.White;
            this.btnXoa_HoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_HoaDon.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_HoaDon.Image")));
            this.btnXoa_HoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_HoaDon.Location = new System.Drawing.Point(326, 108);
            this.btnXoa_HoaDon.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa_HoaDon.Name = "btnXoa_HoaDon";
            this.btnXoa_HoaDon.Size = new System.Drawing.Size(172, 41);
            this.btnXoa_HoaDon.TabIndex = 11;
            this.btnXoa_HoaDon.Text = "Xóa toàn bộ SP";
            this.btnXoa_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_HoaDon.UseVisualStyleBackColor = false;
            this.btnXoa_HoaDon.Click += new System.EventHandler(this.btnXoa_HoaDon_Click);
            // 
            // btnThem_PT
            // 
            this.btnThem_PT.BackColor = System.Drawing.Color.White;
            this.btnThem_PT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_PT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_PT.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_PT.Image")));
            this.btnThem_PT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_PT.Location = new System.Drawing.Point(190, 108);
            this.btnThem_PT.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem_PT.Name = "btnThem_PT";
            this.btnThem_PT.Size = new System.Drawing.Size(118, 41);
            this.btnThem_PT.TabIndex = 10;
            this.btnThem_PT.Text = "Thêm SP";
            this.btnThem_PT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_PT.UseVisualStyleBackColor = false;
            this.btnThem_PT.Click += new System.EventHandler(this.btnThem_PT_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label9.Location = new System.Drawing.Point(174, 29);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 27);
            this.label9.TabIndex = 51;
            this.label9.Text = "Giá Tiền";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTien.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(178, 49);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(2);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(153, 41);
            this.txtGiaTien.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 27);
            this.label5.TabIndex = 50;
            this.label5.Text = "Phụ tùng:";
            // 
            // btn_AddHD
            // 
            this.btn_AddHD.BackColor = System.Drawing.Color.White;
            this.btn_AddHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddHD.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddHD.Image")));
            this.btn_AddHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddHD.Location = new System.Drawing.Point(896, 506);
            this.btn_AddHD.Margin = new System.Windows.Forms.Padding(2);
            this.btn_AddHD.Name = "btn_AddHD";
            this.btn_AddHD.Size = new System.Drawing.Size(152, 41);
            this.btn_AddHD.TabIndex = 54;
            this.btn_AddHD.Text = "Thêm Hóa Đơn";
            this.btn_AddHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddHD.UseVisualStyleBackColor = false;
            this.btn_AddHD.Click += new System.EventHandler(this.btn_AddHD_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(19, 506);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 41);
            this.button2.TabIndex = 55;
            this.button2.Text = "Quay lại";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(8, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MinimumSize = new System.Drawing.Size(7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 41);
            this.label8.TabIndex = 52;
            this.label8.Text = "Thêm hoá đơn";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPHUTUNG";
            this.Column1.HeaderText = "Mã Phụ Tùng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENPHUTUNG";
            this.Column2.HeaderText = "Tên Phụ Tùng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SOLUONG";
            this.Column3.HeaderText = "Số lượng";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GIATIEN";
            this.Column4.HeaderText = "Giá Tiền";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // FormThemHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1074, 567);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_AddHD);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHoaDon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormHoaDon";
            this.Load += new System.EventHandler(this.FormHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtNgayLapHoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.ComboBox cboMaPhuTung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnThem_PT;
        private System.Windows.Forms.Button btnXoa_HoaDon;
        private System.Windows.Forms.ComboBox cbDiaChiKhachHang;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btn_AddHD;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_KhachHang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}