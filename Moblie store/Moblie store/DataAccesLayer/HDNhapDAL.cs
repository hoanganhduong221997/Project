using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.DataAccessLayer.Interface;

namespace Moblie_store.DataAccesLayer
{
    class HDNhapDAL : IHDNhapDAL
    {
        private string txtfile = @"E:\Đồ án 1\Moblie_store\Moblie_store\Data\HDNhap.txt";
        public List<HDNhap> GetData()
        {
            List<HDNhap> list = new List<HDNhap>();
            StreamReader sr = File.OpenText(txtfile);
            string s = sr.ReadLine();
            while (s != null)
            {
                if (s != "")
                {
                    s = Moblie_store.Utility.CongCu.CatXau(s);
                    string[] a = s.Split('\t');
                    list.Add(new HDNhap(int.Parse(a[0]), int.Parse(a[1]), int.Parse(a[2]), int.Parse(a[3]), DateTime.Parse(a[4]), int.Parse(a[5]), double.Parse(a[6]), double.Parse(a[7])));
                }
                s = sr.ReadLine();
            }
            sr.Close();
            return list;
        }
        public int maHDN
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
                    tmp = Moblie_store.Utility.CongCu.ChuanHoaXau(tmp);
                    string[] a = tmp.Split('\t');
                    return int.Parse(a[0]);
                }
            }
        }
        public void Insert(HDNhap hdn)
        {
            int mahdn = maHDN + 1;
            StreamWriter sw = File.AppendText(txtfile);
            sw.WriteLine();
            sw.Write(mahdn + "\t" + hdn.maNV + "\t" + hdn.maNCC + "\t" + hdn.maDT + "\t" + hdn.ngayNhap + "\t" + hdn.soLuong + "\t" + hdn.donGia + "\t" + hdn.tongTien);
            sw.Close();
        }
        public void Update(List<HDNhap> list)
        {
            StreamWriter sw = File.CreateText(txtfile);
            for (int i = 0; i < list.Count; ++i)
                sw.WriteLine(list[i].maHDN + "\t" + list[i].maNV + "\t" + list[i].maNCC + "\t" + list[i].maDT + "\t" + list[i].ngayNhap + "\t" + list[i].soLuong + "\t" + list[i].donGia + "\t" + list[i].tongTien);
            sw.Close();
        }
    }
}
