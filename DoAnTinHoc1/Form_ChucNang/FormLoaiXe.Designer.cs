namespace DoAnTinHoc1.Form_ChucNang
{
    partial class FormLoaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoaiXe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtTenLX = new System.Windows.Forms.TextBox();
            this.txtMaLX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbLoaiXe = new System.Windows.Forms.ComboBox();
            this.btnThem_LoaiXe = new System.Windows.Forms.Button();
            this.btnLuu_LoaiXe = new System.Windows.Forms.Button();
            this.btnXoa_LoaiXe = new System.Windows.Forms.Button();
            this.btnSua_LoaiXe = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.btnTimMa_PhuTung = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.btnTimTen_PhuTung = new System.Windows.Forms.Button();
            this.dgvLoaiXe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTenLX
            // 
            this.txtTenLX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenLX.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLX.Location = new System.Drawing.Point(51, 125);
            this.txtTenLX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenLX.Name = "txtTenLX";
            this.txtTenLX.Size = new System.Drawing.Size(159, 30);
            this.txtTenLX.TabIndex = 10;
            // 
            // txtMaLX
            // 
            this.txtMaLX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaLX.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLX.Location = new System.Drawing.Point(51, 55);
            this.txtMaLX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaLX.Name = "txtMaLX";
            this.txtMaLX.Size = new System.Drawing.Size(159, 30);
            this.txtMaLX.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên Loại Xe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Loại Xe";
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
            this.label7.Location = new System.Drawing.Point(8, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MinimumSize = new System.Drawing.Size(7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 35);
            this.label7.TabIndex = 23;
            this.label7.Text = "Quản lý Loại Xe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Loại Xe Tương Ứng ";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe Số ",
            "Xe Tay Ga",
            "Xe Côn Tay"});
            this.cbLoaiXe.Location = new System.Drawing.Point(245, 55);
            this.cbLoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.Size = new System.Drawing.Size(155, 31);
            this.cbLoaiXe.TabIndex = 29;
            // 
            // btnThem_LoaiXe
            // 
            this.btnThem_LoaiXe.BackColor = System.Drawing.Color.White;
            this.btnThem_LoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_LoaiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_LoaiXe.Image")));
            this.btnThem_LoaiXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_LoaiXe.Location = new System.Drawing.Point(19, 12);
            this.btnThem_LoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem_LoaiXe.Name = "btnThem_LoaiXe";
            this.btnThem_LoaiXe.Size = new System.Drawing.Size(88, 38);
            this.btnThem_LoaiXe.TabIndex = 31;
            this.btnThem_LoaiXe.Text = "Thêm";
            this.btnThem_LoaiXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_LoaiXe.UseVisualStyleBackColor = false;
            this.btnThem_LoaiXe.Click += new System.EventHandler(this.btnThem_LoaiXe_Click);
            // 
            // btnLuu_LoaiXe
            // 
            this.btnLuu_LoaiXe.BackColor = System.Drawing.Color.White;
            this.btnLuu_LoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_LoaiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_LoaiXe.Image")));
            this.btnLuu_LoaiXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_LoaiXe.Location = new System.Drawing.Point(337, 12);
            this.btnLuu_LoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu_LoaiXe.Name = "btnLuu_LoaiXe";
            this.btnLuu_LoaiXe.Size = new System.Drawing.Size(88, 38);
            this.btnLuu_LoaiXe.TabIndex = 34;
            this.btnLuu_LoaiXe.Text = "Lưu ";
            this.btnLuu_LoaiXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_LoaiXe.UseVisualStyleBackColor = false;
            this.btnLuu_LoaiXe.Click += new System.EventHandler(this.btnLuu_LoaiXe_Click);
            // 
            // btnXoa_LoaiXe
            // 
            this.btnXoa_LoaiXe.BackColor = System.Drawing.Color.White;
            this.btnXoa_LoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_LoaiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_LoaiXe.Image")));
            this.btnXoa_LoaiXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_LoaiXe.Location = new System.Drawing.Point(121, 12);
            this.btnXoa_LoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa_LoaiXe.Name = "btnXoa_LoaiXe";
            this.btnXoa_LoaiXe.Size = new System.Drawing.Size(88, 38);
            this.btnXoa_LoaiXe.TabIndex = 32;
            this.btnXoa_LoaiXe.Text = "Xóa";
            this.btnXoa_LoaiXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_LoaiXe.UseVisualStyleBackColor = false;
            this.btnXoa_LoaiXe.Click += new System.EventHandler(this.btnXoa_LoaiXe_Click);
            // 
            // btnSua_LoaiXe
            // 
            this.btnSua_LoaiXe.BackColor = System.Drawing.Color.White;
            this.btnSua_LoaiXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_LoaiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_LoaiXe.Image")));
            this.btnSua_LoaiXe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_LoaiXe.Location = new System.Drawing.Point(233, 12);
            this.btnSua_LoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua_LoaiXe.Name = "btnSua_LoaiXe";
            this.btnSua_LoaiXe.Size = new System.Drawing.Size(88, 38);
            this.btnSua_LoaiXe.TabIndex = 33;
            this.btnSua_LoaiXe.Text = "Sửa";
            this.btnSua_LoaiXe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_LoaiXe.UseVisualStyleBackColor = false;
            this.btnSua_LoaiXe.Click += new System.EventHandler(this.btnSua_LoaiXe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(225, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Tìm Kiếm Theo Mã ";
            // 
            // txtTimMa
            // 
            this.txtTimMa.BackColor = System.Drawing.Color.White;
            this.txtTimMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimMa.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMa.Location = new System.Drawing.Point(229, 122);
            this.txtTimMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(124, 30);
            this.txtTimMa.TabIndex = 37;
            // 
            // btnTimMa_PhuTung
            // 
            this.btnTimMa_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnTimMa_PhuTung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimMa_PhuTung.BackgroundImage")));
            this.btnTimMa_PhuTung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimMa_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa_PhuTung.Location = new System.Drawing.Point(356, 114);
            this.btnTimMa_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMa_PhuTung.Name = "btnTimMa_PhuTung";
            this.btnTimMa_PhuTung.Size = new System.Drawing.Size(39, 36);
            this.btnTimMa_PhuTung.TabIndex = 36;
            this.btnTimMa_PhuTung.UseVisualStyleBackColor = false;
            this.btnTimMa_PhuTung.Click += new System.EventHandler(this.btnTimMa_PhuTung_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(403, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tìm Kiếm Theo Tên";
            // 
            // txtTimTen
            // 
            this.txtTimTen.BackColor = System.Drawing.Color.White;
            this.txtTimTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimTen.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTen.Location = new System.Drawing.Point(407, 122);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(123, 30);
            this.txtTimTen.TabIndex = 40;
            // 
            // btnTimTen_PhuTung
            // 
            this.btnTimTen_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnTimTen_PhuTung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimTen_PhuTung.BackgroundImage")));
            this.btnTimTen_PhuTung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTen_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen_PhuTung.Location = new System.Drawing.Point(533, 114);
            this.btnTimTen_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimTen_PhuTung.Name = "btnTimTen_PhuTung";
            this.btnTimTen_PhuTung.Size = new System.Drawing.Size(39, 36);
            this.btnTimTen_PhuTung.TabIndex = 41;
            this.btnTimTen_PhuTung.UseVisualStyleBackColor = false;
            this.btnTimTen_PhuTung.Click += new System.EventHandler(this.btnTimTen_PhuTung_Click);
            // 
            // dgvLoaiXe
            // 
            this.dgvLoaiXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiXe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvLoaiXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiXe.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLoaiXe.Location = new System.Drawing.Point(8, 155);
            this.dgvLoaiXe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvLoaiXe.Name = "dgvLoaiXe";
            this.dgvLoaiXe.RowHeadersWidth = 62;
            this.dgvLoaiXe.RowTemplate.Height = 28;
            this.dgvLoaiXe.Size = new System.Drawing.Size(609, 352);
            this.dgvLoaiXe.TabIndex = 42;
            this.dgvLoaiXe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiXe_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAIXE";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Mã Loại Xe";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Tên Loại Xe";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LOAIXE_TUONGUNG";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column3.HeaderText = "Loại Xe ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHienThiTatCa.BackgroundImage")));
            this.btnHienThiTatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.Location = new System.Drawing.Point(8, 98);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(213, 53);
            this.btnHienThiTatCa.TabIndex = 43;
            this.btnHienThiTatCa.Text = "     Hiển Thị Tất Cả ";
            this.btnHienThiTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaLX);
            this.panel1.Controls.Add(this.txtTenLX);
            this.panel1.Controls.Add(this.cbLoaiXe);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(621, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 197);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXoa_LoaiXe);
            this.panel2.Controls.Add(this.btnThem_LoaiXe);
            this.panel2.Controls.Add(this.btnSua_LoaiXe);
            this.panel2.Controls.Add(this.btnLuu_LoaiXe);
            this.panel2.Location = new System.Drawing.Point(621, 365);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 66);
            this.panel2.TabIndex = 45;
            // 
            // FormLoaiXe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 565);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTimTen_PhuTung);
            this.Controls.Add(this.dgvLoaiXe);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimMa_PhuTung);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimMa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormLoaiXe";
            this.Text = "FormLoaiXe";
            this.Load += new System.EventHandler(this.FormLoaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTenLX;
        private System.Windows.Forms.TextBox txtMaLX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLoaiXe;
        private System.Windows.Forms.Button btnThem_LoaiXe;
        private System.Windows.Forms.Button btnLuu_LoaiXe;
        private System.Windows.Forms.Button btnXoa_LoaiXe;
        private System.Windows.Forms.Button btnSua_LoaiXe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.Button btnTimMa_PhuTung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Button btnTimTen_PhuTung;
        private System.Windows.Forms.DataGridView dgvLoaiXe;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}