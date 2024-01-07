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
    public class DAL_KhachHang
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức lưu khách hàng
        public bool saveKhachHang(KhachHangDTO khachHang)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO KhachHang( MaKhachHang, TenKhachHang)
                        VALUES ( @makhachhang, @tenkhachhang)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@makhachhang", khachHang.MaKhachHang);
                cmd.Parameters.AddWithValue("@tenkhachhang", khachHang.TenKhachHang);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        //Phường thức xóa khách hàng khi đặt bàn thất bại
        public bool deleteKH(KhachHangDTO kh)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE KhachHang
                            WHERE MaKhachHang = @makhachhang";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@makhachhang", kh.MaKhachHang);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }

        //Phương thức laod dữ liệu khách hàng vào form
        public DataTable loadKH()
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"SELECT * FROM KhachHang";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

        //Phương thức lấy tên khách hàng lên form 
        public string loadTenKH()
        {
            string ten = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT DISTINCT KH.TenKhachHang
                                FROM KhachHang KH
                                JOIN DatBan DB ON KH.MaKhachHang = DB.MaKhachHang
                                JOIN Ban_MonAn BM ON DB.MaBan = BM.MaBan";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ten = reader["TenKhachHang"].ToString();
                        }
                    }
                }
            }
            return ten;
        }

        //Phương thức lấy mã khách hàng dựa vào tên khách hàng
        public string getMaKhachHang(string tenKhachHang)
        {
            string maKhachHang = "";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT MaKhachHang FROM KhachHang WHERE TenKhachHang = @tenkhachhang";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@tenkhachhang", tenKhachHang);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            maKhachHang = reader["MaKhachHang"].ToString();
                        }
                    }
                }
            }

            return maKhachHang;
        }
    }
}