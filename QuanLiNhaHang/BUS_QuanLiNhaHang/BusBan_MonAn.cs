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
    public class BusBan_MonAn
    {
        Dataprovider banAn = new Dataprovider();

        public DataTable loadBan_MonAn()
        {
            return banAn.loadBanMonAnDTO();
        }
    }
}
