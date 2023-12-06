using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace BUS_QuanLiNhaHang
{
    public class sa
    {
        Dataprovider dp = new Dataprovider();

        //Phương thức check Account
        public bool CheckAccount(string tk, string mk)
        {
            return dp.CheckTK(tk, mk);
        }
    }
}
