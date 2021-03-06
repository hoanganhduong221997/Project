﻿using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;

namespace Moblie_store.DataAccessLayer.Interface
{
    //Xác định các yêu cầu cần phải thao tác với cơ sở dữ liệu để phục vụ cho phần xử lý nghiệp vụ
    public interface IHDBanDAL
    {
        List<HDBan> GetData();
        void Insert(HDBan hdb);
        void Update(List<HDBan> list);
    }
}
