using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;

namespace Moblie_store.Business.Interface
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface IKhachHangBLL
    {
        List<KhachHang> LayDSKhachHang();
        void ThemKhachHang(KhachHang kh);
        void XoaKhachHang(int makh);
        void SuaKhachHang(KhachHang kh);
        List<KhachHang> TimKhachHang(KhachHang kh);
        KhachHang LayKhachHang(int makh);
    }
}
