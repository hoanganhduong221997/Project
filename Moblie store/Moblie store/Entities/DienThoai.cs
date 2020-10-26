using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class DienThoai
    {
        #region Các thành phần dữ liệu
        private int MaDT;
        private int MaLM;
        private string TenDT;
        private int MaNCC;
        private int SLNhap;
        private int SLCon;
        #endregion
        #region Các phương thức khởi tạo
        public DienThoai()
        {
        }
        public DienThoai(int madt, int malm, string tendt, int mancc, int sln, int slc)
        {
            this.MaDT = madt;
            this.MaLM = malm;
            this.TenDT = tendt;
            this.MaNCC = mancc;
            this.SLNhap = sln;
            this.SLCon = slc;
        }
        //Phương thức sao chép
        public DienThoai(DienThoai dt)
        {
            this.MaDT = dt.MaDT;
            this.MaLM = dt.MaLM;
            this.TenDT = dt.TenDT;
            this.MaNCC = dt.MaNCC;
            this.SLNhap = dt.SLNhap;
            this.SLCon = dt.SLCon;
        }
        #endregion
        #region Các thuộc tính
        public int maDT
        {
            get
            {
                return MaDT;
            }
            set
            {
                if (value > 0)
                    MaDT = value;
            }
        }
        public int maLM
        {
            get
            {
                return MaLM;
            }
            set
            {
                if (value > 0)
                    MaLM = value;
            }
        }
        public string tenDT
        {
            get
            {
                return TenDT;
            }
            set
            {
                if (value != "")
                    TenDT = value;
            }
        }
        public int maNCC
        {
            get
            {
                return MaNCC;
            }
            set
            {
                if (value > 0)
                    MaNCC = value;
            }
        }
        public int sLNhap
        {
            get
            {
                return SLNhap;
            }
            set
            {
                if (value >= 0)
                    SLNhap = value;
            }
        }
        public int sLCon
        {
            get
            {
                return SLCon;
            }
            set
            {
                if (value > 0)
                    SLCon = value;
            }
        }
        #endregion
    }
}
