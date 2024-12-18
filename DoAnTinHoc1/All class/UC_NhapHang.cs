using System;

namespace DoAnTinHoc1.All_class
{
    [Serializable]
    public class UC_NhapHang
    {
        private int m_SoLuong;

        public UC_NhapHang()
        {
            this.m_SoLuong = 0;
        }
        public UC_NhapHang(int soLuong)
        {
            this.m_SoLuong = soLuong;
        }
        public int SOLUONG
        {
            get { return this.m_SoLuong; }
            set { this.m_SoLuong = value; }
        }
    }
}
