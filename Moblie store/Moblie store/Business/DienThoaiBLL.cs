using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.DataAccessLayer;
using Moblie_store.DataAccessLayer.Interface;
using Moblie_store.Business.Interface;

namespace Moblie_store.Business
{
    //Thực thi các yêu cầu nghiệm vụ của bài toán đã được quy định tại IDienThoaiBLL
    public class DienThoaiBLL : IDienThoaiBLL
    {
        private IDienThoaiDAL dtDAL = new DienThoaiDAL();
        public List<DienThoai> LayDSDienThoai()
        {
            return dtDAL.GetData();
        }
        public void ThemdienThoai(DienThoai dt)
        {
            if (dt.tenDT != "")
            {
                dt.tenDT = CongCu.HoaDau(dt.tenDT);
                dtDAL.Insert(dt);
            }
            else
                throw new Exception("Dữ liệu sai.");
        }
        public DienThoai LayDienThoai(int madt)
        {
            int i;
            List<DienThoai> list = dtDAL.GetData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maDT == madt)
                    break;
            if (i < list.Count)
                return list[i];
            else
                throw new Exception("Không tồn tại mã này.");
        }
        public void XoaMayTinh(int madt)
        {
            int i;
            List<DienThoai> list = dtDAL.GetData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maDT == madt)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                dtDAL.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã này.");
        }
        public void SuaDienThoai(DienThoai dt)
        {
            int i;
            List<DienThoai> list = dtDAL.GetData();
            for (i = 0; i < list.Count; ++i)
                if (list[i].maDT == dt.maDT)
                    break;
            if (i < list.Count)
            {
                list.RemoveAt(i);
                list.Add(dt, i);
                dtDAL.Update(list);
            }
            else
                throw new Exception("Không tồn tại mã này.");
        }
        public List<DienThoai> TimDienThoai(DienThoai dt)
        {
            List<DienThoai> list = dtDAL.GetData();
            List<DienThoai> kq = new List<DienThoai>();
            if (dt.maDT == 0 && dt.tenDT == null)
            {
                kq = list;
            }
            //Tìm theo tên
            if (dt.tenDT != null && dt.maDT == 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].tenDT.IndexOf(dt.tenDT) >= 0)
                        kq.Add(new DienThoai(list[i]));
            }
            //Tìm theo mã
            else if (dt.tenDT == null && dt.maDT > 0)
            {
                for (int i = 0; i < list.Count; ++i)
                    if (list[i].maDT == dt.maDT)
                        kq.Add(new DienThoai(list[i]));
            }
            else
                kq = null;
            return kq;
        }

        public void ThemDienThoai(DienThoai dt)
        {
            throw new NotImplementedException();
        }

        public void XoaDienThoai(int madt)
        {
            throw new NotImplementedException();
        }

        public DienThoai LaydienThoai(int madt)
        {
            throw new NotImplementedException();
        }
    }
}
