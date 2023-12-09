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

        public bool upBan(BanDTO ban)
        {
            return banDAL.updateBan(ban);
        }

        public BanDTO loadBan()
        {
            return banDAL.loadBan();
        }

    }
}
