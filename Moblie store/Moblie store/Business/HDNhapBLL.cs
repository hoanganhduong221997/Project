﻿using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.DataAccessLayer;
using Moblie_store.DataAccessLayer.Interface;
using Moblie_store.Business.Interface;

namespace Moblie_store.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IHDNhapBLL
    public class HDNhapBLL : IHDNhapBLL
    {
        private IHDNhapDAL hdnDAL = new HDNhapDAL();
        public List<HDNhap> LayDSHDNhap()
        {
            return hdnDAL.GetData();
        }
        public void ThemHDNhap(HDNhap hdn)
        {
            if (hdn.ngayNhap != "")
            {
                hdn.ngayNhap = CongCu.CatXau(hdn.ngayNhap);
                hdnDAL.Insert(hdn);
            }
            else
                throw new Exception("Dữ liệu sai.");
        }
        public HDNhap LayHDNhap(int mahdn)
        {
            int i;
            List<HDNhap> list = hdnDAL.GetData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHDN == mahdn)
                    break;
            if (i < list.Count)
                return list[i];
            else
                throw new Exception("Không tồn tại mã này.");
        }
        public void XoaHDNhap(int mahdn)
        {
            int i;
            List<HDNhap> list = hdnDAL.GetData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHDN == mahdn)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                hdnDAL.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã này.");
        }
        public void SuaHDNhap(HDNhap hdn)
        {
            int i;
            List<HDNhap> list = hdnDAL.GetData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maHDN == hdn.maHDN)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(hdn, i);
                hdnDAL.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã này.");
        }
        public List<HDNhap> TimHDNhap(HDNhap hdn)
        {
            List<HDNhap> list = hdnDAL.GetData();
            List<HDNhap> kq = new List<HDNhap>();
            if (hdn.maHDN == 0)
            {
                kq = list;
            }
            //Tìm theo mã
            if (hdn.maHDN > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].maHDN == hdn.maHDN)
                        kq.Add(new HDNhap(list[i]));
            }
            else
                kq = null;
            return kq;
        }
    }
}
