﻿using System;
using System.Collections;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;

namespace Moblie_store.Business.Interface
{
    //Xác định các yêu cầu nghiệp vụ của bài toán cần phải thực thi
    public interface INCC_BLL
    {
        List<NCC> LayDSNCC();
        void ThemNCC(NCC ncc);
        void XoaNCC(int mancc);
        void SuaNCC(NCC ncc);
        List<NCC> TimNCC(NCC ncc);
        NCC LayNCC(int mancc);
    }
}
