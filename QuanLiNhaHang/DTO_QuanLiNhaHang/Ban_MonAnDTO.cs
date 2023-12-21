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

        protected int Id { get => id; set => id = value; }
        protected string MaBan { get => maBan; set => maBan = value; }
        protected string MaMon { get => maMon; set => maMon = value; }

        public Ban_MonAnDTO()
        {
            Id = 0;
            MaBan = "";
            MaMon = "";
        }

        public Ban_MonAnDTO(int id, string maBan, string maMon)
        {
            this.Id = id;
            this.MaMon = maMon;
            this.MaBan = MaBan;
        }
    }
}
