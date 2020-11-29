using System;
using System.Collections;
using System.Text;
using Moblie_store.Entities;
using Moblie_store.Utility;

namespace Moblie_store.DataAccessLayer.Interface
{
    //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    public interface IDienThoaiDAL
    {
        List<DienThoai> GetData();
        void Insert(DienThoai dt);
        void Update(List<DienThoai> list);
    }
}
