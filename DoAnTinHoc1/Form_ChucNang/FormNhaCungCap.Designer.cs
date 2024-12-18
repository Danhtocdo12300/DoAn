namespace DoAnTinHoc1.Form_ChucNang
{
    partial class FormNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhaCungCap));
            this.dgvNhaCungCap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThem_NhaCungCap = new System.Windows.Forms.Button();
            this.btnLuu_NhaCungCap = new System.Windows.Forms.Button();
            this.btnXoa_NhaCungCap = new System.Windows.Forms.Button();
            this.btnSua_NhaCungCap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoDTNCC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimMa_KhachHang = new System.Windows.Forms.Button();
            this.txtTimMaNCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimTenNCC = new System.Windows.Forms.TextBox();
            this.btnTimTen_KhachHang = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            this.dgvNhaCungCap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaCungCap.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvNhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvNhaCungCap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNhaCungCap.Location = new System.Drawing.Point(15, 154);
            this.dgvNhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNhaCungCap.Name = "dgvNhaCungCap";
            this.dgvNhaCungCap.RowHeadersWidth = 62;
            this.dgvNhaCungCap.RowTemplate.Height = 28;
            this.dgvNhaCungCap.Size = new System.Drawing.Size(621, 356);
            this.dgvNhaCungCap.TabIndex = 44;
            this.dgvNhaCungCap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANCC";
            this.Column1.HeaderText = "Mã Nhà Cung Cấp ";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TENNCC";
            this.Column2.HeaderText = "Tên Nhà Cung Cấp";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SODTNCC";
            this.Column3.HeaderText = "Số Điện Thoại";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DIACHINCC";
            this.Column4.HeaderText = "Địa Chỉ";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnThem_NhaCungCap);
            this.panel4.Controls.Add(this.btnLuu_NhaCungCap);
            this.panel4.Controls.Add(this.btnXoa_NhaCungCap);
            this.panel4.Controls.Add(this.btnSua_NhaCungCap);
            this.panel4.Location = new System.Drawing.Point(641, 154);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(414, 79);
            this.panel4.TabIndex = 50;
            // 
            // btnThem_NhaCungCap
            // 
            this.btnThem_NhaCungCap.BackColor = System.Drawing.Color.White;
            this.btnThem_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_NhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_NhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btnThem_NhaCungCap.Image")));
            this.btnThem_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem_NhaCungCap.Location = new System.Drawing.Point(15, 11);
            this.btnThem_NhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem_NhaCungCap.Name = "btnThem_NhaCungCap";
            this.btnThem_NhaCungCap.Size = new System.Drawing.Size(88, 41);
            this.btnThem_NhaCungCap.TabIndex = 10;
            this.btnThem_NhaCungCap.Text = "Thêm";
            this.btnThem_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem_NhaCungCap.UseVisualStyleBackColor = false;
            this.btnThem_NhaCungCap.Click += new System.EventHandler(this.btnThem_NhaCungCap_Click);
            // 
            // btnLuu_NhaCungCap
            // 
            this.btnLuu_NhaCungCap.BackColor = System.Drawing.Color.White;
            this.btnLuu_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu_NhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu_NhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu_NhaCungCap.Image")));
            this.btnLuu_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu_NhaCungCap.Location = new System.Drawing.Point(316, 11);
            this.btnLuu_NhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu_NhaCungCap.Name = "btnLuu_NhaCungCap";
            this.btnLuu_NhaCungCap.Size = new System.Drawing.Size(88, 42);
            this.btnLuu_NhaCungCap.TabIndex = 16;
            this.btnLuu_NhaCungCap.Text = "Lưu ";
            this.btnLuu_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu_NhaCungCap.UseVisualStyleBackColor = false;
            this.btnLuu_NhaCungCap.Click += new System.EventHandler(this.btnLuu_NhaCungCap_Click);
            // 
            // btnXoa_NhaCungCap
            // 
            this.btnXoa_NhaCungCap.BackColor = System.Drawing.Color.White;
            this.btnXoa_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_NhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_NhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa_NhaCungCap.Image")));
            this.btnXoa_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa_NhaCungCap.Location = new System.Drawing.Point(114, 12);
            this.btnXoa_NhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa_NhaCungCap.Name = "btnXoa_NhaCungCap";
            this.btnXoa_NhaCungCap.Size = new System.Drawing.Size(88, 42);
            this.btnXoa_NhaCungCap.TabIndex = 11;
            this.btnXoa_NhaCungCap.Text = "Xóa";
            this.btnXoa_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa_NhaCungCap.UseVisualStyleBackColor = false;
            this.btnXoa_NhaCungCap.Click += new System.EventHandler(this.btnXoa_NhaCungCap_Click);
            // 
            // btnSua_NhaCungCap
            // 
            this.btnSua_NhaCungCap.BackColor = System.Drawing.Color.White;
            this.btnSua_NhaCungCap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_NhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_NhaCungCap.Image = ((System.Drawing.Image)(resources.GetObject("btnSua_NhaCungCap.Image")));
            this.btnSua_NhaCungCap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua_NhaCungCap.Location = new System.Drawing.Point(218, 12);
            this.btnSua_NhaCungCap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua_NhaCungCap.Name = "btnSua_NhaCungCap";
            this.btnSua_NhaCungCap.Size = new System.Drawing.Size(88, 41);
            this.btnSua_NhaCungCap.TabIndex = 13;
            this.btnSua_NhaCungCap.Text = "Sửa";
            this.btnSua_NhaCungCap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua_NhaCungCap.UseVisualStyleBackColor = false;
            this.btnSua_NhaCungCap.Click += new System.EventHandler(this.btnSua_NhaCungCap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMaNCC);
            this.panel1.Controls.Add(this.txtTenNCC);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSoDTNCC);
            this.panel1.Location = new System.Drawing.Point(641, 244);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 266);
            this.panel1.TabIndex = 49;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNCC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(37, 40);
            this.txtMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(136, 30);
            this.txtMaNCC.TabIndex = 13;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNCC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(37, 118);
            this.txtTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(136, 30);
            this.txtTenNCC.TabIndex = 14;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiaChi.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(226, 94);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(159, 109);
            this.txtDiaChi.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số Điện Thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã Nhà Cung Cấp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 70);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Địa Chỉ";
            // 
            // txtSoDTNCC
            // 
            this.txtSoDTNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDTNCC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoDTNCC.Location = new System.Drawing.Point(223, 40);
            this.txtSoDTNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoDTNCC.Name = "txtSoDTNCC";
            this.txtSoDTNCC.Size = new System.Drawing.Size(159, 30);
            this.txtSoDTNCC.TabIndex = 17;
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
            this.label7.Size = new System.Drawing.Size(284, 35);
            this.label7.TabIndex = 51;
            this.label7.Text = "Quản lý Nhà Cung Cấp";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.BackColor = System.Drawing.Color.White;
            this.btnHienThiTatCa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHienThiTatCa.BackgroundImage")));
            this.btnHienThiTatCa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.Location = new System.Drawing.Point(15, 103);
            this.btnHienThiTatCa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(198, 47);
            this.btnHienThiTatCa.TabIndex = 58;
            this.btnHienThiTatCa.Text = "       Hiển Thị Tất Cả ";
            this.btnHienThiTatCa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHienThiTatCa.UseVisualStyleBackColor = false;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(224, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 23);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tìm Mã Nhà Cung Cấp\r\n";
            // 
            // btnTimMa_KhachHang
            // 
            this.btnTimMa_KhachHang.BackColor = System.Drawing.Color.White;
            this.btnTimMa_KhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimMa_KhachHang.BackgroundImage")));
            this.btnTimMa_KhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimMa_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMa_KhachHang.Location = new System.Drawing.Point(371, 111);
            this.btnTimMa_KhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimMa_KhachHang.Name = "btnTimMa_KhachHang";
            this.btnTimMa_KhachHang.Size = new System.Drawing.Size(42, 35);
            this.btnTimMa_KhachHang.TabIndex = 52;
            this.btnTimMa_KhachHang.UseVisualStyleBackColor = false;
            this.btnTimMa_KhachHang.Click += new System.EventHandler(this.btnTimMa_KhachHang_Click);
            // 
            // txtTimMaNCC
            // 
            this.txtTimMaNCC.BackColor = System.Drawing.Color.White;
            this.txtTimMaNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimMaNCC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimMaNCC.Location = new System.Drawing.Point(228, 120);
            this.txtTimMaNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimMaNCC.Name = "txtTimMaNCC";
            this.txtTimMaNCC.Size = new System.Drawing.Size(140, 30);
            this.txtTimMaNCC.TabIndex = 53;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(428, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 55;
            this.label9.Text = "Tìm Tên Nhà Cung Cấp\r\n";
            // 
            // txtTimTenNCC
            // 
            this.txtTimTenNCC.BackColor = System.Drawing.Color.White;
            this.txtTimTenNCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimTenNCC.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimTenNCC.Location = new System.Drawing.Point(432, 120);
            this.txtTimTenNCC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimTenNCC.Name = "txtTimTenNCC";
            this.txtTimTenNCC.Size = new System.Drawing.Size(141, 30);
            this.txtTimTenNCC.TabIndex = 56;
            // 
            // btnTimTen_KhachHang
            // 
            this.btnTimTen_KhachHang.BackColor = System.Drawing.Color.White;
            this.btnTimTen_KhachHang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimTen_KhachHang.BackgroundImage")));
            this.btnTimTen_KhachHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimTen_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTen_KhachHang.Location = new System.Drawing.Point(577, 115);
            this.btnTimTen_KhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimTen_KhachHang.Name = "btnTimTen_KhachHang";
            this.btnTimTen_KhachHang.Size = new System.Drawing.Size(42, 35);
            this.btnTimTen_KhachHang.TabIndex = 57;
            this.btnTimTen_KhachHang.UseVisualStyleBackColor = false;
            this.btnTimTen_KhachHang.Click += new System.EventHandler(this.btnTimTen_KhachHang_Click);
            // 
            // FormNhaCungCap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 565);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTimMa_KhachHang);
            this.Controls.Add(this.txtTimMaNCC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTimTenNCC);
            this.Controls.Add(this.btnTimTen_KhachHang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNhaCungCap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormNhaCungCap";
            this.Text = "FormNhaCungCap";
            this.Load += new System.EventHandler(this.FormNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaCungCap)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThem_NhaCungCap;
        private System.Windows.Forms.Button btnLuu_NhaCungCap;
        private System.Windows.Forms.Button btnXoa_NhaCungCap;
        private System.Windows.Forms.Button btnSua_NhaCungCap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoDTNCC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTimMa_KhachHang;
        private System.Windows.Forms.TextBox txtTimMaNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimTenNCC;
        private System.Windows.Forms.Button btnTimTen_KhachHang;
    }
}