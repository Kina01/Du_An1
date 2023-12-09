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
        private string maHoaDon;
        private string maMon;
        private int soLuong;
        private float thanhTien;

        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }

        public ChiTietHoaDonDTO()
        {
            MaNhanVien = "";
            MaHoaDon = "";
            MaMon = "";
            SoLuong = 0;
            ThanhTien = 0;
        }

        public ChiTietHoaDonDTO(string maNV, string maHD, string maMon, int soLuong, float thanhTien)
        {
            this.MaNhanVien = maNV;
            this.MaHoaDon = maHD;
            this.MaMon = maMon;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
    }
}
