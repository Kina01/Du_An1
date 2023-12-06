using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class NhanVien
    {
        private string maNhanVien;
        private string taiKhoan;
        private string matKhau;
        private string hoTenNhanVien;

        protected string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        protected string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        protected string MatKhau { get => matKhau; set => matKhau = value; }
        protected string HoTenNhanVien { get => hoTenNhanVien; set => hoTenNhanVien = value; }

        public NhanVien()
        {
            MaNhanVien = "";
            TaiKhoan = "";
            MatKhau = "";
            HoTenNhanVien = "";
        }

        public NhanVien(string maNV, string tk, string mk, string hoTen)
        {
            this.MaNhanVien = maNV;
            this.TaiKhoan = tk;
            this.MatKhau = mk;
            this.HoTenNhanVien = hoTen;
        }
    }
}
