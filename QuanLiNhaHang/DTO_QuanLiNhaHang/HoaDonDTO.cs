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
        private string maDatBan;
        private string maMon;
        private string tenMon;
        private int soLuong;
        private float thanhTien;

        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        public string MaDatBan { get => maDatBan; set => maDatBan = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }

        public HoaDonDTO()
        {
            MaHoaDon = "";
            MaDatBan = "";
            MaMon = "";
            tenMon = "";
            SoLuong = 0;
            ThanhTien = 0;
        }

        public HoaDonDTO(string maHD, string maDatBan, string maMon, string tenMon, int soLuong, float thanhTien)
        {
            this.MaHoaDon = maHD;
            this.MaDatBan = maDatBan;
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.SoLuong = soLuong;
            this.ThanhTien = thanhTien;
        }
    }
}
