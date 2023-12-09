using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace BUS_QuanLiNhaHang
{
    public class BusKhachHang
    {
        Dataprovider khachHangDAL = new Dataprovider();

        public bool SAVEKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAL.saveKhachHang(khachHang);
        }
    }
}
