using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class HoaDonDTO
    {
        private string maHoaDon;
        private string maKhachHang;
        private float thanhTien;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        
        public HoaDonDTO()
        {
            MaHoaDon = "";
            MaKhachHang = "";
            ThanhTien = 0;
        }

        public HoaDonDTO(string maHD, string maKhachHang, float thanhTien)
        {
            this.MaHoaDon = maHD;
            this.MaKhachHang = maKhachHang;
            this.ThanhTien = thanhTien;
        }
    }
}
