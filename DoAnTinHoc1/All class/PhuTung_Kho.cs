using System;

namespace DoAnTinHoc1.All_class
{

    [Serializable]
    public class PhuTung_Kho : PhuTung
    {
        public PhuTung PhuTung;

        public int SoLuong = 0;

        public DateTime NgayNhap = DateTime.Now;


        public string MaPhuTung
        {
            get
            {
                return PhuTung != null ? PhuTung.MAPT : "";
            }
        }

        public PhuTung_Kho()
        {
            PhuTung = new PhuTung();
        }

        public PhuTung_Kho(PhuTung phuTung, int soLuong, DateTime ngayNhap)
        {
            PhuTung = phuTung;
            SoLuong = soLuong;
            NgayNhap = ngayNhap;



        }
        public PhuTung PHUTUNG { get; set; }



    }
}
