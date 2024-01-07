using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace BUS_QuanLiNhaHang
{
    public class BusBan
    {
        DAL_Ban banDAL = new DAL_Ban();

        //Phường thức update lại trạng thái bàn thành đã có khách trong csdl
        public bool upBan(BanDTO ban)
        {
            return banDAL.updateBan(ban);
        }

        // Phương thức lấy danh sách tất cả các bàn
        //public List<BanDTO> loadDanhSachBan()
        //{
        //    return banDAL.loadDanhSachBan();
        //}

        // Phương thức lấy trạng thái của một bàn dựa trên mã bàn
        public string GetTrangThaiBan(string maBan)
        {
            return banDAL.GetTrangThaiBan(maBan);
        }

        // Phương thức lấy mã bàn
        public string getMaBan(string maBan)
        {
            return banDAL.getMaBan(maBan);
        }

        //Phường thức update lại trạng thái bàn thành trống trong csdl
        public bool upBan1(BanDTO ban)
        {
            return banDAL.updateBan1(ban);
        }
    }
}
