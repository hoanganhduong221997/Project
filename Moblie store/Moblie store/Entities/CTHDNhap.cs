using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class CTHDNhap
    {
        #region các thành phần dữ liệu
        private int MaCTHDN;
        private string MaHDN;
        private string MaDT;
        private int SoLuong;
        private double DonGia;
        private double ThanhTien;
        #endregion
        #region các phương thức khởi tạo
        public CTHDNhap()
        {
            MaCTHDN = 0;
            MaHDN = " ";
            MaDT = " ";
            SoLuong = 0;
            DonGia = 0;
            ThanhTien = 0;
        }
        public CTHDNhap(int macthdn, string mahdn, string madt, int soluong, double dongia, double thanhtien)
        {
            this.MaCTHDN = macthdn;
            this.MaHDN = mahdn;
            this.MaDT = madt;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.ThanhTien = thanhtien;
        }
        // Phương thức sao chép
        public CTHDNhap(CTHDNhap c)
        {
            this.MaCTHDN = c.MaCTHDN;
            this.MaHDN = c.MaHDN;
            this.MaDT = c.MaDT;
            this.SoLuong = c.SoLuong;
            this.DonGia = c.DonGia;
            this.ThanhTien = c.ThanhTien;
        }
        #endregion
        #region các thuộc tính
        public int maCTHDN
        {
            get
            {
                return MaCTHDN;
            }
            set
            {
                if (value > 0)
                    MaCTHDN = value;
            }
        }
        public string maHDN
        {
            get
            {
                return MaHDN;
            }
            set
            {
                if (value != "")
                    MaHDN = value;
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
                if (value > 0)
                    SoLuong = value;
            }
        }
        public double donGia
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
