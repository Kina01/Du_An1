using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class Ban
    {
        private string maBan;
        private int soLuongNguoi;
        private bool trangThai;

        public string MaBan { get => maBan; set => maBan = value; }
        public int SoLuongNguoi { get => soLuongNguoi; set => soLuongNguoi = value; }
        public bool TrangThai { get => trangThai; set => trangThai = value; }

        public Ban()
        {
            MaBan = "";
            SoLuongNguoi = 0;
            TrangThai = false;
        }

        public Ban(string maBan, int soNguoi, bool trangThai)
        {
            this.MaBan = maBan;
            this.SoLuongNguoi = soNguoi;
            this.TrangThai = trangThai;
        }
    }
}
