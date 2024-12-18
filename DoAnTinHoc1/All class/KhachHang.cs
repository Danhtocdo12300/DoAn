using System;

namespace DoAnTinHoc1.All_class
{
    [Serializable]
    public class KhachHang
    {
        private string m_MaKH;
        private string m_TenKH;
        private string m_SoDT;
        private string m_DiaChi;

        public KhachHang()
        {
            this.m_MaKH = "";
            this.m_TenKH = "";
            this.m_SoDT = "";
            this.m_MaKH = "";

        }
        public KhachHang(string maKH, string tenKH, string soDT, string diaChi)
        {
            m_MaKH = maKH;
            m_TenKH = tenKH;
            m_SoDT = soDT;
            m_DiaChi = diaChi;
        }

        public string MAKH { get { return m_MaKH; } set { m_MaKH = value; } }
        public string TENKH { get { return m_TenKH; } set { m_TenKH = value; } }
        public string SODT { get { return m_SoDT; } set { m_SoDT = value; } }
        public string DIACHI { get { return m_DiaChi; } set { m_DiaChi = value; } }

    }
}
