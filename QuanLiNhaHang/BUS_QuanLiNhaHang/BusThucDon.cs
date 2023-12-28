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
    public class BusThucDon
    {
        Dataprovider td = new Dataprovider();

        public DataTable loadThucDon()
        {
            return td.loadThucDon();
        }
        public bool LuuThucDon(ThucDonDTO thucDon)
        {
            return td.LuuThucDon(thucDon);
        }
        public bool XoaThucDon(string maMon)
        {
            return td.XoaThucDon(maMon);
        }
    }
}
