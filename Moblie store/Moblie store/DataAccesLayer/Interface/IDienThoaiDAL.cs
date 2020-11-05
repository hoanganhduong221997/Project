using System;
using System.Collections.Generic;
using System.Text;
using Moblie_store.Entities;
using Moblie_store.Utility;

namespace Moblie_store.DataAccesLayer.Interface
{
    //Xác định yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    public class IDienThoaiDAL
    {
        List<DienThoai> GetData();
        void Insert(DienThoai dt);
        void Update(List<DienThoai> list);
    }
}
