using DoAnTinHoc1.All_class;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{

    public partial class FormThemHoaDon : Form
    {


        List<PhuTung_Kho> DS_PhuTung = new List<PhuTung_Kho>();

        List<PhuTung> dsPhuTungSP = new List<PhuTung>();
        public FormThemHoaDon()
        {
            InitializeComponent();
        }





        private void hienCboPhuTung(ComboBox cb, List<PhuTung> ds)
        {
            cb.Items.Clear();
            foreach (var pt in ds)
            {
                cb.Items.Add(pt.MAPT + "-" + pt.TENPT);
            }
        }
        private void FormHoaDon_Load(object sender, EventArgs e)
        {

            hienCboPhuTung(cboMaPhuTung, CXuLyDuLieu.GetPhuTungXL());

            txt_KhachHang.AutoCompleteCustomSource.Clear();
            txt_KhachHang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_KhachHang.AutoCompleteSource = AutoCompleteSource.CustomSource;


            foreach (var kh in CXuLyDuLieu.GetKhachHangXL())
            {
                string sdt = kh.SODT == String.Empty ? "<ko có sdt>" : kh.SODT;
                txt_KhachHang.AutoCompleteCustomSource.Add(kh.MAKH + "-" + kh.TENKH + "-" + sdt);
            }

        }




        private void cboMaPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btn_AddHD_Click(object sender, EventArgs e)
        {

            string maHD = SinhMaHD.GenerateSequentialCode();
            DateTime ngayLHD;
            if (!DateTime.TryParse(dtNgayLapHoaDon.Text, out ngayLHD))
            {
                MessageBox.Show("Ngày lập hóa đơn không hợp lệ", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            KhachHang khachHang = CXuLyDuLieu.tim_KhachHang(txt_KhachHang.Text.Split('-')[0]);
            if (khachHang == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (DS_PhuTung.Count == 0)
            {
                MessageBox.Show("Hóa đơn không có phụ tùng", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (CXuLyDuLieu.tim_HoaDon(maHD) != null)
            {
                MessageBox.Show("Mã hóa đơn " + maHD + " đã tồn tại", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var pt in DS_PhuTung)
            {
                var a = CXuLyDuLieu.tim_PhuTungNhapKho(pt.PhuTung.MAPT);
                if (a != null)
                    a.SoLuong -= pt.SoLuong;
            }

            HoaDon hoaDon = new HoaDon(maHD, khachHang, ngayLHD, DS_PhuTung);

            if (CXuLyDuLieu.them_HoaDon(hoaDon))
            {
                MessageBox.Show("Thêm hóa đơn thành công", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.Yes;


            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        public class SinhMaHD
        {
            private static int _counter = 1000;

            public static string GenerateSequentialCode()
            {
                string newCode;
                do
                {
                    _counter++;
                    newCode = "HD" + _counter.ToString();
                }
                while (CXuLyDuLieu.tim_HoaDon(newCode) != null);
                return newCode;
            }
        }


        private void btnThem_PT_Click(object sender, EventArgs e)
        {
            PhuTung_Kho phuTung = CXuLyDuLieu.tim_PhuTungNhapKho(cboMaPhuTung.Text.Split('-')[0]);

            if (phuTung == null)
            {
                MessageBox.Show("Không tìm thấy phụ tùng", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
       
            int soLuongTrc = phuTung.SoLuong;

            if (!int.TryParse(txt_Number.Text, out int soLuong))
            {
                MessageBox.Show("Ô số lượng phải nhập bằng số", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (soLuong <= 0 || soLuong > soLuongTrc)
            {
                MessageBox.Show("Số lượng phải > 0 và <= " + soLuongTrc, "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtGiaTien.Text, out double giaTien))
            {
                MessageBox.Show("Ô giá tiền phải nhập bằng số", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PhuTung_Kho tempPT= new PhuTung_Kho(phuTung.PhuTung, soLuong, phuTung.NgayNhap);

            tempPT.PhuTung.GIAPT = giaTien;
            if (DS_PhuTung.Contains(tempPT))
            {
                MessageBox.Show("Phụ tùng đã tồn tại trong hóa đơn", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DS_PhuTung.Add(tempPT);
            string maHD = SinhMaHD.GenerateSequentialCode();

            MessageBox.Show("Thêm phụ tùng thành công. Mã hóa đơn: " + maHD, "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();


        }

        void LoadData()
        {

            dgvHoaDon.Rows.Clear();
            foreach (var ptKho in DS_PhuTung)
            {
                dgvHoaDon.Rows.Add(new object[]
                {
                    ptKho.PhuTung.MAPT,
                    ptKho.PhuTung.TENPT,
                    ptKho.SoLuong,
                    ptKho.PhuTung.GIAPT
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }



        private void btnXoa_HoaDon_Click(object sender, EventArgs e)
        {
            DS_PhuTung.Clear();
            MessageBox.Show("Xóa toàn bộ danh sách phụ tùng thành công!", "Thông Báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
