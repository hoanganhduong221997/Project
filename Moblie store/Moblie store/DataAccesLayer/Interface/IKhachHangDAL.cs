using System;
using System.Collections.Generic;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;

namespace Moblie_store.DataAccesLayer.Interface
{
    //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    public interface IKhachHangDAL
    {
        List<KhachHang> GetData();
        void Insert(KhachHang kh);
        void Update(List<KhachHang> list);
    }
}
