using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_QuanLiNhaHang;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL_QuanLiNhaHang
{
    public class Dataprovider
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức kiểm tra acount
        public bool CheckTK(string tk, string mk)
        {
            string sql = "SELECT COUNT(*) FROM NhanVien WHERE TaiKhoan = @tk AND MatKhau = @mk";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@tk", tk);
                    command.Parameters.AddWithValue("@mk", mk);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return (count > 0);
                }
            }
        }
    }
}
