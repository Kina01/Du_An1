using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace BUS_QuanLiNhaHang
{
    public class busDatBan
    {
        Dataprovider datBanDAL = new Dataprovider();

        public bool SAVEDatBan(DatBanDTO datBan)
        {
            return datBanDAL.saveDatBan(datBan);
        }
    }
}
