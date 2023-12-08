using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class DatBan
    {
        private string maDatBan;
        private string tenKhachHang;
        private string maKhachHang;
        private string trangThai;

        public string MaDatBan { get => maDatBan; set => maDatBan = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }


        public DatBan()
        {
            MaDatBan = "";
            TenKhachHang = "";
            MaKhachHang = "";
            TrangThai = "";
        }


        public DatBan(string maDatBan, string tenKhachHang, string maKhachHang, string trangThai)
        {
            this.MaDatBan = maDatBan;
            this.TenKhachHang = tenKhachHang;
            this.MaKhachHang = maKhachHang;
            this.TrangThai = trangThai;
        }

        
    }
}
