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

        public DataTable loadBan_MonAn(Ban_MonAnDTO banMonAn)
        {
            return banAn.loadBanMonAnDTO(banMonAn.MaBan);
        }

        public bool saveBanAn(Ban_MonAnDTO banMonAn)
        {
            return banAn.saveBanMonAn(banMonAn);
        }

        public bool deleteMonAn(Ban_MonAnDTO banMonAn)
        {
            return banAn.xoaMonAn(banMonAn);
        }
    }
}
