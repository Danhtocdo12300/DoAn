using DoAnTinHoc1.All_class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace DoAnTinHoc1
{
    public partial class FormPhuTung : Form
    {

        public FormPhuTung()
        {

            InitializeComponent();


        }

        private void HienThiDanhSachPhuTung()
        {
            dgvPhuTung.Rows.Clear();
            var dsphutung = TruyCapDuLieu.khoitao().getDanhSachPhuTung();

            foreach (var PT in TruyCapDuLieu.khoitao().getDanhSachPhuTung())

            {
                dgvPhuTung.Rows.Add(new object[] { PT.MAPT, PT.TENPT, PT.TENLOAIXE, PT.LOAIXE_GASO, PT.TENNHACC, PT.GIAPT });
            }

        }

        private int ViTri = 0;

        private void btnSua_PhuTung_Click(object sender, EventArgs e)
        {
            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachPhuTung().Count) return;
            LoaiXe tenLoaiXe = CXuLyDuLieu.tim_LoaiXeTheoTen(cbTenLX.Text);
            NhaCungCap tenNhaCungCap = CXuLyDuLieu.tim_NhaCungCapTheoTen(cbTenNCC.Text);

            string maPT = txtMaPT.Text;
            string tenPT = txtTenPT.Text;

            string loaiXeGaSo = cbLoaiXe_GaSo.Text;
            int giaPT;
            if (!int.TryParse(txtGiaTien.Text, out giaPT) || giaPT <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá phụ tùng hợp lệ (lớn hơn 0).", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TruyCapDuLieu.khoitao().getDanhSachPhuTung()[ViTri] = new PhuTung(maPT, tenPT, giaPT, loaiXeGaSo, tenLoaiXe, tenNhaCungCap);

            MessageBox.Show("Sửa thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            HienThiDanhSachPhuTung();
        }

        private void btnTim_PhuTung_Click(object sender, EventArgs e)
        {
            var tuKhoaTim = txtTimMa.Text.Trim();
            if (string.IsNullOrEmpty(tuKhoaTim))
            {
                HienThiDanhSachPhuTung();
            }
            else
            {
                List<PhuTung> dsTimDuoc = new List<PhuTung>();
                foreach (var tim in CXuLyDuLieu.layDSPhuTung)
                {
                    if (tim.MAPT.StartsWith(tuKhoaTim, StringComparison.OrdinalIgnoreCase) || tim.TENPT.StartsWith(tuKhoaTim, StringComparison.OrdinalIgnoreCase))
                    {
                        dsTimDuoc.Add(tim);
                    }
                }
                dgvPhuTung.DataSource = dsTimDuoc;
                HienThiDanhSachPhuTung();
            }

        }

        private void btnLuu_PhuTung_Click(object sender, EventArgs e)
        {

            TruyCapDuLieu.ghiFile("DSPT.bin");
            MessageBox.Show("Lưu thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormPhuTung_Load(object sender, EventArgs e)
        {

            TruyCapDuLieu.docFile("DSPT.bin");
            List<PhuTung> dsPT = TruyCapDuLieu.khoitao().getDanhSachPhuTung();
            List<LoaiXe> dsLX = TruyCapDuLieu.khoitao().getDanhSachLoaiXe();
            List<NhaCungCap> dsNCC = TruyCapDuLieu.khoitao().getDanhSachNhaCungCap();
            HienThiDanhSachPhuTung();
            hienThiCboLoaiXe(cbTenLX, dsLX);
            hienThiCboNhaCungCap(cbTenNCC, dsNCC);
        }
        ///
        private void hienThiCboNhaCungCap(ComboBox cbo, List<NhaCungCap> ds)
        {
            List<NhaCungCap> danhsachNhaCungCap = new List<NhaCungCap>();
            cbo.DisplayMember = "TENNCC";
            cbo.DataSource = ds;
        }
        private void hienThiCboLoaiXe(ComboBox cbo, List<LoaiXe> ds)
        {
            List<LoaiXe> danhSachLoaiXe = TruyCapDuLieu.khoitao().getDanhSachLoaiXe();
            cbo.DisplayMember = "TENLOAIXE";
            cbo.DataSource = ds;

        }

        private void btnThem_PhuTung_Click(object sender, EventArgs e)
        {

            if (CXuLyDuLieu.KiemTra_KyTu_DacBiet(txtMaPT.Text) == true)
            {
                MessageBox.Show("Mã phụ tùng không được chứa ký tự đặc biệt", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoaiXe tenLoaiXe = CXuLyDuLieu.tim_LoaiXeTheoTen(cbTenLX.Text);
            if (tenLoaiXe == null)
            {

                MessageBox.Show("Không có loại xe ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            NhaCungCap tenNhaCungCap = CXuLyDuLieu.tim_NhaCungCapTheoTen(cbTenNCC.Text);
            if (tenNhaCungCap == null)
            {
                MessageBox.Show("không có Nhà Cung Cấp","Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //tenNhaCungCap = new NhaCungCap();
                return;
            }

            string maPT = txtMaPT.Text.Trim();
            string tenPT = txtTenPT.Text.Trim();
            string loaiXeGaSo = cbLoaiXe_GaSo.Text.Trim();

            int giaPT;
            if (!int.TryParse(txtGiaTien.Text, out giaPT) || giaPT <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá phụ tùng hợp lệ (lớn hơn 0).", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            PhuTung pt = new PhuTung(maPT, tenPT, giaPT, loaiXeGaSo, tenLoaiXe, tenNhaCungCap);

            if (CXuLyDuLieu.tim_PhuTung(pt.MAPT) == null)
            {
                //TruyCapDuLieu.khoitao().getDanhSachPhuTung().Add(pt);
                CXuLyDuLieu.them_PhuTung(pt);
                MessageBox.Show(" Thêm thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HienThiDanhSachPhuTung();
            }
            else
            {
                MessageBox.Show(" Thêm không thành công ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnXoa_PhuTung_Click(object sender, EventArgs e)
        {
            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachPhuTung().Count) return;
            DialogResult KetQua = MessageBox.Show("Bạn có muốn xóa ", "Thông Báo ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (KetQua == DialogResult.Yes)
            {
                TruyCapDuLieu.khoitao().getDanhSachPhuTung().RemoveAt(ViTri);
                MessageBox.Show(" Xóa thành công ", "Thông Báo ", MessageBoxButtons.OK);
                HienThiDanhSachPhuTung();
            }
        }

        private void dgvPhuTung_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViTri = e.RowIndex;

            if (ViTri < 0 || ViTri >= TruyCapDuLieu.khoitao().getDanhSachPhuTung().Count) return;
            var pt = TruyCapDuLieu.khoitao().getDanhSachPhuTung()[ViTri];

            txtMaPT.Text = pt.MAPT;
            txtTenPT.Text = pt.TENPT;
            cbLoaiXe_GaSo.Text = pt.LOAIXE_GASO;
        }


        private void btnTim_PhuTung_Click_1(object sender, EventArgs e)
        {
            string Timkiem = txtTimMa.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập mã cần tìm ", "Thong Bao", MessageBoxButtons.OK);
            }
         

            var Result = CXuLyDuLieu.tim_PhuTung(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thây mã phụ tùng ", "Thong Bao", MessageBoxButtons.OK);
                dgvPhuTung.Rows.Clear();
                dgvPhuTung.Rows.Add(new object[] { Result.MAPT, Result.TENPT, Result.TENLOAIXE, Result.LOAIXE_GASO, Result.TENNHACC, Result.GIAPT });
            }
            else
            {
                MessageBox.Show("Không tìm thấy mã phụ tùng ", "Thong Bao", MessageBoxButtons.OK);
                HienThiDanhSachPhuTung();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnTimTen_PhuTung_Click(object sender, EventArgs e)
        {
            string Timkiem = txtTimTen.Text;

            if (string.IsNullOrEmpty(Timkiem))
            {
                MessageBox.Show("Vui Lòng nhập tên cần tìm ", "Thông báo ", MessageBoxButtons.OK);
            }
            var Result = CXuLyDuLieu.tim_PhuTungTheoTen(Timkiem);
            if (Result != null)
            {
                MessageBox.Show("Tìm thây tên phụ tùng ", "Thông báo ", MessageBoxButtons.OK);
                dgvPhuTung.Rows.Clear();
                dgvPhuTung.Rows.Add(new object[] { Result.MAPT, Result.TENPT, Result.TENLOAIXE, Result.LOAIXE_GASO, Result.TENNHACC, Result.GIAPT });
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên phụ tùng ", "Thông báo ", MessageBoxButtons.OK);
                HienThiDanhSachPhuTung();
            }
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            HienThiDanhSachPhuTung();
        }

    }
}

