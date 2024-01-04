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
        Dataprovider banDAL = new Dataprovider();

        //Phường thức update lại trạng thái bàn trong csdl
        public bool upBan(BanDTO ban)
        {
            return banDAL.updateBan(ban);
        }

        // Phương thức lấy danh sách tất cả các bàn
        public List<BanDTO> loadDanhSachBan()
        {
            return banDAL.loadDanhSachBan();
        }

        // Phương thức lấy trạng thái của một bàn dựa trên mã bàn
        public string GetTrangThaiBan(string maBan)
        {
            return banDAL.GetTrangThaiBan(maBan);
        }

        public string getMaBan(string maBan)
        {
            return banDAL.getMaBan(maBan);
        }
    }
}
