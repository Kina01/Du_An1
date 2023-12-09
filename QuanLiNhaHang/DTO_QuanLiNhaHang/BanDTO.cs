using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class BanDTO
    {
        private string maBan;
        private int soLuongNguoi;
        private string trangThai;

        public BanDTO()
        {
            MaBan = "";
            SoLuongNguoi = 0;
            TrangThai = "";
        }

        public BanDTO(string maBan, int soLuongNguoi, string trangThai)
        {
            this.MaBan = maBan;
            this.SoLuongNguoi = soLuongNguoi;
            this.TrangThai = trangThai;
        }

        public string MaBan { get => maBan; set => maBan = value; }
        public int SoLuongNguoi { get => soLuongNguoi; set => soLuongNguoi = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
