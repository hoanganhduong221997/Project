using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class HDBan
    {
        #region các thành phần dữ liệu
        private int MaHDB;
        private string MaNV;
        private string MaKH;
        private DateTime NgayBan;
        private double TongTien;
        #endregion
        #region các phương thức khởi tạo
        public HDBan()
        {
            MaHDB = 0;
            MaNV = " ";
            MaKH = " ";
            NgayBan = DateTime.Now;
            TongTien = 0;
        }
        public HDBan(int mahdb, string manv, string makh, DateTime ngayban, double tongtien)
        {
            this.MaHDB = mahdb;
            this.MaNV = manv;
            this.MaKH = makh;
            this.NgayBan = ngayban;
            this.TongTien = tongtien;
        }
        // phương thức sao chép
        public HDBan(HDBan hdb)
        {
            this.MaHDB = hdb.MaHDB;
            this.MaNV = hdb.MaNV;
            this.MaKH = hdb.MaKH;
            this.NgayBan = hdb.NgayBan;
            this.TongTien = hdb.TongTien;
        }
        #endregion
        #region Các thuộc tính
        public int maHDB
        {
            get
            {
                return MaHDB;
            }
            set
            {
                if (value > 0)
                    MaHDB = value;
            }
        }
        public string maNV
        {
            get
            {
                return MaNV;
            }
            set
            {
                if (value != "")
                    MaNV = value;
            }
        }
        public string maKH
        {
            get
            {
                return MaKH;
            }
            set
            {
                if (value != "")
                    MaKH = value;
            }
        }
        public DateTime ngayBan
        {
            get
            {
                return NgayBan;
            }
            set
            {
                NgayBan = value;
            }
        }
        public double tongTien
        {
            get
            {
                return TongTien;
            }
            set
            {
                if (value > 0)
                    TongTien = value;
            }
        }
        #endregion
    }
}
