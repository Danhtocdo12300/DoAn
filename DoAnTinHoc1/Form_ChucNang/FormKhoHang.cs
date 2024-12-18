using DoAnTinHoc1.All_class;
using System;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{
    public partial class FormKhoHang : Form
    {
        public FormKhoHang()
        {
            InitializeComponent();
        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private int ViTri = 0;
        void LoadData()
        {
            dgvKhoHang.Rows.Clear();

            foreach (var a in TruyCapDuLieu.khoitao().getDanhSachPhuTungTrongKho())
            {
                // Lọc theo mã
                if (txt_ProductFilter.Text == String.Empty || a.MaPhuTung.ToLower().Contains(txt_ProductFilter.Text.ToLower()))
                {
                    dgvKhoHang.Rows.Add(new object[]
                       {
                           a.PhuTung.MAPT,
                            a.PhuTung.TENPT,
                            a.SoLuong,
                            a.NgayNhap
                       });
                }
            }
        }


        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            UC_NhapHang uc = new UC_NhapHang();

            this.Controls.Clear(); // Xóa các control hiện tại
            uc.Dock = DockStyle.Fill; // Đặt UC_NhapHang chiếm toàn bộ form
            this.Controls.Add(uc);

            // Tải lại dữ liệu sau khi thêm
            TruyCapDuLieu.docFile("DSPT.bin");

            MessageBox.Show("Sẵn sàng nhập hàng!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }



        private void txt_ProductFilter_TextChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnLuu_KhachHang_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile("DSPT.bin");
            MessageBox.Show("Lưu thành công Kho Hàng ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnXoa_SPtrongKho_Click(object sender, EventArgs e)
        {
            if (dgvKhoHang.SelectedRows.Count > 0)
            {
                int index = dgvKhoHang.SelectedRows[0].Index;
                var danhSachPhuTung = TruyCapDuLieu.khoitao().getDanhSachPhuTungTrongKho();
                if (index >= 0 && index < danhSachPhuTung.Count)
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phụ tùng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        danhSachPhuTung.RemoveAt(index);
                        LoadData();
                        MessageBox.Show("Xóa phụ tùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TruyCapDuLieu.ghiFile("DSPT.bin");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phụ tùng để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
