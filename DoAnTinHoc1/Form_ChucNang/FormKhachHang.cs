using DoAnTinHoc1.All_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnTinHoc1
{
    public partial class FormKhachHang : Form
    {
        public FormKhachHang()
        {
            InitializeComponent();

        }
        private int ViTri = 0;



        private void HienThi(DataGridView dgv, List<KhachHang> ds)
        {
            //dgvKhachHang.Rows.Clear();
            //foreach (var kh in TruyCapDuLieu.khoitao().getDanhSachKhachHang())
            //{
            //    dgvKhachHang.Rows.Add(kh.MAKH, kh.TENKH, kh.SODT, kh.DIACHI);
            //}

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds;
            dgv.DataSource = bindingSource;



        }
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            //List<KhachHang> ds = TruyCapDuLieu.khoitao().getDanhSachKhachHang();
            //TruyCapDuLieu.docFile("DSPT.bin");
            HienThi(dgvKhachHang, CXuLyDuLieu.GetKhachHangXL());
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            //HienThi();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViTri = e.RowIndex;

            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachKhachHang().Count) return;
            KhachHang kh = new KhachHang();
            kh = TruyCapDuLieu.khoitao().getDanhSachKhachHang()[ViTri];
            txtMaKhacHang.Text = kh.MAKH;
            txtTenKhachHang.Text = kh.TENKH;
            txtSoDienThoai.Text = kh.SODT;
            txtDiaChi.Text = kh.DIACHI;

        }


        private void btnThem_KhachHang_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhacHang.Text.Trim();
            if (CXuLyDuLieu.KiemTra_KyTu_DacBiet(maKH) == true)
            {
                MessageBox.Show("Mã Khách hàng không được chứa ký tự đặc biệt ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtSoDienThoai.Text.Contains('-'))
            {
                MessageBox.Show("Số điện thoại không được chứa ký tự -", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string tenKH = txtTenKhachHang.Text.Trim();
            string soDT = txtSoDienThoai.Text.Trim();
            string diaChi = txtDiaChi.Text.Trim();

            KhachHang khach = new KhachHang(maKH, tenKH, soDT, diaChi);

            if (CXuLyDuLieu.tim_KhachHang(maKH) == null)
            {

                CXuLyDuLieu.them_KhachHang(khach);
                MessageBox.Show(" Thêm thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThi(dgvKhachHang, CXuLyDuLieu.GetKhachHangXL());
            }
            else
            {
                MessageBox.Show(" Thêm không thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnLuu_KhachHang_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile("DSPT.bin");
            MessageBox.Show("Lưu thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimMa_KhachHang_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimMaKH.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập mã cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = CXuLyDuLieu.tim_KhachHang(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thây mã Khách hàng  ", "Thông báo ", MessageBoxButtons.OK);
                dgvKhachHang.Rows.Clear();
                dgvKhachHang.Rows.Add(new object[] { Result.MAKH, Result.TENKH, Result.SODT, Result.DIACHI });
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã Khách hàng ", "Thông báo ", MessageBoxButtons.OK);
                //HienThi();
            }
        }

        private void btnTimTen_KhachHang_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimTenKH.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập tên cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = CXuLyDuLieu.tim_KhachHangTheoTen(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thấy tên Khách hàng  ", "Thông báo ", MessageBoxButtons.OK);
                dgvKhachHang.Rows.Clear();
                dgvKhachHang.Rows.Add(new object[] { Result.MAKH, Result.TENKH, Result.SODT, Result.DIACHI });
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên Khách hàng ", "Thông báo ", MessageBoxButtons.OK);
                //HienThi();
            }
        }

        private void btnXoa_KhachHang_Click(object sender, EventArgs e)
        {
            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachKhachHang().Count) return;
            DialogResult KetQua = MessageBox.Show("Bạn có muốn xóa ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (KetQua == DialogResult.Yes)
            {
                TruyCapDuLieu.khoitao().getDanhSachKhachHang().RemoveAt(ViTri);
                MessageBox.Show(" Xóa thành công ", "Thông Báo ", MessageBoxButtons.OK);
                //HienThi();
            }
        }

        private void btnSua_KhachHang_Click(object sender, EventArgs e)
        {
            if (ViTri < 0) return;
            string maKH = txtMaKhacHang.Text;
            string tenKH = txtTenKhachHang.Text;
            string soDT = txtSoDienThoai.Text;
            string diaChi = txtDiaChi.Text;

            TruyCapDuLieu.khoitao().getDanhSachKhachHang()[ViTri] = new KhachHang(maKH, tenKH, soDT, diaChi);

            MessageBox.Show("Sửa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //HienThi();
        }
    }
}
