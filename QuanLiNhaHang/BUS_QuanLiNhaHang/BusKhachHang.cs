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
    public class BusKhachHang
    {
        DAL_KhachHang khachHangDAL = new DAL_KhachHang();

        public bool SAVEKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAL.saveKhachHang(khachHang);
        }

        public bool DeleteKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAL.deleteKH(khachHang);
        }

        public DataTable loadKH()
        {
            return khachHangDAL.loadKH();
        }

        public string loadTenKH()
        {
            return khachHangDAL.loadTenKH();
        }

        public string getMaKH(string tenKhachHang)
        {
            return khachHangDAL.getMaKhachHang(tenKhachHang);
        }
    }
}
