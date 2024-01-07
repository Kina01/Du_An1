using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class ChiTietHoaDonDTO
    {
        private string maNhanVien;
        private int maHoaDon;
        private string maKhachHang;
        private float thanhTien;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public int MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }

        public ChiTietHoaDonDTO()
        {
            MaNhanVien = "";
            MaHoaDon = 0;
            MaKhachHang = "";
            ThanhTien = 0;
        }

        public ChiTietHoaDonDTO(string maNV, int maHD, string maKH, float thanhTien)
        {
            this.MaNhanVien = maNV;
            this.MaHoaDon = maHD;
            this.MaKhachHang = maKH;
            this.ThanhTien = thanhTien;
        }
    }
}
