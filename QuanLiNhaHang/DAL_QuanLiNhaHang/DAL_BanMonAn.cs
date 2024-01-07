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
    public class DAL_BanMonAn
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức lưu món khi khách gọi
        public bool saveBanMonAn(Ban_MonAnDTO banMonAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO Ban_MonAn (MaBan, MaMon, SoLuong)
                                VALUES (@maban, (SELECT MaMon FROM ThucDon WHERE MaMon = @mamon), @soluong)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@maban", banMonAn.MaBan);
                cmd.Parameters.AddWithValue("@mamon", banMonAn.MaMon);
                cmd.Parameters.AddWithValue("@soluong", banMonAn.SoLuong);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        //Phương thức lấy tên món ăn lên form
        public DataTable loadBanMonAnDTO(string maBan)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"SELECT Ban_MonAn.MaMon, ThucDon.TenMon, Ban_MonAn.SoLuong FROM Ban_MonAn
                                JOIN ThucDon 
                                ON Ban_MonAn.MaMon = ThucDon.MaMon
                                WHERE MaBan = @maban";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@maban", maBan);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

        //Phương thức xóa món ăn bàn đặt
        public bool xoaMonAn(Ban_MonAnDTO banAn)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Ban_MonAn WHERE MaMon = @maMon AND SoLuong = @soluong";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@maMon", banAn.MaMon);
                    cmd.Parameters.AddWithValue("@soluong", banAn.SoLuong);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return (result > 0);
                }
            }
        }

        public DataTable loadDuLieuDeThanhToan(string maBan)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"SELECT ThucDon.TenMon, Ban_MonAn.SoLuong, SUM(ThucDon.DonGia * Ban_MonAn.SoLuong) AS Gia
                                FROM Ban_MonAn JOIN ThucDon
                                ON Ban_MonAn.MaMon = ThucDon.MaMon
                                WHERE MaBan = @maban
                                GROUP BY ThucDon.TenMon, Ban_MonAn.SoLuong";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@maban", maBan);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

        //Phương thức làm mới bàn ăn đã thanh toán
        public bool xoaBanAn(Ban_MonAnDTO ban_MonAnDTO)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM Ban_MonAn WHERE Maban = @maban";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@maban", ban_MonAnDTO.MaBan);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return (result > 0);
                }
            }
        }
    }
}
