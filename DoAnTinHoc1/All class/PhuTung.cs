using System;

namespace DoAnTinHoc1.All_class
{
    [Serializable]
    public class PhuTung
    {
        private string maPT;
        private string tenPT;
        private string loaiXeGaSo;
        private double giaPT;

        DateTime? thoiGianBaoHanh = null;

        // cua loai xe 
        private LoaiXe loaiXe;
        // nha cung cap
        private NhaCungCap nhacungcap;

       
        public PhuTung()
        {
            this.maPT = "";
            this.tenPT = "";
            this.loaiXeGaSo = "";
            this.giaPT = 0;


            if (loaiXe == null) { loaiXe = new LoaiXe(); }
            // cua loai xe 
            this.loaiXe.TENLOAIXE = null;
            // nha cung cap
            if (nhacungcap == null)
            {
                nhacungcap = new NhaCungCap();
            }

            this.nhacungcap.TENNCC = null;
            thoiGianBaoHanh = null;

        }
        public PhuTung(string maPT, string tenPT, int giaPT, string loaiXeGaSo, LoaiXe tenLoaiXe, NhaCungCap tenNhaCC, DateTime? thoiHanBH = null)
        {

            this.loaiXe = tenLoaiXe;
            //cua loai xe

            this.nhacungcap = tenNhaCC;
            // cua nha cung cap

            this.maPT = maPT;
            this.tenPT = tenPT;
            this.loaiXeGaSo = loaiXeGaSo;
            this.giaPT = giaPT;
            this.thoiGianBaoHanh = thoiHanBH;
        }
        //
        public string TENLOAIXE
        {
            get { return this.loaiXe.TENLOAIXE; }
            set { this.loaiXe.TENLOAIXE = value; }
        }
        ///
        public string TENNHACC
        {
            get { return this.nhacungcap.TENNCC; }
            set { this.nhacungcap.TENNCC = value; }
        }
        //
        public DateTime TH_BAOHANH
        {
            get; set;
        }
        public string MAPT
        {
            get { return this.maPT; }
            set { this.maPT = value; }
        }
        public string TENPT
        {
            get { return this.tenPT; }
            set { this.tenPT = value; }
        }

        public string LOAIXE_GASO
        {
            get { return this.loaiXeGaSo; }
            set { this.loaiXeGaSo = value; }

        }

        public double GIAPT
        {
            get { return this.giaPT; }
            set { this.giaPT = value; }
        }

      


        public DateTime? ThoiHanBaoHanh
        {
            get { return this.thoiGianBaoHanh; }
            set { this.thoiGianBaoHanh = value; }

        }
    }
}


