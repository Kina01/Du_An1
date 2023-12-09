using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class KhachHangDTO
    {
        private string maKhachHang;
        private string tenKhachHang;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }

        public KhachHangDTO()
        {
            MaKhachHang = "";
            TenKhachHang = "";
        }

        public KhachHangDTO(string maKH, string hoTen)
        {
            this.MaKhachHang = maKH;
            this.TenKhachHang = hoTen;
        }
    }
}
