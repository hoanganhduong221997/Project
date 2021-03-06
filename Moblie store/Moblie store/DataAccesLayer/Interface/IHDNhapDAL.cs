﻿using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;

namespace Moblie_store.DataAccessLayer.Interface
{
    //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    public interface IHDNhapDAL
    {
        List<HDNhap> GetData();
        void Insert(HDNhap hdn);
        void Update(List<HDNhap> list);
    }
}
