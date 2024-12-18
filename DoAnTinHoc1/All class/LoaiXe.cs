using System;

namespace DoAnTinHoc1.All_class
{
    [Serializable]
    public class LoaiXe
    {
        private string maLoaiXe;
        private string tenLoaiXe;
        private string loaiXeTuongUng;



        public LoaiXe()
        {
            this.maLoaiXe = "";
            this.tenLoaiXe = "";
            this.loaiXeTuongUng = "";




        }
        public LoaiXe(string maLoaiXe, string tenLoaiXe, string loaiXeTuongUng)
        {
            this.maLoaiXe = maLoaiXe;
            this.tenLoaiXe = tenLoaiXe;
            this.loaiXeTuongUng = loaiXeTuongUng;

        }
        public string MALOAIXE
        {
            get { return this.maLoaiXe; }
            set { this.maLoaiXe = value; }
        }
        public string TENLOAIXE
        {
            get { return this.tenLoaiXe; }
            set { this.tenLoaiXe = value; }
        }
        public string LOAIXE_TUONGUNG
        {
            get { return this.loaiXeTuongUng; }
            set { this.loaiXeTuongUng = value; }
        }

    }
}
