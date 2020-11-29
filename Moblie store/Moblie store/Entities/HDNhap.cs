﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class HDNhap
    {
        private int MaHDN;
        private int MaNV;
        private int MaNCC;
        private int MaDT;
        private string NgayNhap;
        private int SoLuong;
        private double DonGia;
        private double TongTien;

        public HDNhap()
        {
        }
        public HDNhap(int mahdn, int manv, int mancc, int madt, string ngaynhap, int soluong, double dongia, double tongtien)
        {
            this.MaHDN = mahdn;
            this.MaNV = manv;
            this.MaNCC = mancc;
            this.MaDT = madt;
            this.NgayNhap = ngaynhap;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.TongTien = tongtien;
        }
        //Phương thức sao chép
        public HDNhap(HDNhap hdn)
        {
            this.MaHDN = hdn.MaHDN;
            this.MaNV = hdn.MaNV;
            this.MaNCC = hdn.MaNCC;
            this.MaDT = hdn.MaDT;
            this.NgayNhap = hdn.NgayNhap;
            this.SoLuong = hdn.SoLuong;
            this.DonGia = hdn.DonGia;
            this.TongTien = hdn.TongTien;
        }

        public int maHDN
        {
            get
            {
                return MaHDN;
            }
            set
            {
                if (value > 0)
                    MaHDN = value;
            }
        }
        public int maNV
        {
            get
            {
                return MaNV;
            }
            set
            {
                if (value > 0)
                    MaNV = value;
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
        public string ngayNhap
        {
            get
            {
                return NgayNhap;
            }
            set
            {
                if (value != "")
                    NgayNhap = value;
            }
        }
        public int soLuong
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
        public double tongTien
        {
            get
            {
                return donGia * soLuong;
            }
            set
            {
                TongTien = value;
            }
        }
    }
}
