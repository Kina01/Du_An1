using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class ThucDon
    {
        private string maMon;
        private string tenMon;
        private float donGia;

        public string MaMon { get => maMon; set => maMon = value; }
        public string TenMon { get => tenMon; set => tenMon = value; }
        public float DonGia { get => donGia; set => donGia = value; }

        public ThucDon()
        {
            MaMon = "";
            TenMon = "";
            DonGia = 0;
        }

        public ThucDon(string maMon, string tenMon, float donGia)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
            this.DonGia = donGia;
        }
    }
}
