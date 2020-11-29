﻿using System;
using System.Collections;
using System.Text;
using System.IO;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.DataAccessLayer.Interface;

namespace Moblie_store.DataAccessLayer
{
    class KhachHangDAL : IKhachHangDAL
    {
        private string txtfile = "Data/KhachHang.txt";
        public List<KhachHang> GetData()
        {
            List<KhachHang> list = new List<KhachHang>();
            StreamReader sr = File.OpenText(txtfile);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = CongCu.CatXau(s);
                    string[] a = s.Split('\t');
                    list.Add(new KhachHang(int.Parse(a[0]), a[1], a[2], a[3]));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public int maKH
        {
            get
            {
                StreamReader sr = File.OpenText(txtfile);
                string s = sr.ReadLine();
                string tmp = "";
                while (s != null)
                {
                    if (s != "")
                        tmp = s;
                    s = sr.ReadLine();
                }
                sr.Close();
                if (tmp == "")
                    return 0;
                else
                {
                    tmp = CongCu.ChuanHoaXau(tmp);
                    string[] a = tmp.Split('\t');
                    return int.Parse(a[0]);
                }
            }
        }
        public void Insert(KhachHang kh)
        {
            int makh = maKH + 1;
            StreamWriter sw = File.AppendText(txtfile);
            sw.WriteLine();
            sw.Write(makh + "\t" + kh.tenKH + "\t" + kh.diaChi + "\t" + kh.soDT);
            sw.Close();
        }
        public void Update(List<KhachHang> list)
        {
            StreamWriter sw = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                sw.WriteLine(list[i].maKH + "\t" + list[i].tenKH + "\t" + list[i].diaChi + "\t" + list[i].soDT);
            sw.Close();
        }
    }
}
