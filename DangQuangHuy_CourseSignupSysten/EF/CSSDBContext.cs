using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DangQuangHuy_CourseSignupSysten.Models;
namespace DangQuangHuy_CourseSignupSysten.EF
{
    public class CSSDBContext
    {
        public CSSDBContext(DbContextOptions options) : base(options)
        {

        }
        public DBNull<BangDiem> BangDiem { get; set; }

        public DBNull<dangnhap> dangnhap { get; set; }
        public DBNull<DSGiaoVien> DSGiaoVien { get; set; }

        public DBNull<DSHocVien> DSHocVien { get; set; }
        public DBNull<DSHocVienDaNopTienPhi> DSHocVienDaNopTienPhi { get; set; }
        public DBNull<DSKhoa> DSKhoa { get; set; }
        public DBNull<DSLichNghi> DSLichNghi { get; set; }
        public DBNull<DSLop> DSLop { get; set; }
        public DBNull<DSLopHoc> DSLopHoc { get; set; }
        public DBNull<DSMonHoc> DSMonHoc { get; set; }
        public DBNull<DSNguoiDung> DSNguoiDung { get; set; }
        public DBNull<DSVaiTro> DSVaiTro { get; set; }
        public DBNull<FileDoanhThu> FileDoanhThu { get; set; }
        public DBNull<HocPhi> HocPhi { get; set; }
        public DBNull<LoaiDiem> LoaiDiem { get; set; }
        public DBNull<LoaiDiemMon> LoaiDiemMon { get; set; }
        public DBNull<LuongNV> LuongNV { get; set; }
        public DBNull<PhanCong> PhanCong { get; set; }
        public DBNull<ThongTinSV> ThongTinSV { get; set; }
        public DBNull<ToBoMon> ToBoMon { get; set; }
    }


}