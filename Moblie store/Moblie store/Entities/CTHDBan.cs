using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class CTHDBan
    {
        #region các thành phần dữ liệu
        private int MaCTHDB;
        private string MaHDB;
        private string MaDT;
        private int SoLuong;
        private double DonGia;
        private double ThanhTien;
        #endregion
        #region các phương thức khởi tạo
        public CTHDBan()
        {
            MaCTHDB = 0;
            MaHDB = " ";
            MaDT = " ";
            SoLuong = 0;
            DonGia = 0;
            ThanhTien = 0;
        }
        public CTHDBan(int macthdb, string mahdb, string madt, int soluong, double dongia, double thanhtien)
        {
            this.MaCTHDB = macthdb;
            this.MaHDB = mahdb;
            this.MaDT = madt;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
        // Phương thức sao chép
        public CTHDBan(CTHDBan c)
        {
            this.MaCTHDB = c.MaCTHDB;
            this.MaHDB = c.MaHDB;
            this.MaDT = c.MaDT;
            this.SoLuong = c.SoLuong;
            this.DonGia = c.DonGia;
            this.ThanhTien = c.ThanhTien;
        }
        #endregion
        #region các thuộc tính
        public int maCTHDB
        {
            get
            {
                return MaCTHDB;
            }
            set
            {
                if (value > 0)
                    MaCTHDB = value;
            }
        }
        public string maHDB
        {
            get
            {
                return MaHDB;
            }
            set
            {
                if (value != "")
                    MaHDB = value;
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
        public int soluong
        {
            get
            {
                return SoLuong;
            }
            set
            {
                if (value >= 0)
                    SoLuong = value;
            }
        }
        public double dongia
        {
            get
            {
                return DonGia;
            }
            set
            {
                if (value > 0)
                    DonGia = value;
            }
        }
        public double thanhtien
        {
            get
            {
                return ThanhTien;
            }
            set
            {
                if (value > 0)
                    ThanhTien = value;
            }
        }
        #endregion
    }
}
