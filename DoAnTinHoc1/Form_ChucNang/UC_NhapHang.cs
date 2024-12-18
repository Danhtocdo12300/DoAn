using DoAnTinHoc1.All_class;
using System;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{
    public partial class UC_NhapHang : UserControl
    {
        public UC_NhapHang()
        {
            InitializeComponent();


        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            hienThiMoi();
        }

        private void hienThiMoi()
        {
            TruyCapDuLieu.docFile("DSPT.bin");



            hienThiDanhSachPhuTung();
        }

        private void hienThiDanhSachPhuTung()
        {
            dgvDanhSachSanPham.Rows.Clear();
            foreach (var a in TruyCapDuLieu.khoitao().getDanhSachPhuTung())
            {
                dgvDanhSachSanPham.Rows.Add(new object[]
                {
                    a.MAPT,
                    a.TENPT,

                    a.TENLOAIXE,
                    a.LOAIXE_GASO,
                     a.TENNHACC,
                    a.GIAPT,



                });
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (dgvDanhSachSanPham.SelectedRows.Count > 0)
            {
                int soLuongNhap = 0;

                var selectedRow = dgvDanhSachSanPham.SelectedRows[0].Cells;

                if (!int.TryParse(txtSoLuong.Text, out soLuongNhap) || soLuongNhap <= 0)
                {
                    MessageBox.Show("Ô số lượng phải nhập là số nguyên dương", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string maPT = selectedRow[0].Value.ToString(); // Lấy mã phụ tùng từ cột đầu tiên
                var phuTung = CXuLyDuLieu.tim_PhuTung(maPT);   // Tìm phụ tùng trong danh sách

                if (phuTung != null)
                {
                    var phuTungKho = CXuLyDuLieu.tim_PhuTungNhapKho(maPT); // Kiểm tra phụ tùng trong kho

                    if (phuTungKho != null)
                    {
                        phuTungKho.SoLuong += soLuongNhap;
                        MessageBox.Show("Đã cập nhật số lượng phụ tùng có mã " + maPT, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var newPhuTungKho = new PhuTung_Kho(phuTung, soLuongNhap, DateTime.Now);
                        CXuLyDuLieu.them_PhuTungNhapKho(newPhuTungKho);
                        MessageBox.Show("Đã thêm phụ tùng mới có mã " + maPT + " vào kho hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy phụ tùng với mã " + maPT, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                hienThiDanhSachPhuTung();
                TruyCapDuLieu.ghiFile();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xử lý nhập hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dgvDanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
