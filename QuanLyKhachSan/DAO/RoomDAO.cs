﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAO
{
    public class RoomDAO
    {
        private RoomDAO() { }
        private static RoomDAO instance;
        public static RoomDAO Instance
        {
            get
            {
                if (instance == null) instance = new RoomDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        
        public DataTable ExecuteQuerySearchCodeRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.TinhTrangPhong = p.TinhTrangPhong where p.MaPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public DataTable ExecuteQuerySearchStyleRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.MaLoaiPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }

        public DataTable ExecuteQuerySearchStatusRoom(string _str)
        {
            string query = "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.TinhTrangPhong = " + _str;
            return DataProvide.Instance.ExecuteQuery(query);
        }
        public string codeRoomSearchListQuery() { return  "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.MaPhong = "; }
        public string styleRoomSearch() { return "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.MaLoaiPhong = "; }
        public string statusRoomSearch() { return "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong = p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai = p.TinhTrangPhong where p.TinhTrangPhong = ";}
        public string ExecuteLoadInforRoomQuery() { return "select  p.MaPhong as 'Mã Phòng',p.TenPhong as 'Tên Phòng',lp.TenLoaiPhong as 'Loại Phòng',p.GhiChu as 'Ghi Chú',tt.TenTrangThai as 'Trạng Thái' from LOAI_PHONG lp inner join PHONG p on lp.MaLoaiPhong=p.MaLoaiPhong inner join TRANG_THAI_PHONG tt on tt.MaTrangThai=p.TinhTrangPhong"; }
        public string setDataStyleRoomQuery() { return "select MaLoaiPhong,TenLoaiPhong From dbo.LOAI_PHONG"; }
        public string setDataRoomStatusQuery() { return "select MaTrangThai,TenTrangThai from dbo.TRANG_THAI_PHONG"; }
        public string setDataPriceRoomQuery() { return "select DonGia from dbo.LOAI_PHONG"; }
        public string cbxstyleRoom_SelectIndexQuery() { return "select DonGia from dbo.LOAI_PHONG where MaLoaiPhong = ";}
        public string addRoomDatabaseQuery() { /*use PROC in SQL SEVER */return "EXEC dbo.AddRoomToDataBase @RoomCode , @RoomName , @RoomStyle , @RoomNote "; }

        public string deleteRoomDatabaseQuery() { return "DELETE FROM dbo.PHONG WHERE MaPhong ="; }

        public string UpdateRoomDatabaseQuery() { /*use PROC in SQL SEVER */return "EXEC dbo.UpdateRoomToDataBase @RoomCodeNew , @RoomName , @RoomStyle , @RoomNote , @RoomStatus , @RoomCodeOld "; }



    }
}
