using DoAnTinHoc1.All_class;
using System;
using System.Data.Common;
using System.Linq;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{
    public partial class FormQuanLyHoaDon : Form
    {

        static FormQuanLyHoaDon _instance;
        public static FormQuanLyHoaDon Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new FormQuanLyHoaDon();
                return _instance;
            }
        }

        public FormQuanLyHoaDon()
        {
            InitializeComponent();
            _instance = this;
        }


        private void FormQuanLyHoaDon_Load(object sender, EventArgs e)
        {
            ListHoaDon();
        }

        void ListHoaDon()
        {
            //dgvHoaDon.Rows.Clear();
            //foreach (var hd in TruyCapDuLieu.khoitao().getDanhSachHoaDon())
            //{
            //    if (txt_BillCodeFilter.Text == String.Empty || hd.MAHD.ToLower().Contains(txt_BillCodeFilter.Text.ToLower()))
            //    {
            //        dgvHoaDon.Rows.Add(new object[] { hd.MAHD, hd.KHACHHANG.MAKH
            //        , hd.KHACHHANG.TENKH, hd.KHACHHANG.SODT, hd.SoLuong,
            //        hd.NGAYLDH, hd.ThanhTien });
            //    }
            //}

            dgvHoaDon.Rows.Clear();

            // Duyệt qua danh sách hóa đơn
            foreach (var hd in TruyCapDuLieu.khoitao().getDanhSachHoaDon())
            {
                // Lọc theo mã hóa đơn (nếu cần)
                if (txt_BillCodeFilter.Text == string.Empty || hd.MAHD.ToLower().Contains(txt_BillCodeFilter.Text.ToLower()))
                {
                    // Tính tổng số lượng phụ tùng trong hóa đơn
                    int tongSoLuong = hd.DanhSach_PhuTung_TrongKho.Sum(pt => pt.SoLuong);

                    dgvHoaDon.Rows.Add(new object[]
                    {
                hd.MAHD,                  // Mã hóa đơn
                hd.KHACHHANG.MAKH,        // Mã khách hàng
                hd.KHACHHANG.TENKH,       // Tên khách hàng
                hd.KHACHHANG.SODT,        // Số điện thoại
                tongSoLuong,              // Tổng số lượng
                hd.NGAYLDH,               // Ngày lập hóa đơn
                hd.ThanhTien              // Thành tiền
                    });
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormThemHoaDon f = new FormThemHoaDon();
            if (f.ShowDialog() == DialogResult.Yes)
            {
                ListHoaDon();
            }
            
        }

        void ListPhuTungTrongHD(string maHD)
        {
            dataGridView1.Rows.Clear();
            var hoaDon = CXuLyDuLieu.tim_HoaDon(maHD);

            if (hoaDon != null)
            {
                foreach (var pt in hoaDon.DanhSach_PhuTung_TrongKho)
                {
                    dataGridView1.Rows.Add(new object[]
                    {
                pt.PhuTung.MAPT,   // Mã phụ tùng
                pt.PhuTung.TENPT,  // Tên phụ tùng
                pt.SoLuong,        // Số lượng từ hóa đơn
                pt.PhuTung.GIAPT   // Giá tiền
                    });
                }
            }

            LB_DemPT.Text = "Tổng số phụ tùng: " + dataGridView1.Rows.Count;
        }

        private void dgvHoaDon_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                    ListPhuTungTrongHD(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch
            {

            }
        }

        private void btnLuu_HoaDon_Click(object sender, EventArgs e)
        {
            TruyCapDuLieu.ghiFile();
            MessageBox.Show("Lưu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_BillCodeFilter_TextChanged(object sender, EventArgs e)
        {
            ListHoaDon();
            dataGridView1.Rows.Clear();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LB_DemPT_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_HoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                string maHD = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                bool xoaThanhCong = CXuLyDuLieu.xoa_HoaDon(maHD);

                if (xoaThanhCong)
                {
                    ListHoaDon();
                    MessageBox.Show("Hóa đơn đã được xóa. (Đã cập nhật dữ liệu)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TruyCapDuLieu.ghiFile("DSPT.bin");
                    
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn với mã này để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count > 0)
            {
                // Lấy hóa đơn được chọn
                HoaDon hoaDon = CXuLyDuLieu.tim_HoaDon(dgvHoaDon.CurrentRow.Cells[0].Value.ToString());

                if (hoaDon != null)
                {
                    // Hiển thị form xem hóa đơn
                    new FormXuatHD(hoaDon).Show();

                    // Hiển thị thông báo thành công
                    MessageBox.Show("Hiển thị hóa đơn thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hóa đơn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xem.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }


    
}
