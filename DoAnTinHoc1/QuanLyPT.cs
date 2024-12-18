using DoAnTinHoc1.All_class;
using DoAnTinHoc1.Form_ChucNang;
using System;
using System.Windows.Forms;

namespace DoAnTinHoc1
{
    public partial class QuanLyPT : Form
    {
        static QuanLyPT _instance;
        public static QuanLyPT Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new QuanLyPT();
                return _instance;
            }
        }

        public QuanLyPT()
        {
            InitializeComponent();
            _instance = this;
            Chuyenform(new FormTrangChu());
        }
        public void Chuyenform(Form form) // Chuyen doi form
        {
            if (!panel_body.Controls.Contains(form))
            {

                if (panel_body.Controls.Count > 0)
                {
                    foreach (var control in panel_body.Controls)
                    {
                        panel_body.Controls.Remove((Control)control);
                        ((Control)control).Dispose();
                    }

                }
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;

                panel_body.Controls.Clear();
                panel_body.Controls.Add(form);
                form.Show();
            }
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            {
                const string message = " bạn có muốn đăng xuất ";
                const string caption = " Thông Báo! ";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Login login = new Login();

                    login.Show();
                    this.Hide();

                }
            }
        }


        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            FormKhachHang formLoaiXe = new FormKhachHang();
            Chuyenform(formLoaiXe);
        }



        private void btnPhuTung_LoaiXe_Click(object sender, EventArgs e)
        {
            FormPhuTung formPhuTung = new FormPhuTung();
            Chuyenform(formPhuTung);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormTrangChu formTrangChu = new FormTrangChu();
            Chuyenform(formTrangChu);
        }

        private void btnHoadon_Click(object sender, EventArgs e)
        {
            Chuyenform(FormQuanLyHoaDon.Instance);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FormLoaiXe formLoaiXe = new FormLoaiXe();
            Chuyenform(formLoaiXe);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormKhoHang formKhoHang = new FormKhoHang();
            Chuyenform(formKhoHang);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormNhaCungCap formNhaCungCap = new FormNhaCungCap();
            Chuyenform(formNhaCungCap);
        }

        private void btnLuu_All_Click(object sender, EventArgs e)
        {

        }

        private void QuanLyPT_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.docFile("DSPT.bin");
        }

        private void btnLuu_HoaDon_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
    }
}
