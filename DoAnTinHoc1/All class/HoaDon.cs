using System;
using System.Collections.Generic;

namespace DoAnTinHoc1.All_class
{



    [Serializable]
    public class HoaDon
    {
        private string m_MaHD;
        private DateTime m_NgayLHD;

        List<PhuTung_Kho> m_PhuTung;
        //

        //
        KhachHang khachHang = null;

        public HoaDon()
        {
            this.m_MaHD = "";
            this.m_NgayLHD = DateTime.Now;
            m_PhuTung = new List<PhuTung_Kho>();


            khachHang = null;

        }
        public HoaDon(string MaHD, KhachHang kh, DateTime NgayLHD, List<PhuTung_Kho> danhSachPhuTung)
        {
            this.m_MaHD = MaHD;
            this.m_NgayLHD = NgayLHD;
            this.m_PhuTung = danhSachPhuTung;
            this.khachHang = kh;



        }



        public KhachHang KHACHHANG
        {
            get { return this.khachHang; }
            set { this.khachHang = value; }
        }

        public List<PhuTung_Kho> DanhSach_PhuTung_TrongKho
        {
            get { return this.m_PhuTung; }
            set { this.m_PhuTung = value; }
        }

        public string MAHD
        {
            get { return this.m_MaHD; }
            set { this.m_MaHD = value; }
        }
        public DateTime NGAYLDH
        {
            get { return this.m_NgayLHD; }
            set { this.m_NgayLHD = value; }
        }

        public int SoLuong
        {
            get
            {
                int dem = 0;
                foreach (PhuTung_Kho pt in m_PhuTung)
                {
                    dem += pt.SoLuong;
                }
                return dem;
            }
        }

        public double ThanhTien
        {
            get
            {
                double thanhTien = 0;
                foreach (PhuTung_Kho pt in m_PhuTung)
                {
                    thanhTien += pt.PhuTung.GIAPT * pt.SoLuong;
                }
                return thanhTien;
            }
        }

    }
}
