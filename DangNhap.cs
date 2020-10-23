using System;
using System.Collections.Generic;
using System.Text;

namespace Moblie_store.Entities
{
    public class DangNhap
    {
        #region các thành phần dữ liệu
        private string User;
        private string Password;
        #endregion
        #region các phương thức khởi tạo
        public DangNhap()
        { }
        public DangNhap(string user, string pass)
        {
            this.User = user;
            this.Password = pass;
        }
        // phương thức sao chép
        public DangNhap(DangNhap dn)
        {
            this.User = dn.User;
            this.Password = dn.Password;
        }
        #endregion
        #region các thuộc tính
        public string user
        {
            get
            {
                return User;
            }
            set
            {
                if (value != "")
                    User = value;
            }
        }
        public string pass
        {
            get
            {
                return Password;
            }
            set
            {
                if (value != "")
                    Password = value;
            }
        }
        #endregion
    }
}
