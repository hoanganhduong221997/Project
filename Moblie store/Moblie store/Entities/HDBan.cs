﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class HDBan
    {
        private int MaHDB;
        private int MaNV;
        private int MaKH;
        private int MaDT;
        private string NgayBan;
        private int SoLuong;
        private double DonGia;
        private double TongTien;

        public HDBan()
        {
        }
        public HDBan(int mahdb, int manv, int makh, int madt, string ngayban, int soluong, double dongia, double tongtien)
        {
            this.MaHDB = mahdb;
            this.MaNV = manv;
            this.MaKH = makh;
            this.MaDT = madt;
            this.NgayBan = ngayban;
            this.SoLuong = soluong;
            this.DonGia = dongia;
            this.TongTien = tongtien;
        }
        //Phương thức sao chép
        public HDBan(HDBan hdb)
        {
            this.MaHDB = hdb.MaHDB;
            this.MaNV = hdb.MaNV;
            this.MaKH = hdb.MaKH;
            this.MaDT = hdb.MaDT;
            this.NgayBan = hdb.NgayBan;
            this.SoLuong = hdb.SoLuong;
            this.DonGia = hdb.DonGia;
            this.TongTien = hdb.TongTien;
        }

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
        public int maKH
        {
            get
            {
                return MaKH;
            }
            set
            {
                if (value > 0)
                    MaKH = value;
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
        public string ngayBan
        {
            get
            {
                return NgayBan;
            }
            set
            {
                if (value != "")
                    NgayBan = value;
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
