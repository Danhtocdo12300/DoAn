using DoAnTinHoc1.All_class;
using System;
using System.Windows.Forms;

namespace DoAnTinHoc1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            TruyCapDuLieu.docFile("DSPT.bin");
        }



        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            const string message = " bạn có muốn thoát chương trình? ";
            const string caption = " Thông Báo! ";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaikhoan.Text == "Admin" && txtMatkhau.Text == TruyCapDuLieu.password)
            {
                labelSai.Visible = false;

                this.Hide();
                QuanLyPT.Instance.Show();

            }
            else
            {
                labelSai.Visible = true;
                txtMatkhau.Clear();

            }
        }

        private void lbQuenMatKhau_Click(object sender, EventArgs e)
        {

        }
    }
}
