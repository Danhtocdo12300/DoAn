namespace DoAnTinHoc1
{
    partial class FormPhuTung
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPhuTung));
            this.dgvPhuTung = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPT = new System.Windows.Forms.TextBox();
            this.txtTenPT = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.btnThem_PhuTung = new System.Windows.Forms.Button();
            this.btnXoa_PhuTung = new System.Windows.Forms.Button();
            this.btnTimMa_PhuTung = new System.Windows.Forms.Button();
            this.btnSua_PhuTung = new System.Windows.Forms.Button();
            this.txtTimMa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu_PhuTung = new System.Windows.Forms.Button();
            this.cbLoaiXe_GaSo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.btnTimTen_PhuTung = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTenNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTenLX = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPhuTung
            // 
            this.dgvPhuTung.AllowUserToDeleteRows = false;
            this.dgvPhuTung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuTung.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPhuTung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuTung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column4,
            this.Column7,
            this.Column5});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhuTung.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPhuTung.Location = new System.Drawing.Point(14, 269);
            this.dgvPhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhuTung.Name = "dgvPhuTung";
            this.dgvPhuTung.ReadOnly = true;
            this.dgvPhuTung.RowHeadersWidth = 62;
            this.dgvPhuTung.RowTemplate.Height = 28;
            this.dgvPhuTung.Size = new System.Drawing.Size(1043, 314);
            this.dgvPhuTung.TabIndex = 0;
            this.dgvPhuTung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuTung_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MAPT";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "Mã Phụ Tùng";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENPT";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.HeaderText = "Tên Phụ Tùng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TENLOAIXE";
            this.Column6.HeaderText = "Tên Loại Xe ";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LOAIXE_GASO";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic);
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Loại Xe Tương Ứng";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TENNHACC";
            this.Column7.HeaderText = "Tên Nhà Cung Cấp SP";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GIAPT";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Giá Tiền";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Phụ Tùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Phụ Tùng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Giá tiền";
            // 
            // txtMaPT
            // 
            this.txtMaPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaPT.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.Location = new System.Drawing.Point(19, 34);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Size = new System.Drawing.Size(131, 30);
            this.txtMaPT.TabIndex = 5;
            // 
            // txtTenPT
            // 
            this.txtTenPT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenPT.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenPT.Location = new System.Drawing.Point(19, 94);
            this.txtTenPT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenPT.Name = "txtTenPT";
            this.txtTenPT.Size = new System.Drawing.Size(131, 30);
            this.txtTenPT.TabIndex = 6;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGiaTien.Font = new System.Drawing.Font("Bahnschrift Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.Location = new System.Drawing.Point(560, 34);
            this.txtGiaTien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(131, 30);
            this.txtGiaTien.TabIndex = 8;
            // 
            // btnThem_PhuTung
            // 
            this.btnThem_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnThem_PhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_PhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_PhuTung.Image")));
            this.btnThem_PhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_PhuTung.Location = new System.Drawing.Point(16, 18);
            this.btnThem_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem_PhuTung.Name = "btnThem_PhuTung";
            this.btnThem_PhuTung.Size = new System.Drawing.Size(88, 41);
            this.btnThem_PhuTung.TabIndex = 10;
            this.btnThem_PhuTung.Text = "Thêm";
            this.btnThem_PhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_PhuTung.UseVisualStyleBackColor = false;
            this.btnThem_PhuTung.Click += new System.EventHandler(this.btnThem_PhuTung_Click);
            // 
            // btnXoa_PhuTung
            // 
            this.btnXoa_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnXoa_PhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_PhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_PhuTung.Image")));
            this.btnXoa_PhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_PhuTung.Location = new System.Drawing.Point(16, 79);
            this.btnXoa_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa_PhuTung.Name = "btnXoa_PhuTung";
            this.btnXoa_PhuTung.Size = new System.Drawing.Size(88, 42);
            this.btnXoa_PhuTung.TabIndex = 11;
            this.btnXoa_PhuTung.Text = "Xóa";
            this.btnXoa_PhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_PhuTung.UseVisualStyleBackColor = false;
            this.btnXoa_PhuTung.Click += new System.EventHandler(this.btnXoa_PhuTung_Click);
            // 
            // btnTimMa_PhuTung
            // 
            this.btnTimMa_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnTimMa_PhuTung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimMa_PhuTung.BackgroundImage")));
            this.btnTimMa_PhuTung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimMa_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa_PhuTung.Location = new System.Drawing.Point(418, 19);
            this.btnTimMa_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMa_PhuTung.Name = "btnTimMa_PhuTung";
            this.btnTimMa_PhuTung.Size = new System.Drawing.Size(42, 35);
            this.btnTimMa_PhuTung.TabIndex = 12;
            this.btnTimMa_PhuTung.UseVisualStyleBackColor = false;
            this.btnTimMa_PhuTung.Click += new System.EventHandler(this.btnTim_PhuTung_Click_1);
            // 
            // btnSua_PhuTung
            // 
            this.btnSua_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnSua_PhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_PhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_PhuTung.Image")));
            this.btnSua_PhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_PhuTung.Location = new System.Drawing.Point(133, 18);
            this.btnSua_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua_PhuTung.Name = "btnSua_PhuTung";
            this.btnSua_PhuTung.Size = new System.Drawing.Size(88, 41);
            this.btnSua_PhuTung.TabIndex = 13;
            this.btnSua_PhuTung.Text = "Sửa";
            this.btnSua_PhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_PhuTung.UseVisualStyleBackColor = false;
            this.btnSua_PhuTung.Click += new System.EventHandler(this.btnSua_PhuTung_Click);
            // 
            // txtTimMa
            // 
            this.txtTimMa.BackColor = System.Drawing.Color.White;
            this.txtTimMa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimMa.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMa.Location = new System.Drawing.Point(234, 27);
            this.txtTimMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimMa.Name = "txtTimMa";
            this.txtTimMa.Size = new System.Drawing.Size(181, 30);
            this.txtTimMa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tìm Kiếm Theo Mã Phụ Tùng ";
            // 
            // btnLuu_PhuTung
            // 
            this.btnLuu_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnLuu_PhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_PhuTung.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_PhuTung.Image")));
            this.btnLuu_PhuTung.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_PhuTung.Location = new System.Drawing.Point(133, 79);
            this.btnLuu_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu_PhuTung.Name = "btnLuu_PhuTung";
            this.btnLuu_PhuTung.Size = new System.Drawing.Size(88, 42);
            this.btnLuu_PhuTung.TabIndex = 16;
            this.btnLuu_PhuTung.Text = "Lưu ";
            this.btnLuu_PhuTung.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_PhuTung.UseVisualStyleBackColor = false;
            this.btnLuu_PhuTung.Click += new System.EventHandler(this.btnLuu_PhuTung_Click);
            // 
            // cbLoaiXe_GaSo
            // 
            this.cbLoaiXe_GaSo.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLoaiXe_GaSo.FormattingEnabled = true;
            this.cbLoaiXe_GaSo.Items.AddRange(new object[] {
            "Xe Số ",
            "Xe Tay Ga",
            "Xe Côn Tay"});
            this.cbLoaiXe_GaSo.Location = new System.Drawing.Point(171, 94);
            this.cbLoaiXe_GaSo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiXe_GaSo.Name = "cbLoaiXe_GaSo";
            this.cbLoaiXe_GaSo.Size = new System.Drawing.Size(139, 31);
            this.cbLoaiXe_GaSo.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "Loại Xe Tương Ứng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(482, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(192, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "Tìm Kiếm Theo Tên Phụ Tùng ";
            // 
            // txtTimTen
            // 
            this.txtTimTen.BackColor = System.Drawing.Color.White;
            this.txtTimTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimTen.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTen.Location = new System.Drawing.Point(486, 27);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(187, 30);
            this.txtTimTen.TabIndex = 28;
            // 
            // btnTimTen_PhuTung
            // 
            this.btnTimTen_PhuTung.BackColor = System.Drawing.Color.White;
            this.btnTimTen_PhuTung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimTen_PhuTung.BackgroundImage")));
            this.btnTimTen_PhuTung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTen_PhuTung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen_PhuTung.Location = new System.Drawing.Point(676, 19);
            this.btnTimTen_PhuTung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimTen_PhuTung.Name = "btnTimTen_PhuTung";
            this.btnTimTen_PhuTung.Size = new System.Drawing.Size(42, 35);
            this.btnTimTen_PhuTung.TabIndex = 29;
            this.btnTimTen_PhuTung.UseVisualStyleBackColor = false;
            this.btnTimTen_PhuTung.Click += new System.EventHandler(this.btnTimTen_PhuTung_Click);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHienThiTatCa.BackgroundImage")));
            this.btnHienThiTatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.Location = new System.Drawing.Point(8, 6);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(198, 47);
            this.btnHienThiTatCa.TabIndex = 44;
            this.btnHienThiTatCa.Text = "       Hiển Thị Tất Cả ";
            this.btnHienThiTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbTenNCC);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbTenLX);
            this.panel1.Controls.Add(this.txtMaPT);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenPT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbLoaiXe_GaSo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtGiaTien);
            this.panel1.Location = new System.Drawing.Point(14, 42);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 151);
            this.panel1.TabIndex = 45;
            // 
            // cbTenNCC
            // 
            this.cbTenNCC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenNCC.FormattingEnabled = true;
            this.cbTenNCC.Items.AddRange(new object[] {
            "Xe Số ",
            "Xe Tay Ga",
            "Xe Côn Tay"});
            this.cbTenNCC.Location = new System.Drawing.Point(359, 34);
            this.cbTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenNCC.Name = "cbTenNCC";
            this.cbTenNCC.Size = new System.Drawing.Size(139, 31);
            this.cbTenNCC.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(355, 10);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tên Nhà Cung Cấp SP";
            // 
            // cbTenLX
            // 
            this.cbTenLX.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTenLX.FormattingEnabled = true;
            this.cbTenLX.Location = new System.Drawing.Point(171, 34);
            this.cbTenLX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTenLX.Name = "cbTenLX";
            this.cbTenLX.Size = new System.Drawing.Size(139, 31);
            this.cbTenLX.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(167, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 23);
            this.label10.TabIndex = 28;
            this.label10.Text = "Tên Loại Xe";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnHienThiTatCa);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btnTimMa_PhuTung);
            this.panel3.Controls.Add(this.txtTimMa);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtTimTen);
            this.panel3.Controls.Add(this.btnTimTen_PhuTung);
            this.panel3.Location = new System.Drawing.Point(14, 200);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 66);
            this.panel3.TabIndex = 46;
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
            this.label7.Location = new System.Drawing.Point(745, 17);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MinimumSize = new System.Drawing.Size(7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(225, 35);
            this.label7.TabIndex = 45;
            this.label7.Text = "Quản lý Phụ Tùng";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnThem_PhuTung);
            this.panel4.Controls.Add(this.btnLuu_PhuTung);
            this.panel4.Controls.Add(this.btnXoa_PhuTung);
            this.panel4.Controls.Add(this.btnSua_PhuTung);
            this.panel4.Location = new System.Drawing.Point(803, 42);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(254, 150);
            this.panel4.TabIndex = 47;
            // 
            // FormPhuTung
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1211, 598);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPhuTung);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPhuTung";
            this.Text = "DS Phụ Tùng SP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPhuTung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuTung)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhuTung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaPT;
        private System.Windows.Forms.TextBox txtTenPT;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.Button btnThem_PhuTung;
        private System.Windows.Forms.Button btnXoa_PhuTung;
        private System.Windows.Forms.Button btnTimMa_PhuTung;
        private System.Windows.Forms.Button btnSua_PhuTung;
        private System.Windows.Forms.TextBox txtTimMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLuu_PhuTung;
        private System.Windows.Forms.ComboBox cbLoaiXe_GaSo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Button btnTimTen_PhuTung;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbTenLX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}