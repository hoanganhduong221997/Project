using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;

namespace Moblie_store.Business.Interface
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IDienThoaiBLL
    {
        List<DienThoai> LayDSDienThoai();
        void ThemDienThoai(DienThoai dt);
        void XoaDienThoai(int madt);
        void SuaDienThoai(DienThoai dt);
        List<DienThoai> TimDienThoai(DienThoai dt);
        DienThoai LaydienThoai(int madt);
    }
}
