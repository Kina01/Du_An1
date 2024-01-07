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
    public class BusHoaDon
    {
        DAL_HoaDon thanhToanDAL = new DAL_HoaDon();

        public float tongHoaDon(string maBan)
        {
            return thanhToanDAL.tongHoaDon(maBan);
        }

        public bool saveHoaDon(HoaDonDTO hoaDonDTO)
        {
            return thanhToanDAL.saveHoaDon(hoaDonDTO);
        }
    }
}
