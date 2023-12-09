using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class ThucDonDTO
    {
        private string maMon;
        private string tenMon;
        private string hinhAnh;
        private float donGia;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
        public float DonGia { get => donGia; set => donGia = value; }

        public ThucDonDTO()
        {
            MaMon = "";
            TenMon = "";
            HinhAnh = "";
            DonGia = 0;
        }

        public ThucDonDTO(string maMon, string tenMon, string hinhAnh, float donGia)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.HinhAnh = hinhAnh;
            this.DonGia = donGia;
        }
    }
}
