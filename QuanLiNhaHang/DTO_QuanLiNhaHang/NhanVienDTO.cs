using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class NhanVienDTO
    {
        private string maNhanVien;
        private string taiKhoan;
        private string matKhau;

        protected string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        protected string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        protected string MatKhau { get => matKhau; set => matKhau = value; }

        public NhanVienDTO()
        {
            MaNhanVien = "";
            TaiKhoan = "";
            MatKhau = "";
        }

        public NhanVienDTO(string maNV, string tk, string mk)
        {
            this.MaNhanVien = maNV;
            this.TaiKhoan = tk;
            this.MatKhau = mk;
        }
    }
}
