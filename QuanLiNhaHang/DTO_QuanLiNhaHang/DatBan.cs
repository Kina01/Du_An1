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
        private string maBan;
        private string maKhachHang;

        public string MaDatBan { get => maDatBan; set => maDatBan = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }

        public DatBan()
        {
            MaDatBan = "";
            MaBan = "";
            MaKhachHang = "";
        }

        public DatBan(string maDatBan, string maBan, string maKH)
        {
            this.MaDatBan = maDatBan;
            this.MaBan = maBan;
            this.MaKhachHang = maKH;
        }
    }
}
