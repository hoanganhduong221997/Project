using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class GiaBan
    {
        #region các thành phần dữ liệu
        private int MaGB;
        private string MaDT;
        private double Giaban;
        private DateTime NgayAD;
        private DateTime NgayThoiAD;
        #endregion
        #region các phương thức khởi tạo
        public GiaBan()
        {
            MaGB = 0;
            MaDT = " ";
            Giaban = 0;
            NgayAD = DateTime.Now;
            NgayThoiAD = DateTime.Now;
        }
        public GiaBan(int magb, string madt, double giaban, DateTime ngayad, DateTime ngaythoiad)
        {
            this.MaGB = magb;
            this.MaDT = madt;
            this.Giaban = giaban;
            this.NgayAD = ngayad;
            this.NgayThoiAD = ngaythoiad;
        }
        // phương thức sao chép
        public GiaBan(GiaBan gb)
        {
            this.MaGB = gb.MaGB;
            this.MaDT = gb.MaDT;
            this.Giaban = gb.Giaban;
            this.NgayAD = gb.NgayAD;
            this.NgayThoiAD = gb.NgayThoiAD;
        }
        #endregion
        #region các thuộc tính
        public int maGB
        {
            get
            {
                return MaGB;
            }
            set
            {
                if (value > 0)
                    MaGB = value;
            }
        }
        public string maDT
        {
            get
            {
                return MaDT;
            }
            set
            {
                if (value != "")
                    MaDT = value;
            }
        }
        public double giaBan
        {
            get
            {
                return Giaban;
            }
            set
            {
                if (value > 0)
                    Giaban = value;
            }
        }
        public DateTime ngayAD
        {
            get
            {
                return NgayAD;
            }
            set
            {
                NgayAD = value;
            }
        }
        public DateTime ngaythoiAD
        {
            get
            {
                return NgayThoiAD;
            }
            set
            {
                NgayThoiAD = value;
            }
        }
        #endregion
    }
}
