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
    public class DAL_Ban
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức cập nhật lại trạng thái bàn trong cơ sở dữ liệu
        public bool updateBan(BanDTO ban)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE BAN SET TrangThai = @trangthai
                            WHERE MaBan = @maban and SoLuongNguoi >= @soluongnguoi and TrangThai = N'Trống'";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@maban", ban.MaBan);
                cmd.Parameters.AddWithValue("@soluongnguoi", ban.SoLuongNguoi);
                cmd.Parameters.AddWithValue("@trangthai", ban.TrangThai);
                connection.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }

        //Phương thức lấy trạng thái bàn
        public string GetTrangThaiBan(string maBan)
        {
            string trangThaiBan = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TrangThai FROM Ban WHERE MaBan = @MaBan";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaBan", maBan);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            trangThaiBan = reader["TrangThai"].ToString();
                        }
                    }
                }
            }

            return trangThaiBan;
        }

        //Phương thức lấy mã bàn
        public string getMaBan(string maBan)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaBan FROM Ban WHERE MaBan = @MaBan";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@MaBan", maBan);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maBan = reader["MaBan"].ToString();
                        }
                    }
                }
            }

            return maBan;
        }

        public bool updateBan1(BanDTO ban)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE BAN SET TrangThai = N'Trống'
                            WHERE MaBan = @maban";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@maban", ban.MaBan);
                connection.Open();
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
