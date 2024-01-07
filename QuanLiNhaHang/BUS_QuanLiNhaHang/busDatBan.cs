using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace BUS_QuanLiNhaHang
{
    public class BusDatBan
    {
        DAL_DatBan datBanDAL = new DAL_DatBan();

        public bool SAVEDatBan(DatBanDTO datBanDTO)
        {
            return datBanDAL.saveDatBan(datBanDTO);
        }

        public bool DeleteDatBan(DatBanDTO datBanDTO)
        {
            return datBanDAL.deleteDatBan(datBanDTO);
        }

        public bool deleteDatBan(DatBanDTO datBanDTO)
        {
            return datBanDAL.xoaDatBan(datBanDTO);
        }
    }
}
