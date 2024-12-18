using DoAnTinHoc1.All_class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnTinHoc1.Form_ChucNang
{
    public partial class FormXuatHD : Form
    {
        public FormXuatHD()
        {
            InitializeComponent();
        }

        public FormXuatHD(HoaDon hoaDon) : this()
        {
            string maHD = hoaDon.MAHD;
            string hoTen = hoaDon.KHACHHANG.TENKH;
            string sdt = hoaDon.KHACHHANG.SODT;
            string diaChi = hoaDon.KHACHHANG.DIACHI;
            string ngayLap = hoaDon.NGAYLDH.ToString();

            List<PhuTung_Kho> phuTung_Kho = hoaDon.DanhSach_PhuTung_TrongKho.ToList();

            LB_MaHD.Text = "Mã hoá đơn: " + maHD;
            LB_HoTen.Text = "Họ tên: " + hoTen;
            LB_SDT.Text = "Số điện thoại: " + sdt;
            LB_DiaChi.Text = "Địa chỉ: " + diaChi;
            lb_TGMUA.Text = "Thời gian: " + ngayLap;

            dgvHoaDon.Rows.Clear();
            foreach (var pt in phuTung_Kho)
            {
                dgvHoaDon.Rows.Add(new object[] { pt.PhuTung.MAPT, pt.PhuTung.TENPT, pt.SoLuong, pt.PhuTung.GIAPT, pt.PhuTung.GIAPT * pt.SoLuong });
            }
        }

        private void FormXuatHD_Load(object sender, EventArgs e)
        {

        }
    }
}
