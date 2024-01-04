using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_QuanLiNhaHang
{
    public class Ban_MonAnDTO
    {
        private int id;
        private string maBan;
        private string maMon;
        private int soLuong;

        public int Id { get => id; set => id = value; }
        public string MaBan { get => maBan; set => maBan = value; }
        public string MaMon { get => maMon; set => maMon = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public Ban_MonAnDTO()
        {
            MaBan = "";
            MaMon = "";
            SoLuong = 0;
        }

        public Ban_MonAnDTO(string maBan, string maMon, int soLuong)
        {
            this.MaMon = maMon;
            this.MaBan = maBan;
            this.SoLuong = soLuong;
        }
    }
}
