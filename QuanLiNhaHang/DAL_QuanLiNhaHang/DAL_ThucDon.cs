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
    public class DAL_ThucDon
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức load dữ liệu thực đơn lên form
        public DataTable loadThucDon()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM ThucDon";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

        // Phương thức này để lưu ThucDonDTO vào database
        public bool LuuThucDon(ThucDonDTO thucDon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO ThucDon(MaMon, TenMon, HinhAnh, DonGia)
                               VALUES (@maMon, @tenMon, @hinhAnh, @donGia)";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@maMon", thucDon.MaMon);
                    cmd.Parameters.AddWithValue("@tenMon", thucDon.TenMon);
                    cmd.Parameters.AddWithValue("@hinhAnh", thucDon.HinhAnh);
                    cmd.Parameters.AddWithValue("@donGia", thucDon.DonGia);

                    connection.Open();
                    int result = cmd.ExecuteNonQuery();

                    return (result >= 1);
                }
            }
        }

        //Phương thức xóa thực đơn trong database
        public bool XoaThucDon(string maMon)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM ThucDon WHERE MaMon = @maMon";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@maMon", maMon);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    return (result > 0);
                }
            }
        }
    }
}
