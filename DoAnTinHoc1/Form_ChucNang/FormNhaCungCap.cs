using DoAnTinHoc1.All_class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{
    public partial class FormNhaCungCap : Form
    {
        public FormNhaCungCap()
        {
            InitializeComponent();

        }
        private int ViTri = 0;

        //bool kiemtraTonTai(string maNCC)
        //{
        //    foreach (var a in TruyCapDuLieu.khoitao().getDanhSachNhaCungCap())
        //        if (a.MANCC == maNCC) return true;
        //    return false;
        //}

        private void HienThi()
        {
            dgvNhaCungCap.Rows.Clear();
            foreach (var ncc in TruyCapDuLieu.khoitao().getDanhSachNhaCungCap())
            {
                dgvNhaCungCap.Rows.Add(ncc.MANCC, ncc.TENNCC, ncc.SODTNCC, ncc.DIACHINCC);
            }
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            TruyCapDuLieu.docFile("DSPT.bin");
            List<NhaCungCap> ds = new List<NhaCungCap>();
            ds = TruyCapDuLieu.khoitao().getDanhSachNhaCungCap();

            HienThi();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViTri = e.RowIndex;

            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Count) return;
            NhaCungCap ncc = new NhaCungCap();
            ncc = TruyCapDuLieu.khoitao().getDanhSachNhaCungCap()[ViTri];
            txtMaNCC.Text = ncc.MANCC;
            txtTenNCC.Text = ncc.TENNCC;
            txtSoDTNCC.Text = ncc.SODTNCC;
            txtDiaChi.Text = ncc.DIACHINCC;
        }

        private void btnThem_NhaCungCap_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string soDTNCC = txtSoDTNCC.Text;
            string diaChiNCC = txtDiaChi.Text;

            NhaCungCap nhaCungCap = new NhaCungCap(maNCC, tenNCC, soDTNCC, diaChiNCC);

            if (CXuLyDuLieu.tim_NhaCungCap(maNCC) == null)
            {
                //TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Add(nhaCungCap);
                CXuLyDuLieu.them_NhaCungCap(nhaCungCap);
                MessageBox.Show("Thêm thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThi();
            }
            else
            {
                MessageBox.Show("Thêm không thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_NhaCungCap_Click(object sender, EventArgs e)
        {
            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Count) return;
            DialogResult KetQua = MessageBox.Show("Bạn có muốn xóa ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (KetQua == DialogResult.Yes)
            {
                TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().RemoveAt(ViTri);
                MessageBox.Show(" Xóa thành công ", "Thông Báo ", MessageBoxButtons.OK);
                HienThi();
            }
        }

        private void btnSua_NhaCungCap_Click(object sender, EventArgs e)
        {
            if (ViTri < 0) return;

            string maNCC = txtMaNCC.Text;
            string tenNCC = txtTenNCC.Text;
            string soDTNCC = txtSoDTNCC.Text;
            string diaChiNCC = txtDiaChi.Text;
            TruyCapDuLieu.khoitao().getDanhSachNhaCungCap()[ViTri] = new NhaCungCap(maNCC, tenNCC, soDTNCC, diaChiNCC);

            MessageBox.Show("Sửa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void btnLuu_NhaCungCap_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile("DSPT.bin");
            MessageBox.Show("Lưu thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private NhaCungCap TimMaNCC(string maNCC)
        {
            foreach (var a in TruyCapDuLieu.khoitao().getDanhSachNhaCungCap())
                if (a.MANCC == maNCC) return a;
            return null;
        }

        private NhaCungCap TimTenNCC(string tenNCC)
        {
            foreach (var a in TruyCapDuLieu.khoitao().getDanhSachNhaCungCap())
                if (a.TENNCC == tenNCC) return a;
            return null;
        }

        private void btnTimMa_KhachHang_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimMaNCC.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập mã cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = this.TimMaNCC(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thây mã Nhà Cung cấp ", "Thông báo ", MessageBoxButtons.OK);
                dgvNhaCungCap.Rows.Clear();
                dgvNhaCungCap.Rows.Add(new object[] { Result.MANCC, Result.TENNCC, Result.SODTNCC, Result.DIACHINCC });
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã Nhà Cung cấp ", "Thông báo ", MessageBoxButtons.OK);
                HienThi();
            }
        }

        private void btnTimTen_KhachHang_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimTenNCC.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập tên cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = this.TimTenNCC(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thấy tên Nhà Cung cấp   ", "Thông báo ", MessageBoxButtons.OK);
                dgvNhaCungCap.Rows.Clear();
                dgvNhaCungCap.Rows.Add(new object[] { Result.MANCC, Result.TENNCC, Result.SODTNCC, Result.DIACHINCC });
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên Nhà Cung cấp  ", "Thông báo ", MessageBoxButtons.OK);
                HienThi();
            }
        }
    }
}
