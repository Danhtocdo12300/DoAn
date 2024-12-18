using DoAnTinHoc1.All_class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{
    public partial class FormLoaiXe : Form
    {

        public FormLoaiXe()
        {
            InitializeComponent();
        }

        private int vitri = 0;

        //bool kiemtraTonTai(string mals)
        //{
        //    foreach (var a in TruyCapDuLieu.khoitao().getDanhSachLoaiXe())
        //        if (a.MALOAIXE == mals) return true;
        //    return false;
        //}

        //private LoaiXe TimMaLS(string mals)
        //{
        //    foreach (var a in TruyCapDuLieu.khoitao().getDanhSachLoaiXe())
        //        if (a.MALOAIXE == mals) return a;
        //    return null;
        //}

        //private LoaiXe TimTenLS(string tenls)
        //{
        //    foreach (var a in TruyCapDuLieu.khoitao().getDanhSachLoaiXe())
        //        if (a.TENLOAIXE == tenls) return a;
        //    return null;
        //}

        private void HienThi()
        {
            dgvLoaiXe.Rows.Clear();
            foreach (var ls in TruyCapDuLieu.khoitao().getDanhSachLoaiXe())
            {
                dgvLoaiXe.Rows.Add(ls.MALOAIXE, ls.TENLOAIXE, ls.LOAIXE_TUONGUNG);
            }
        }


        private void dgvLoaiXe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;

            if (vitri < 0 || vitri >= TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Count) return;
            LoaiXe ls = new LoaiXe();
            ls = TruyCapDuLieu.khoitao().getDanhSachLoaiXe()[vitri];
            txtMaLX.Text = ls.MALOAIXE;
            txtTenLX.Text = ls.TENLOAIXE;

            cbLoaiXe.Text = ls.LOAIXE_TUONGUNG;


        }

        private void btnThem_LoaiXe_Click(object sender, EventArgs e)
        {
            string maLS = txtMaLX.Text;
            string tenLS = txtTenLX.Text;
            string loaixe_TuongUng = cbLoaiXe.Text;

            LoaiXe ls = new LoaiXe(maLS, tenLS, loaixe_TuongUng);

            if (CXuLyDuLieu.tim_LoaiXe(maLS) == null)
            {
                //TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Add(ls);
                CXuLyDuLieu.them_LoaiXe(ls);
                MessageBox.Show(" Thêm thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThi();
            }
            else
            {
                MessageBox.Show(" Thêm không thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void btnXoa_LoaiXe_Click(object sender, EventArgs e)
        {
            if (vitri < 0 || vitri >= TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Count) return;
            DialogResult KetQua = MessageBox.Show("Bạn có muốn xóa ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (KetQua == DialogResult.Yes)
            {
                TruyCapDuLieu.khoitao().getDanhSachLoaiXe().RemoveAt(vitri);
                MessageBox.Show(" Xóa thành công ", "Thông Báo ", MessageBoxButtons.OK);
                HienThi();
            }

        }

        private void btnSua_LoaiXe_Click(object sender, EventArgs e)
        {
            if (vitri < 0) return;
            string maLS = txtMaLX.Text;
            string tenLS = txtTenLX.Text;

            string loaixe_TuongUng = cbLoaiXe.Text;

            TruyCapDuLieu.khoitao().getDanhSachLoaiXe()[vitri] = new LoaiXe(maLS, tenLS, loaixe_TuongUng);

            MessageBox.Show("Sửa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThi();
        }

        private void btnLuu_LoaiXe_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile("DSPT.bin");
            MessageBox.Show("Lưu thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTimMa_PhuTung_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimMa.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập mã cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = CXuLyDuLieu.tim_LoaiXe(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thây mã Loại Xe ", "Thông báo ", MessageBoxButtons.OK);
                dgvLoaiXe.Rows.Clear();
                dgvLoaiXe.Rows.Add(new object[] { Result.MALOAIXE, Result.TENLOAIXE, Result.LOAIXE_TUONGUNG });
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã Loại Xe ", "Thông báo ", MessageBoxButtons.OK);
                HienThi();
            }
        }

        private void dgvLoaiXe_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            vitri = e.RowIndex;

            if (vitri < 0 || vitri >= TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Count) return;
            LoaiXe ls = new LoaiXe();
            ls = TruyCapDuLieu.khoitao().getDanhSachLoaiXe()[vitri];
            txtMaLX.Text = ls.MALOAIXE;
            txtTenLX.Text = ls.TENLOAIXE;
            cbLoaiXe.Text = ls.LOAIXE_TUONGUNG;

        }

        private void btnTimTen_PhuTung_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimTen.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập tên cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = CXuLyDuLieu.tim_LoaiXeTheoTen(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thấy tên Loại Xe ", "Thông báo ", MessageBoxButtons.OK);
                dgvLoaiXe.Rows.Clear();
                dgvLoaiXe.Rows.Add(new object[] { Result.MALOAIXE, Result.TENLOAIXE, Result.LOAIXE_TUONGUNG });
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên Loại Xe ", "Thông báo ", MessageBoxButtons.OK);
                HienThi();
            }
        }

        private void FormLoaiXe_Load(object sender, EventArgs e)
        {
            List<LoaiXe> ds = TruyCapDuLieu.khoitao().getDanhSachLoaiXe();
            TruyCapDuLieu.docFile("DSPT.bin");
            HienThi();
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThi();
        }
    }
}
