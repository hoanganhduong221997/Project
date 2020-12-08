﻿using System;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.Business;
using Moblie_store.Business.Interface;

namespace Moblie_store.Presenation
{
    //Giao tiếp với người sử dụng để giải quyết vấn đề của bài toán với các yêu cầu được đặt ra trong Interface của Business
    public class FormNhanVien
    {
        public void Nhap()
        {
            do
            {
                INhanVienBLL nhanvien = new NhanVienBLL();
                Console.Clear();
                IO.BoxTitle("                                    NHẬP THÔNG TIN NHÂN VIÊN", 1, 1, 10, 100);
                IO.Writexy("Họ tên:", 5, 4);
                IO.Writexy("Ngày sinh:", 39, 4);
                IO.Writexy("Địa chỉ:", 65, 4);
                IO.Writexy("Giới tính:", 5, 6);
                IO.Writexy("Số điện thoại:", 26, 6);
                IO.Writexy("Loại nhân viên:", 56, 6);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 7);
                Hien(1, 13, nhanvien.LayDSNhanVien(), 5, 0);
                NhanVien nv = new NhanVien();

                do
                {
                    nv.tenNV = IO.ReadString(13, 4);
                    if (nv.tenNV == null)
                        IO.Writexy("Nhập lại tên nhân viên...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (nv.tenNV == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    nv.ngaySinh = IO.ReadString(50, 4);
                    if (nv.ngaySinh == null)
                        IO.Writexy("Nhập lại ngày sinh...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (nv.ngaySinh == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    nv.diaChi = IO.ReadString(74, 4);
                    if (nv.diaChi == null)
                        IO.Writexy("Nhập lại địa chỉ...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (nv.diaChi == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    nv.gioiTinh = IO.ReadString(16, 6);
                    if (nv.gioiTinh == null)
                        IO.Writexy("Nhập lại giới tính...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (nv.gioiTinh == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    nv.soDT = IO.ReadNumber(41, 6);
                    if (nv.soDT == null)
                        IO.Writexy("Nhập lại số điện thoại...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (nv.soDT == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    nv.loaiNV = IO.ReadString(72, 6);
                    if (nv.loaiNV == null)
                        IO.Writexy("Nhập lại loại nhân viên...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (nv.loaiNV == null);

                IO.Clear(4, 8, 30, ConsoleColor.Black);
                IO.Writexy("Enter để nhập, Esc để thoát...", 5, 8);
                Console.SetCursorPosition(35, 8);
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                    HienChucNang();
                else if (kt.Key == ConsoleKey.Enter)
                {
                    nhanvien.ThemNhanVien(nv);
                    Hien(1, 13, nhanvien.LayDSNhanVien(), 5, 1);
                }
            } while (true);
        }
        public void Sua()
        {
            INhanVienBLL nhanvien = new NhanVienBLL();
            Console.Clear();
            IO.BoxTitle("                                  CẬP NHẬT THÔNG TIN NHÂN VIÊN", 1, 1, 10, 100);
            IO.Writexy("Mã NV:", 3, 4);
            IO.Writexy("Họ tên:", 18, 4);
            IO.Writexy("Ngày sinh:", 51, 4);
            IO.Writexy("Giới tính:", 80, 4);
            IO.Writexy("Địa chỉ:", 3, 6);
            IO.Writexy("Số điện thoại:", 32, 6);
            IO.Writexy("Loại nhân viên:", 65, 6);
            IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 7);
            Hien(1, 13, nhanvien.LayDSNhanVien(), 5, 0);

            int manv;
            string tennv;
            string ngaysinh;
            string gioitinh;
            string diachi;
            string sdt;
            string loainv;

            do
            {
                manv = int.Parse(IO.ReadNumber(10, 4));
                if (manv <= 0)
                    IO.Writexy("Nhập lại mã nhân viên...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
            } while (manv <= 0);
            NhanVien nv = nhanvien.LayNhanVien(manv);
            IO.Writexy(nv.tenNV, 26, 4);
            IO.Writexy(nv.ngaySinh, 62, 4);
            IO.Writexy(nv.gioiTinh, 91, 4);
            IO.Writexy(nv.diaChi, 12, 6);
            IO.Writexy(nv.soDT, 47, 6);
            IO.Writexy(nv.loaiNV, 81, 6);

            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                tennv = IO.ReadString(26, 4);
                if (tennv == null)
                    IO.Writexy("Nhập lại tên máy tính...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (tennv != nv.tenNV && tennv != null)
                    nv.tenNV = CongCu.ChuanHoaXau(tennv);
            } while (tennv == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                ngaysinh = IO.ReadString(62, 4);
                if (ngaysinh == null)
                    IO.Writexy("Nhập lại ngày sinh...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (ngaysinh != nv.ngaySinh && ngaysinh != null)
                    nv.ngaySinh = CongCu.CatXau(ngaysinh);
            } while (ngaysinh == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                gioitinh = IO.ReadString(91, 4);
                if (gioitinh == null)
                    IO.Writexy("Nhập lại giới tính...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (gioitinh != nv.gioiTinh && gioitinh != null)
                    nv.gioiTinh = CongCu.ChuanHoaXau(gioitinh);
            } while (gioitinh == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                diachi = IO.ReadString(12, 6);
                if (diachi == null)
                    IO.Writexy("Nhập lại địa chỉ...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (diachi != nv.diaChi && diachi != null)
                    nv.diaChi = CongCu.ChuanHoaXau(diachi);
            } while (diachi == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                sdt = IO.ReadNumber(47, 6);
                if (sdt == null)
                    IO.Writexy("Nhập lại số điện thoại...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (sdt != nv.soDT && sdt != null)
                    nv.soDT = CongCu.CatXau(sdt);
            } while (sdt == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                loainv = IO.ReadString(81, 6);
                if (tennv == null)
                    IO.Writexy("Nhập lại loại nhân viên...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (loainv != nv.loaiNV && loainv != null)
                    nv.loaiNV = CongCu.HoaDau(loainv);
            } while (loainv == null);

            IO.Clear(4, 8, 30, ConsoleColor.Black);
            IO.Writexy("Enter để nhập, Esc để thoát...", 5, 8);
            Console.SetCursorPosition(35, 8);
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
                HienChucNang();
            else if (kt.Key == ConsoleKey.Enter)
            {
                nhanvien.SuaNhanVien(nv);
                Hien(1, 13, nhanvien.LayDSNhanVien(), 5, 1);
            }
            HienChucNang();
        }
        public void Xoa()
        {
            int manv = 0;
            do
            {
                Console.Clear();
                INhanVienBLL nhanvien = new NhanVienBLL();
                Console.Clear();
                IO.BoxTitle("                                        XÓA NHÂN VIÊN", 1, 1, 7, 100);
                IO.Writexy("Nhập mã nhân viên cần xóa:", 5, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để xóa, Esc để thoát...", 5, 6);
                Hien(1, 8, nhanvien.LayDSNhanVien(), 5, 0);
                do
                {
                    manv = int.Parse(IO.ReadNumber(32, 4));
                    if (manv <= 0)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại mã nhân viên...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        IO.Clear(5, 8, 30, ConsoleColor.Black);
                        IO.Writexy("Enter để xóa, Esc để thoát...", 5, 6);
                        nhanvien.XoaNhanVien(manv);
                    }
                } while (manv <= 0);
                Hien(1, 8, nhanvien.LayDSNhanVien(), 5, 1);
            } while (true);
        }
        public void Xem()
        {
            INhanVienBLL nhanvien = new NhanVienBLL();
            Console.Clear();
            Hien(1, 1, nhanvien.LayDSNhanVien(), 5, 1);
            HienChucNang();
        }
        public void TimTen()
        {
            string hoten = "";
            do
            {
                Console.Clear();
                INhanVienBLL nhanvien = new NhanVienBLL();
                Console.Clear();
                IO.BoxTitle("                                      TÌM KIẾM NHÂN VIÊN", 1, 1, 7, 100);
                IO.Writexy("Nhập họ tên nhân viên cần tìm:", 3, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để tìm, Esc để thoát...", 5, 6);
                Hien(1, 8, nhanvien.LayDSNhanVien(), 5, 0);
                do
                {
                    hoten = IO.ReadString(34, 4);
                    if (hoten == null)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại tên nhân viên...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        List<NhanVien> list = nhanvien.TimNhanVien(new NhanVien(0, CongCu.ChuanHoaXau(hoten), null, null, null, null, null));
                        Hien(1, 8, list, 5, 1);
                    }
                } while (hoten == null);
            } while (true);
        }
        public void TimMa()
        {
            int manv = 0;
            do
            {
                Console.Clear();
                INhanVienBLL nhanvien = new NhanVienBLL();
                Console.Clear();
                IO.BoxTitle("                                      TÌM KIẾM NHÂN VIÊN", 1, 1, 7, 100);
                IO.Writexy("Nhập mã nhân viên cần tìm:", 3, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để tìm, Esc để thoát...", 5, 6);
                Hien(1, 8, nhanvien.LayDSNhanVien(), 5, 0);
                do
                {
                    manv = int.Parse(IO.ReadNumber(30, 4));
                    if (manv <= 0)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại mã nhân viên...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        List<NhanVien> list = nhanvien.TimNhanVien(new NhanVien(manv, null, null, null, null, null, null));
                        Hien(1, 8, list, 5, 1);
                    }
                } while (manv <= 0);
            } while (true);
        }
        public void Hien(int xx, int yy, List<NhanVien> list, int n, int type)
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
                IO.Writexy("                                            DANH SÁCH NHÂN VIÊN", x, y);
                IO.Writexy("┌───────┬───────────────────────┬───────────────┬───────────┬───────────────┬─────────────┬─────────────────┐", x, y + 1);
                IO.Writexy("│ Mã NV │         Họ tên        │   Ngày sinh   │ Giới tính │    Địa chỉ    │    Số ĐT    │     Loại NV     │", x, y + 2);
                IO.Writexy("├───────┼───────────────────────┼───────────────┼───────────┼───────────────┼─────────────┼─────────────────┤", x, y + 3);
                y += 4;
                for (int i = head; i < final; i++)
                {
                    IO.Writexy("│", x, y + d, 8);
                    IO.Writexy(list[i].maNV.ToString(), x + 1, y + d, 8);
                    IO.Writexy("│", x + 8, y + d);
                    IO.Writexy(list[i].tenNV, x + 9, y + d, 24);
                    IO.Writexy("│", x + 32, y + d);
                    IO.Writexy(list[i].ngaySinh, x + 33, y + d, 16);
                    IO.Writexy("│", x + 48, y + d);
                    IO.Writexy(list[i].gioiTinh, x + 49, y + d, 12);
                    IO.Writexy("│", x + 60, y + d);
                    IO.Writexy(list[i].diaChi, x + 61, y + d, 16);
                    IO.Writexy("│", x + 76, y + d);
                    IO.Writexy(list[i].soDT, x + 77, y + d, 14);
                    IO.Writexy("│", x + 90, y + d);
                    IO.Writexy(list[i].loaiNV, x + 91, y + d, 18);
                    IO.Writexy("│", x + 108, y + d);
                    if (i < final - 1)
                        IO.Writexy("├───────┼───────────────────────┼───────────────┼───────────┼───────────────┼─────────────┼─────────────────┤", x, y + d + 1);
                    y += 1;
                    d += 1;
                }
                IO.Writexy("└───────┴───────────────────────┴───────────────┴───────────┴───────────────┴─────────────┴─────────────────┘", x, y + d - 1);
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
                " F1.Nhập danh sách nhân viên ",
                " F2.Sửa thông tin nhân viên ",
                " F3.Xóa nhân viên ",
                " F4.Hiển thị danh sách nhân viên ",
                " F5.Tìm kiếm nhân viên ",
                " F6.Quay lại "
            };
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            MenuNV mnnv = new MenuNV(mn);
            mnnv.HienTheoPhimTat(15, 6, ConsoleColor.Black, ConsoleColor.White);
            Console.ReadKey();
        }
        public class MenuNV : Menu
        {
            public MenuNV(string[] mn) : base(mn)
            {
            }
            public override void ThucHien(int location)
            {
                FormNhanVien nhanvien = new FormNhanVien();
                switch (location)
                {
                    case 0:
                        nhanvien.Nhap();
                        break;
                    case 1:
                        nhanvien.Sua();
                        break;
                    case 2:
                        nhanvien.Xoa();
                        break;
                    case 3:
                        nhanvien.Xem();
                        break;
                    case 4:
                        nhanvien.HienTimKiem();
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
                " F1.Tìm kiếm nhân viên theo mã ",
                " F2.Tìm kiếm nhân viên theo tên ",
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
                FormNhanVien nhanvien = new FormNhanVien();
                switch (location)
                {
                    case 0:
                        nhanvien.TimMa();
                        break;
                    case 1:
                        nhanvien.TimTen();
                        break;
                    case 2:
                        nhanvien.HienChucNang();
                        break;
                }
            }
        }
    }
}
