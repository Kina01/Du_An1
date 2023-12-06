using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class KhachHang
    {
        private string maKhachHang;
        private string tenKhachHang;
        private string soDienThoai;
        private string diaChi;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public KhachHang()
        {
            MaKhachHang = "";
            TenKhachHang = "";
            SoDienThoai = "";
            DiaChi = "";
        }

        public KhachHang(string maKH, string hoTen, string sdt, string dc)
        {
            this.MaKhachHang = maKH;
            this.TenKhachHang = hoTen;
            this.SoDienThoai = sdt;
            this.DiaChi = dc;
        }
    }
}
