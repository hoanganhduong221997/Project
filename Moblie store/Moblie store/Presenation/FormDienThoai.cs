using System;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.Business;
using Moblie_store.Business.Interface;

namespace Moblie_store.Presenation
{
    //Giao tiếp với người sử dụng để giải quyết vấn đề của bài toán với các yêu cầu được đặt ra trong Interface của Business
    public class FormDienThoai
    {
        public void Nhap()
        {
            do
            {
                IDienThoaiBLL dienthoai = new DienThoaiBLL();
                INCC_BLL nhacc = new NCC_BLL();
                FormNCC fncc = new FormNCC();
                Console.Clear();
                IO.BoxTitle("                                    NHẬP THÔNG TIN ĐIỆN THOẠI ", 1, 1, 10, 100);
                IO.Writexy("Tên máy:", 5, 4);
                IO.Writexy("Mã nhà cung cấp:", 57, 4);
                IO.Writexy("Số lượng nhập:", 5, 6);
                IO.Writexy("Số lượng còn:", 57, 6);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 7);
                Hien(1, 13, dienthoai.LayDSDienThoai(), 5, 0);
                DienThoai dt = new DienThoai();

                do
                {
                    dt.tenDT = IO.ReadString(14, 4);
                    if (dt.tenDT == null)
                        IO.Writexy("Nhập lại tên máy...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (dt.tenDT == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                fncc.Hien(1, 13, nhacc.LayDSNCC(), 5, 0);
                do
                {
                    dt.maNCC = int.Parse(IO.ReadNumber(74, 4));
                    if (dt.maNCC <= 0)
                        IO.Writexy("Nhập lại mã nhà cung cấp...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (dt.maNCC <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                Hien(1, 13, dienthoai.LayDSDienThoai(), 5, 0);
                do
                {
                    dt.sLNhap = int.Parse(IO.ReadNumber(20, 6));
                    if (dt.sLNhap <= 0)
                        IO.Writexy("Nhập lại số lượng nhập...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (dt.sLNhap <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    dt.sLCon = int.Parse(IO.ReadNumber(71, 6));
                    if (dt.sLCon < 0)
                        IO.Writexy("Nhập lại số lượng còn...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (dt.sLCon < 0);

                IO.Clear(4, 8, 30, ConsoleColor.Black);
                IO.Writexy("Enter để nhập, Esc để thoát...", 5, 8);
                Console.SetCursorPosition(35, 8);
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                    HienChucNang();
                else if (kt.Key == ConsoleKey.Enter)
                {
                    dienthoai.ThemDienThoai(dt);
                    Hien(1, 13, dienthoai.LayDSDienThoai(), 5, 1);
                }
            } while (true);
        }

        public void Sua()
        {
            IDienThoaiBLL dienThoai = new DienThoaiBLL();
            INCC_BLL nhacc = new NCC_BLL();
            FormNCC fncc = new FormNCC();
            Console.Clear();
            IO.BoxTitle("                                   CẬP NHẬT THÔNG TIN ĐIỆN THOẠI ", 1, 1, 10, 100);
            IO.Writexy("Mã DT:", 3, 4);
            IO.Writexy("Tên máy:", 44, 4);
            IO.Writexy("Mã nhà CC:", 3, 6);
            IO.Writexy("Số lượng nhập:", 32, 6);
            IO.Writexy("Số lượng còn:", 63, 6);
            IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 7);
            Hien(1, 13, dienThoai.LayDSDienThoai(), 5, 0);

            int madt;
            string tenmay;
            int mancc;
            int sln;
            int slc;

            do
            {
                madt = int.Parse(IO.ReadNumber(10, 4));
                if (madt <= 0)
                    IO.Writexy("Nhập lại mã máy tính...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
            } while (madt <= 0);
            DienThoai dt = dienThoai.LayDienThoai(madt);
            IO.Writexy(dt.tenDT, 53, 4);
            IO.Writexy(dt.maNCC.ToString(), 14, 6);
            IO.Writexy(dt.sLNhap.ToString(), 47, 6);
            IO.Writexy(dt.sLCon.ToString(), 77, 6);

            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                tenmay = IO.ReadString(53, 4);
                if (tenmay == null)
                    IO.Writexy("Nhập lại tên điện thoại...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (tenmay != dt.tenDT && tenmay != null)
                    dt.tenDT = CongCu.HoaDau(tenmay);
            } while (tenmay == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            fncc.Hien(1, 13, nhacc.LayDSNCC(), 5, 0);
            do
            {
                mancc = int.Parse(IO.ReadNumber(14, 6));
                if (mancc <= 0)
                    IO.Writexy("Nhập lại mã nhà cung cấp...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (mancc != dt.maNCC && mancc > 0)
                    dt.maNCC = mancc;
            } while (mancc <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            Hien(1, 13, dienThoai.LayDSDienThoai(), 5, 0);
            do
            {
                sln = int.Parse(IO.ReadNumber(47, 6));
                if (sln <= 0)
                    IO.Writexy("Nhập lại số lượng nhập...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (sln != dt.sLNhap && sln > 0)
                    dt.sLNhap = sln;
            } while (sln <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                slc = int.Parse(IO.ReadNumber(77, 6));
                if (slc <= 0)
                    IO.Writexy("Nhập lại mã nhà cung cấp...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (slc != dt.sLCon && slc >= 0)
                    dt.sLCon = slc;
            } while (slc <= 0);

            IO.Clear(4, 8, 30, ConsoleColor.Black);
            IO.Writexy("Enter để cập nhật, Esc để thoát...", 5, 8);
            Console.SetCursorPosition(39, 8);
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
                HienChucNang();
            else if (kt.Key == ConsoleKey.Enter)
            {
                dienThoai.SuaDienThoai(dt);
                Hien(1, 13, dienThoai.LayDSDienThoai(), 5, 1);
            }
            HienChucNang();
        }
        public void Xoa()
        {
            int madt = 0;
            do
            {
                Console.Clear();
                IDienThoaiBLL dienthoai = new DienThoaiBLL();
                Console.Clear();
                IO.BoxTitle("                                        XÓA ĐIỆN THOẠI", 1, 1, 7, 100);
                IO.Writexy("Nhập mã điện thoại cần xóa:", 5, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để xóa, Esc để thoát...", 5, 6);
                Hien(1, 8, dienthoai.LayDSDienThoai(), 5, 0);
                do
                {
                    madt = int.Parse(IO.ReadNumber(31, 4));
                    if (madt <= 0)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại mã điện thoại...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        IO.Clear(5, 8, 30, ConsoleColor.Black);
                        IO.Writexy("Enter để xóa, Esc để thoát...", 5, 6);
                        dienthoai.XoaDienThoai(madt);
                    }
                } while (madt <= 0);
                Hien(1, 8, dienthoai.LayDSDienThoai(), 5, 1);
            } while (true);
        }
        public void Xem()
        {
            IDienThoaiBLL dienthoai = new DienThoaiBLL();
            Console.Clear();
            Hien(1, 1, dienthoai.LayDSDienThoai(), 5, 1);
            HienChucNang();
        }
        public void TimTen()
        {
            string tendt = "";
            do
            {
                Console.Clear();
                IDienThoaiBLL dienthoai = new DienThoaiBLL();
                Console.Clear();
                IO.BoxTitle("                                      TÌM KIẾM ĐIỆN THOẠI", 1, 1, 7, 100);
                IO.Writexy("Nhập tên điện thoại cần tìm:", 3, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để tìm, Esc để thoát...", 5, 6);
                Hien(1, 8, dienthoai.LayDSDienThoai(), 5, 0);
                do
                {
                    tendt = IO.ReadString(30, 4);
                    if (tendt == null)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại tên điện thoại...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        List<DienThoai> list = dienthoai.TimDienThoai(new DienThoai(0, CongCu.HoaDau(tendt), 0, 0, 0));
                        Hien(1, 8, list, 5, 1);
                    }
                } while (tendt == null);
            } while (true);
        }
        public void TimMa()
        {
            int madt = 0;
            do
            {
                Console.Clear();
                IDienThoaiBLL dienthoai = new DienThoaiBLL();
                Console.Clear();
                IO.BoxTitle("                                      TÌM KIẾM ĐIỆN THOẠI", 1, 1, 7, 100);
                IO.Writexy("Nhập mã điện thoại cần tìm:", 3, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để tìm, Esc để thoát...", 5, 6);
                Hien(1, 8, dienthoai.LayDSDienThoai(), 5, 0);
                do
                {
                    madt = int.Parse(IO.ReadNumber(29, 4));
                    if (madt <= 0)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại mã điện thoại...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        List<DienThoai> list = dienthoai.TimDienThoai(new DienThoai(madt, null, 0, 0, 0));
                        Hien(1, 8, list, 5, 1);
                    }
                } while (madt <= 0);
            } while (true);
        }
        public void Hien(int xx, int yy, List<DienThoai> list, int n, int type)
        {
            int head = 0;
            int curpage = 1;
            int totalpage = list.Count % n == 0 ? list.Count / n : list.Count / n + 1;
            int final = list.Count <= n ? list.Count : n;
            int x, y, d;
            do
            {
                IO.Clear(xx, yy, 1500, ConsoleColor.Black);
                head = (curpage - 1) * n;
                final = curpage * n < list.Count ? curpage * n : list.Count;
                x = xx;
                y = yy;
                d = 0;
                IO.Writexy("                              DANH SÁCH ĐIỆN THOẠI", x, y);
                IO.Writexy("┌─────────────┬─────────────────────────┬───────────┬───────────────┬──────────────┐", x, y + 1);
                IO.Writexy("│Mã điện thoại│      Tên điện thoại     │ Mã nhà CC │ Số lượng nhập │ Số lượng còn │", x, y + 2);
                IO.Writexy("├─────────────┼─────────────────────────┼───────────┼───────────────┼──────────────┤", x, y + 3);
                y += 4;
                for (int i = head; i < final; i++)
                {
                    IO.Writexy("│", x, y + d, 14);
                    IO.Writexy(list[i].maDT.ToString(), x + 1, y + d, 14);
                    IO.Writexy("│", x + 14, y + d);
                    IO.Writexy(list[i].tenDT, x + 15, y + d, 26);
                    IO.Writexy("│", x + 40, y + d);
                    IO.Writexy(list[i].maNCC.ToString(), x + 41, y + d, 12);
                    IO.Writexy("│", x + 52, y + d);
                    IO.Writexy(list[i].sLNhap.ToString(), x + 53, y + d, 16);
                    IO.Writexy("│", x + 68, y + d);
                    IO.Writexy(list[i].sLCon.ToString(), x + 69, y + d, 15);
                    IO.Writexy("│", x + 83, y + d);
                    if (i < final - 1)
                        IO.Writexy("├─────────────┼─────────────────────────┼───────────┼───────────────┼──────────────┤", x, y + d + 1);
                    y += 1;
                    d += 1;
                }
                IO.Writexy("└─────────────┴─────────────────────────┴───────────┴───────────────┴──────────────┘", x, y + d - 1);
                IO.Writexy(" Trang " + curpage + "/" + totalpage, x, y + d);
                IO.Writexy(" Trang " + curpage + "/" + totalpage + "          Nhấn PagegUp để xem trước, PagegDown để xem tiep, Esc để thoát...", x, y + d);
                if (type == 0)
                    break;
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.PageDown)
                {
                    if (curpage < totalpage)
                        curpage += 1;
                    else
                        curpage = 1;
                }
                else if (kt.Key == ConsoleKey.PageUp)
                {
                    if (curpage > 1)
                        curpage -= 1;
                    else
                        curpage = totalpage;
                }
                else if (kt.Key == ConsoleKey.Escape)
                    break;
            } while (true);
        }
        public void HienChucNang()
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            string[] mn =
            {
                " F1.Nhập danh sách điện thoại ",
                " F2.Sửa thông tin điện thoại ",
                " F3.Xóa điện thoại ",
                " F4.Hiển thị danh sách điện thoại ",
                " F5.Tìm kiếm điện thoại ",
                " F6.Quay lại "
            };
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            MenuDT mndt = new MenuDT(mn);
            mndt.HienTheoPhimTat(15, 6, ConsoleColor.Black, ConsoleColor.White);
            Console.ReadKey();
        }
        public class MenuDT : Menu
        {
            public MenuDT(string[] mn) : base(mn)
            {
            }
            public override void ThucHien(int location)
            {
                FormDienThoai dienthoai = new FormDienThoai();
                switch (location)
                {
                    case 0:
                        dienthoai.Nhap();
                        break;
                    case 1:
                        dienthoai.Sua();
                        break;
                    case 2:
                        dienthoai.Xoa();
                        break;
                    case 3:
                        dienthoai.Xem();
                        break;
                    case 4:
                        dienthoai.HienTimKiem();
                        break;
                    case 5:
                        FormMenuChinh.Hien();
                        break;
                }
            }
        }
        public void HienTimKiem()
        {
            Console.WindowHeight = Console.LargestWindowHeight;
            string[] mn =
            {
                " F1.Tìm kiếm điện thoại theo mã ",
                " F2.Tìm kiếm điện thoại theo tên ",
                " F3.Quay lại "
            };
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            MenuTimKiem mntk = new MenuTimKiem(mn);
            mntk.HienTheoPhimTat(15, 6, ConsoleColor.Black, ConsoleColor.White);
            Console.ReadKey();
        }
        public class MenuTimKiem : Menu
        {
            public MenuTimKiem(string[] mn) : base(mn)
            {
            }
            public override void ThucHien(int location)
            {
                FormDienThoai dienthoai = new FormDienThoai();
                switch (location)
                {
                    case 0:
                        dienthoai.TimMa();
                        break;
                    case 1:
                        dienthoai.TimTen();
                        break;
                    case 2:
                        dienthoai.HienChucNang();
                        break;
                }
            }
        }
    }
}
