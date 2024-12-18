using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnTinHoc1.All_class
{
    public class CXuLyDuLieu
    {

        public CXuLyDuLieu()
        {

        }


        public static bool KiemTra_KyTu_DacBiet(string s)
        {
            return s.Any(char.IsPunctuation);
        }

        // Vùng hoá đơn

        public static List<PhuTung> GetPhuTungXL()
        {
            return TruyCapDuLieu.khoitao().getDanhSachPhuTung();
        }
        public static List<KhachHang> GetKhachHangXL()
        {
            return TruyCapDuLieu.khoitao().getDanhSachKhachHang();
        }



        public static HoaDon tim_HoaDon(string ma)
        {
            return TruyCapDuLieu.khoitao().getDanhSachHoaDon().Find(x => x.MAHD == ma);
        }

        public static bool them_HoaDon(HoaDon hd)
        {
            if (tim_HoaDon(hd.MAHD) == null)
            {
                TruyCapDuLieu.khoitao().getDanhSachHoaDon().Add(hd);
                return true;
            }
            return false;

        }

        public static bool xoa_HoaDon(string ma)
        {
            HoaDon hd = tim_HoaDon(ma);
            if (hd != null)
            {
                TruyCapDuLieu.khoitao().getDanhSachHoaDon().Remove(hd);
                return true;
            }
            return false;
        }

        public static bool sua_HoaDon(HoaDon hd)
        {
            HoaDon hd1 = tim_HoaDon(hd.MAHD);
            if (hd1 != null)
            {
                hd1.NGAYLDH = hd.NGAYLDH;
                hd1.DanhSach_PhuTung_TrongKho = hd.DanhSach_PhuTung_TrongKho;
                return true;
            }
            return false;
        }
        


        // Vùng phụ tùng

        public static List<PhuTung> layDSPhuTung
        {
            get
            {
                return TruyCapDuLieu.khoitao().getDanhSachPhuTung();
            }
        }

        public static PhuTung tim_PhuTung(string ma)
        {
            return TruyCapDuLieu.khoitao().getDanhSachPhuTung().Find(x => x.MAPT == ma);
        }

        public static PhuTung tim_PhuTungTheoTen(string ten)
        {
            return TruyCapDuLieu.khoitao().getDanhSachPhuTung().Find(x => x.TENPT == ten);
        }

        public static bool them_PhuTung(PhuTung pt)
        {
            if (tim_PhuTung(pt.MAPT) == null)
            {
                TruyCapDuLieu.khoitao().getDanhSachPhuTung().Add(pt);
                return true;
            }
            return false;
        }

        public static bool xoa_PhuTung(string ma)
        {
            PhuTung pt = tim_PhuTung(ma);
            if (pt != null)
            {
                TruyCapDuLieu.khoitao().getDanhSachPhuTung().Remove(pt);
                return true;
            }
            return false;
        }

        public static bool sua_PhuTung(PhuTung pt)
        {
            PhuTung pt1 = tim_PhuTung(pt.MAPT);
            if (pt1 != null)
            {
                pt1.TENPT = pt.TENPT;
                pt1.GIAPT = pt.GIAPT;
                pt1.LOAIXE_GASO = pt.LOAIXE_GASO;
                pt1.TENLOAIXE = pt.TENLOAIXE;
                pt1.TENNHACC = pt.TENNHACC;
                return true;
            }
            return false;
        }


        // Vùng loại xe

        public static LoaiXe tim_LoaiXe(string ma)
        {
            return TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Find(x => x.MALOAIXE == ma);
        }

        public static LoaiXe tim_LoaiXeTheoTen(string ten)
        {
            return TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Find(x => x.TENLOAIXE == ten);
        }

        public static bool them_LoaiXe(LoaiXe lx)
        {
            if (tim_LoaiXe(lx.MALOAIXE) == null)
            {
                TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Add(lx);
                return true;
            }
            return false;
        }

        public static bool xoa_LoaiXe(string ma)
        {
            LoaiXe lx = tim_LoaiXe(ma);
            if (lx != null)
            {
                TruyCapDuLieu.khoitao().getDanhSachLoaiXe().Remove(lx);
                return true;
            }
            return false;
        }

        public static bool sua_LoaiXe(LoaiXe lx)
        {
            LoaiXe lx1 = tim_LoaiXe(lx.MALOAIXE);
            if (lx1 != null)
            {
                lx1.TENLOAIXE = lx.TENLOAIXE;
                lx1.LOAIXE_TUONGUNG = lx.LOAIXE_TUONGUNG;

                return true;
            }
            return false;
        }


        // Vùng nhà cung cấp

        public static NhaCungCap tim_NhaCungCap(string ma)
        {
            return TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Find(x => x.MANCC == ma);
        }

        public static NhaCungCap tim_NhaCungCapTheoTen(string ten)
        {
            return TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Find(x => x.TENNCC == ten);
        }

        public static bool them_NhaCungCap(NhaCungCap ncc)
        {
            if (tim_NhaCungCap(ncc.MANCC) == null)
            {
                TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Add(ncc);
                return true;
            }
            return false;
        }

        public static bool xoa_NhaCungCap(string ma)
        {
            NhaCungCap ncc = tim_NhaCungCap(ma);
            if (ncc != null)
            {
                TruyCapDuLieu.khoitao().getDanhSachNhaCungCap().Remove(ncc);
                return true;
            }
            return false;
        }

        public static bool sua_NhaCungCap(NhaCungCap ncc)
        {
            NhaCungCap ncc1 = tim_NhaCungCap(ncc.MANCC);
            if (ncc1 != null)
            {
                ncc1.TENNCC = ncc.TENNCC;
                ncc1.SODTNCC = ncc.SODTNCC;
                ncc1.DIACHINCC = ncc.DIACHINCC;
                return true;
            }
            return false;
        }



        // Vùng khách hàng

        public static KhachHang tim_KhachHang(string ma)
        {
            return TruyCapDuLieu.khoitao().getDanhSachKhachHang().Find(x => x.MAKH == ma);
        }

        public static KhachHang tim_KhachHangTheoTen(string ten)
        {
            return TruyCapDuLieu.khoitao().getDanhSachKhachHang().Find(x => x.TENKH == ten);
        }

        public static bool them_KhachHang(KhachHang kh)
        {
            if (tim_KhachHang(kh.MAKH) == null)
            {
                TruyCapDuLieu.khoitao().getDanhSachKhachHang().Add(kh);
                return true;
            }
            return false;
        }

        public static KhachHang tim_KhachHangTheoSDT(string sdt)
        {
            return TruyCapDuLieu.khoitao().getDanhSachKhachHang().Find(x => x.SODT == sdt);
        }

        public static bool xoa_KhachHang(string ma)
        {
            KhachHang kh = tim_KhachHang(ma);
            if (kh != null)
            {
                TruyCapDuLieu.khoitao().getDanhSachKhachHang().Remove(kh);
                return true;
            }
            return false;
        }

        public static bool sua_KhachHang(KhachHang kh)
        {
            KhachHang kh1 = tim_KhachHang(kh.MAKH);
            if (kh1 != null)
            {
                kh1.TENKH = kh.TENKH;
                kh1.SODT = kh.SODT;
                kh1.DIACHI = kh.DIACHI;
                return true;
            }
            return false;
        }


        // Vùng phụ tùng nhập kho
        public static PhuTung_Kho tim_PhuTungNhapKho(string ma)
        {
            return TruyCapDuLieu.khoitao().getDanhSachPhuTungTrongKho().Find(x => x.PhuTung.MAPT == ma);
        }

        public static PhuTung_Kho tim_PhuTungNhapKhoTheoTen(string ten)
        {
            return TruyCapDuLieu.khoitao().getDanhSachPhuTungTrongKho().Find(x => x.PhuTung.TENPT == ten);

        }

        public static bool them_PhuTungNhapKho(PhuTung_Kho pt)
        {
            if (tim_PhuTungNhapKho(pt.PhuTung.MAPT) == null)
            {
                TruyCapDuLieu.khoitao().getDanhSachPhuTungTrongKho().Add(pt);
                return true;
            }
            return false;
        }

        public static bool xoa_PhuTungNhapKho(string ma)
        {
            PhuTung_Kho pt = tim_PhuTungNhapKho(ma);
            if (pt != null)
            {
                TruyCapDuLieu.khoitao().getDanhSachPhuTungTrongKho().Remove(pt);
                return true;
            }
            return false;
        }

        public static bool sua_PhuTungNhapKho(PhuTung_Kho pt)
        {
            PhuTung_Kho pt1 = tim_PhuTungNhapKho(pt.PhuTung.MAPT);
            if (pt1 != null)
            {
                pt1.PhuTung = pt.PhuTung;
                pt1.SoLuong = pt.SoLuong;
                pt1.NgayNhap = pt.NgayNhap;
                return true;
            }
            return false;
        }



      

    }

}
