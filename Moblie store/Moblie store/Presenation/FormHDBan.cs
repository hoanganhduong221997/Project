﻿using System;
using System.Text;
using Moblie_store.Utility;
using Moblie_store.Entities;
using Moblie_store.Business;
using Moblie_store.Business.Interface;

namespace Moblie_store.Presenation
{
    //Giao tiếp với người sử dụng để giải quyết vấn đề của bài toán với các yêu cầu được đặt ra trong Interface của Business
    public class FormHDBan
    {
        public void Nhap()
        {
            do
            {
                IHDBanBLL hdban = new HDBanBLL();
                INhanVienBLL nhanvien = new NhanVienBLL();
                IKhachHangBLL khachhang = new KhachHangBLL();
                IDienThoaiBLL maytinh = new DienThoaiBLL();
                FormNhanVien fnv = new FormNhanVien();
                FormKhachHang fkh = new FormKhachHang();
                FormDienThoai fdt = new FormDienThoai();

                Console.Clear();
                IO.BoxTitle("                                 NHẬP THÔNG TIN HÓA ĐƠN BÁN", 1, 1, 10, 100);
                IO.Writexy("Mã nhân viên:", 3, 4);
                IO.Writexy("Mã khách hàng:", 25, 4);
                IO.Writexy("Mã điện thoại:", 51, 4);
                IO.Writexy("Ngày bán:", 75, 4);
                IO.Writexy("Số lượng:", 3, 6);
                IO.Writexy("Đơn giá:", 33, 6);
                IO.Writexy("Tổng tiền:", 68, 6);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 7);
                HDBan hdb = new HDBan();

                fnv.Hien(1, 13, nhanvien.LayDSNhanVien(), 5, 0);
                do
                {
                    hdb.maNV = int.Parse(IO.ReadString(17, 4));
                    if (hdb.maNV <= 0)
                        IO.Writexy("Nhập lại mã nhân viên...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (hdb.maNV <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                fkh.Hien(1, 13, khachhang.LayDSKhachHang(), 5, 0);
                do
                {
                    hdb.maKH = int.Parse(IO.ReadString(40, 4));
                    if (hdb.maKH <= 0)
                        IO.Writexy("Nhập lại mã khách hàng...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (hdb.maKH <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                fdt.Hien(1, 13, dienthoai.LayDSDienThoai(), 5, 0);
                do
                {
                    hdb.maDT = int.Parse(IO.ReadString(64, 4));
                    if (hdb.maDT <= 0)
                        IO.Writexy("Nhập lại mã điện thoại...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (hdb.maDT <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                Hien(1, 13, hdban.LayDSHDBan(), 5, 0);
                do
                {
                    hdb.ngayBan = IO.ReadString(85, 4);
                    if (hdb.ngayBan == null)
                        IO.Writexy("Nhập lại ngày bán...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (hdb.ngayBan == null);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    hdb.soLuong = int.Parse(IO.ReadNumber(13, 6));
                    if (hdb.soLuong <= 0)
                        IO.Writexy("Nhập lại số lượng...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (hdb.soLuong <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                do
                {
                    hdb.donGia = double.Parse(IO.ReadNumber(42, 6));
                    if (hdb.donGia <= 0)
                        IO.Writexy("Nhập lại đơn giá...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                } while (hdb.donGia <= 0);
                IO.Clear(4, 8, 30, ConsoleColor.Black);
                IO.Writexy(hdb.tongTien.ToString(), 79, 6);

                IO.Clear(4, 8, 30, ConsoleColor.Black);
                IO.Writexy("Enter để nhập, Esc để thoát...", 5, 8);
                Console.SetCursorPosition(35, 8);
                ConsoleKeyInfo kt = Console.ReadKey();
                if (kt.Key == ConsoleKey.Escape)
                    HienChucNang();
                else if (kt.Key == ConsoleKey.Enter)
                {
                    hdban.ThemHDBan(hdb);
                    Hien(1, 13, hdban.LayDSHDBan(), 5, 1);
                }
            } while (true);
        }
        public void Sua()
        {
            IHDBanBLL hdban = new HDBanBLL();
            INhanVienBLL nhanvien = new NhanVienBLL();
            IKhachHangBLL khachhang = new KhachHangBLL();
            IDienThoaiBLL dienthoai = new DienThoaiBLL();
            FormNhanVien fnv = new FormNhanVien();
            FormKhachHang fkh = new FormKhachHang();
            FormDienThoai fdt = new FormDienThoai();

            Console.Clear();
            IO.BoxTitle("                               CẬP NHẬT THÔNG TIN HÓA ĐƠN BÁN", 1, 1, 10, 100);
            IO.Writexy("Mã HD bán:", 3, 4);
            IO.Writexy("Mã nhân viên:", 23, 4);
            IO.Writexy("Mã khách hàng:", 50, 4);
            IO.Writexy("Mã điện thoại:", 76, 4);
            IO.Writexy("Ngày bán:", 3, 6);
            IO.Writexy("Số lượng:", 28, 6);
            IO.Writexy("Đơn giá:", 50, 6);
            IO.Writexy("Tổng tiền:", 74, 6);
            IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 7);
            Hien(1, 13, hdban.LayDSHDBan(), 5, 0);

            int mahdb;
            int manv;
            int makh;
            int madt;
            string ngayban;
            int soluong;
            double dongia;

            do
            {
                mahdb = int.Parse(IO.ReadNumber(14, 4));
                if (mahdb <= 0)
                    IO.Writexy("Nhập lại mã hóa đơn bán...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
            } while (mahdb <= 0);
            HDBan hdb = hdban.LayHDBan(mahdb);
            IO.Writexy(hdb.maNV.ToString(), 37, 4);
            IO.Writexy(hdb.maKH.ToString(), 65, 4);
            IO.Writexy(hdb.maDT.ToString(), 89, 4);
            IO.Writexy(hdb.ngayBan, 13, 6);
            IO.Writexy(hdb.soLuong.ToString(), 38, 6);
            IO.Writexy(hdb.donGia.ToString(), 59, 6);
            IO.Writexy(hdb.tongTien.ToString(), 85, 6);

            IO.Clear(4, 8, 30, ConsoleColor.Black);
            fnv.Hien(1, 13, nhanvien.LayDSNhanVien(), 5, 0);
            do
            {
                manv = int.Parse(IO.ReadNumber(37, 4));
                if (manv <= 0)
                    IO.Writexy("Nhập lại mã nhân viên...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (manv != hdb.maNV && manv > 0)
                    hdb.maNV = manv;
            } while (manv <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            fkh.Hien(1, 13, khachhang.LayDSKhachHang(), 5, 0);
            do
            {
                makh = int.Parse(IO.ReadNumber(65, 4));
                if (makh <= 0)
                    IO.Writexy("Nhập lại mã khách hàng...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (makh != hdb.maKH && makh > 0)
                    hdb.maKH = makh;
            } while (makh <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            fdt.Hien(1, 13, dienthoai.LayDSDienThoai(), 5, 0);
            do
            {
                madt = int.Parse(IO.ReadNumber(89, 4));
                if (madt <= 0)
                    IO.Writexy("Nhập lại mã điện thoại...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (madt != hdb.maDT && madt > 0)
                    hdb.maDT = madt;
            } while (madt <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            Hien(1, 13, hdban.LayDSHDBan(), 5, 0);
            do
            {
                ngayban = IO.ReadString(13, 6);
                if (ngayban == null)
                    IO.Writexy("Nhập lại ngày bán...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (ngayban != hdb.ngayBan && ngayban != null)
                    hdb.ngayBan = CongCu.CatXau(ngayban);
            } while (ngayban == null);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                soluong = int.Parse(IO.ReadNumber(38, 6));
                if (soluong <= 0)
                    IO.Writexy("Nhập lại số lượng...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                else if (soluong != hdb.soLuong && soluong > 0)
                    hdb.soLuong = soluong;
            } while (soluong <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            do
            {
                dongia = double.Parse(IO.ReadNumber(59, 6));
                if (dongia <= 0)
                    IO.Writexy("Nhập lại đơn giá...", 5, 8, ConsoleColor.Black, ConsoleColor.White);
                if (dongia != hdb.donGia && dongia > 0)
                    hdb.donGia = dongia;
            } while (dongia <= 0);
            IO.Clear(4, 8, 30, ConsoleColor.Black);
            IO.Writexy(hdb.tongTien.ToString(), 85, 6);

            IO.Clear(4, 8, 30, ConsoleColor.Black);
            IO.Writexy("Enter để cập nhật, Esc để thoát...", 5, 8);
            Console.SetCursorPosition(39, 8);
            ConsoleKeyInfo kt = Console.ReadKey();
            if (kt.Key == ConsoleKey.Escape)
                HienChucNang();
            else if (kt.Key == ConsoleKey.Enter)
            {
                hdban.SuaHDBan(hdb);
                Hien(1, 13, hdban.LayDSHDBan(), 5, 1);
            }
            HienChucNang();
        }
        public void Xoa()
        {
            int mahdb = 0;
            do
            {
                Console.Clear();
                IHDBanBLL hdban = new HDBanBLL();
                Console.Clear();
                IO.BoxTitle("                                      XÓA HÓA ĐƠN BÁN", 1, 1, 7, 100);
                IO.Writexy("Nhập mã hóa đơn bán cần xóa:", 5, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để xóa, Esc để thoát...", 5, 6);
                Hien(1, 8, hdban.LayDSHDBan(), 5, 0);
                do
                {
                    mahdb = int.Parse(IO.ReadNumber(34, 4));
                    if (mahdb <= 0)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại mã hóa đơn bán...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        IO.Clear(5, 8, 30, ConsoleColor.Black);
                        IO.Writexy("Enter để xóa, Esc để thoát...", 5, 6);
                        hdban.XoaHDBan(mahdb);
                    }
                } while (mahdb <= 0);
                Hien(1, 8, hdban.LayDSHDBan(), 5, 1);
            } while (true);
        }
        public void Xem()
        {
            IHDBanBLL hdban = new HDBanBLL();
            Console.Clear();
            Hien(1, 1, hdban.LayDSHDBan(), 5, 1);
            HienChucNang();
        }
        public void Tim()
        {
            int mahdb = 0;
            do
            {
                Console.Clear();
                IHDBanBLL hdban = new HDBanBLL();
                Console.Clear();
                IO.BoxTitle("                                    TÌM KIẾM HÓA ĐƠN BÁN", 1, 1, 7, 100);
                IO.Writexy("Nhập mã hóa đơn bán cần tìm:", 3, 4);
                IO.Writexy("--------------------------------------------------------------------------------------------------", 2, 5);
                IO.Writexy("Enter để tìm, Esc để thoát...", 5, 6);
                Hien(1, 8, hdban.LayDSHDBan(), 5, 0);
                do
                {
                    mahdb = int.Parse(IO.ReadNumber(32, 4));
                    if (mahdb <= 0)
                    {
                        IO.Clear(5, 6, 30, ConsoleColor.Black);
                        IO.Writexy("Nhập lại mã hóa đơn bán...", 5, 6, ConsoleColor.Black, ConsoleColor.White);
                    }
                    else
                    {
                        List<HDBan> list = hdban.TimHDBan(new HDBan(mahdb, 0, 0, 0, null, 0, 0, 0));
                        Hien(1, 8, list, 5, 1);
                    }
                } while (mahdb <= 0);
            } while (true);
        }
        public void Hien(int xx, int yy, List<HDBan> list, int n, int type)
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
                IO.Writexy("                                        DANH SÁCH HÓA ĐƠN BÁN", x, y);
                IO.Writexy("┌──────────┬──────────┬──────────┬──────────┬─────────────────┬────────────┬─────────────────┬─────────────────┐", x, y + 1);
                IO.Writexy("│  Mã HDB  │  Mã NV   │  Mã KH   │  Mã MT   │    Ngày bán     │  Số lượng  │     Đơn giá     │    Tổng tiền    │", x, y + 2);
                IO.Writexy("├──────────┼──────────┼──────────┼──────────┼─────────────────┼────────────┼─────────────────┼─────────────────┤", x, y + 3);
                y += 4;
                for (int i = head; i < final; i++)
                {
                    IO.Writexy("│", x, y + d, 11);
                    IO.Writexy(list[i].maHDB.ToString(), x + 1, y + d, 11);
                    IO.Writexy("│", x + 11, y + d);
                    IO.Writexy(list[i].maNV.ToString(), x + 12, y + d, 11);
                    IO.Writexy("│", x + 22, y + d);
                    IO.Writexy(list[i].maKH.ToString(), x + 23, y + d, 11);
                    IO.Writexy("│", x + 33, y + d);
                    IO.Writexy(list[i].maDT.ToString(), x + 34, y + d, 11);
                    IO.Writexy("│", x + 44, y + d);
                    IO.Writexy(list[i].ngayBan, x + 45, y + d, 18);
                    IO.Writexy("│", x + 62, y + d);
                    IO.Writexy(list[i].soLuong.ToString(), x + 63, y + d, 13);
                    IO.Writexy("│", x + 75, y + d);
                    IO.Writexy(list[i].donGia.ToString(), x + 76, y + d, 18);
                    IO.Writexy("│", x + 93, y + d);
                    IO.Writexy(list[i].tongTien.ToString(), x + 94, y + d, 18);
                    IO.Writexy("│", x + 111, y + d);
                    if (i < final - 1)
                        IO.Writexy("├──────────┼──────────┼──────────┼──────────┼─────────────────┼────────────┼─────────────────┼─────────────────┤", x, y + d + 1);
                    y += 1;
                    d += 1;
                }
                IO.Writexy("└──────────┴──────────┴──────────┴──────────┴─────────────────┴────────────┴─────────────────┴─────────────────┘", x, y + d - 1);
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
                " F1.Nhập danh sách hóa đơn bán ",
                " F2.Sửa thông tin hóa đơn bán ",
                " F3.Xóa hóa đơn bán ",
                " F4.Hiển thị danh sách hóa đơn bán ",
                " F5.Tìm kiếm hóa đơn bán ",
                " F6.Quay lại "
            };
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            MenuHDB mnhdb = new MenuHDB(mn);
            mnhdb.HienTheoPhimTat(15, 6, ConsoleColor.Black, ConsoleColor.White);
            Console.ReadKey();
        }
        public class MenuHDB : Menu
        {
            public MenuHDB(string[] mn) : base(mn)
            {
            }
            public override void ThucHien(int location)
            {
                FormHDBan hdban = new FormHDBan();
                FormMenuChinh fhd = new FormMenuChinh();
                switch (location)
                {
                    case 0:
                        hdban.Nhap();
                        break;
                    case 1:
                        hdban.Sua();
                        break;
                    case 2:
                        hdban.Xoa();
                        break;
                    case 3:
                        hdban.Xem();
                        break;
                    case 4:
                        hdban.Tim();
                        break;
                    case 5:
                        fhd.HienHoaDon();
                        break;
                }
            }
        }
    }
}
