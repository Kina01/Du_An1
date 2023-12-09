using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class DatBanDTO
    {
        private string maDatBan;
        private string maBan;
        private string maKhachHang;
        private string tenKhachHang;
        private int soLuongNguoi;
        private string trangThai;

        public string MaDatBan { get => maDatBan; set => maDatBan = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public int SoLuongNguoi { get => soLuongNguoi; set => soLuongNguoi = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }

        public DatBanDTO()
        {
            MaDatBan = "";
            MaBan = "";
            MaKhachHang = "";
            TenKhachHang = "";
            SoLuongNguoi = 0;
            TrangThai = "";
        }


        public DatBanDTO(string maDatBan, string maBan, string maKhachHang, string tenKhachHang, int soLuongNguoi, string trangThai)
        {
            this.MaDatBan = maDatBan;
            this.MaBan = maBan;
            this.MaKhachHang = maKhachHang;
            this.TenKhachHang = tenKhachHang;
            this.SoLuongNguoi = soLuongNguoi;
            this.TrangThai = trangThai;
        }
    }
}
