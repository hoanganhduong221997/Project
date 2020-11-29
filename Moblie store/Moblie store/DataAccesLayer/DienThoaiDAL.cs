using System;
using System.Collections;
using System.Text;
using System.IO;
using Moblie_store.Utility;
using Moblie_store.Entities;
using System.Linq.Expressions;
using Moblie_store.DataAccessLayer.Interface;

namespace Moblie_store.DataAccessLayer
{
    class DienThoaiDAL : IDienThoaiDAL
    {
        private string txtfile = "Data/DienThoai.txt";
        public List<DienThoai> GetData()
        {
            List<DienThoai> list = new List<DienThoai>();
            StreamReader sr = File.OpenText(txtfile);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = CongCu.CatXau(s);
                    string[] a = s.Split('\t');
                    list.Add(new DienThoai(int.Parse(a[0]), a[1], int.Parse(a[2]), int.Parse(a[3]), int.Parse(a[4])));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public int maDT
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
        public void Insert(DienThoai dt)
        {
            int madt = maDT + 1;
            StreamWriter sw = File.AppendText(txtfile);
            sw.WriteLine();
            sw.Write(madt + "\t" + dt.tenDT + "\t" + dt.maNCC + "\t" + dt.sLNhap + "\t" + dt.sLCon);
            sw.Close();
        }
        public void Update(List<DienThoai> list)
        {
            StreamWriter sw = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                sw.WriteLine(list[i].maDT + "\t" + list[i].tenDT + "\t" + list[i].maNCC + "\t" + list[i].sLNhap + "\t" + list[i].sLCon);
            sw.Close();
        }
    }
}