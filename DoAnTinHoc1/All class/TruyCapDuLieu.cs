using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace DoAnTinHoc1.All_class
{

    /// Thứ cần ghi nhớ
    [Serializable]
    /// Thứ cần ghi nhớ///

    public class TruyCapDuLieu
    {
        private static TruyCapDuLieu instance = null;
        private List<PhuTung> dsPhuTung;
        private List<LoaiXe> dsLoaiXe;
        private List<KhachHang> dsKhachHang;
        private List<NhaCungCap> dsNhaCungCap;
        private List<HoaDon> dsHoaDon;

        public List<PhuTung_Kho> dsPhuTung_TrongKho;

        public TruyCapDuLieu()
        {
            instance = this;
            dsPhuTung = new List<PhuTung>();
            dsLoaiXe = new List<LoaiXe>();
            dsKhachHang = new List<KhachHang>();
            dsNhaCungCap = new List<NhaCungCap>();
            dsHoaDon = new List<HoaDon>();
            dsPhuTung_TrongKho = new List<PhuTung_Kho>();
        }

        public static string password = "123"; // Chỗ mật khẩu ở đây nên khi mở ra nhập là 123


        public static TruyCapDuLieu khoitao()
        {
            if (instance == null)
                instance = new TruyCapDuLieu();
            return instance;
        }

        public List<PhuTung_Kho> getDanhSachPhuTungTrongKho()
        {
            if (dsPhuTung_TrongKho == null)
                dsPhuTung_TrongKho = new List<PhuTung_Kho>();
            return dsPhuTung_TrongKho;
        }


        public List<PhuTung> getDanhSachPhuTung()
        {
            return dsPhuTung;
        }

        public List<LoaiXe> getDanhSachLoaiXe()
        {
            return dsLoaiXe;
        }
        public List<NhaCungCap> getDanhSachNhaCungCap()
        {
            return dsNhaCungCap;
        }
        public List<KhachHang> getDanhSachKhachHang()
        {
            return dsKhachHang;
        }
        public List<HoaDon> getDanhSachHoaDon()
        { return dsHoaDon; }

        public static bool docFile(string tenFile = "DSPT.bin")
        {
            try
            {
                using (FileStream fs = new FileStream(tenFile, FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    instance = (TruyCapDuLieu)bf.Deserialize(fs);
                    //  fs.Close();
                    return true;
                }

            }
            catch (Exception ex)
            {
                //throw ex;
                return false;
            }
        }
        public static bool ghiFile(string tenFile = "DSPT.bin")
        {
            try
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, instance);
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        

    }
}


