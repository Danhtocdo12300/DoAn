using System;

namespace DoAnTinHoc1.All_class
{
    [Serializable]
    public class NhaCungCap
    {
        private string m_MaNCC;
        private string m_TenNCC;
        private string m_SoDT;
        private string m_DiaChi;

        public NhaCungCap()
        {
            this.m_MaNCC = "";
            this.m_TenNCC = "";
            this.m_SoDT = "";
            this.m_DiaChi = "";
        }
        public NhaCungCap(string maNCC, string tenNCC, string soDT, string diaChi)
        {
            m_MaNCC = maNCC;
            m_TenNCC = tenNCC;
            m_SoDT = soDT;
            m_DiaChi = diaChi;
        }
        public string MANCC
        {
            get { return m_MaNCC; }
            set { m_MaNCC = value; }

        }
        public string TENNCC
        {
            get { return m_TenNCC; }
            set { m_TenNCC = value; }

        }
        public string SODTNCC
        {
            get { return m_SoDT; }
            set { m_SoDT = value; }
        }
        public string DIACHINCC
        {
            get { return m_DiaChi; }
            set { m_DiaChi = value; }
        }
    }

}
