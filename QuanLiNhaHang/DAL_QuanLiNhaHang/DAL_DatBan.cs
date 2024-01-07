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
    public class DAL_DatBan
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        //Phương thức Lưu đặt bàn
        public bool saveDatBan(DatBanDTO db)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO DatBan( MaDatBan, MaBan, MaKhachHang, TenKhachHang, SoLuongNguoi, TrangThai)
                        VALUES ( @madatban, @maban, @makhachhang, @tenkhachhang, @soluongnguoi, @trangthai)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@madatban", db.MaDatBan);
                cmd.Parameters.AddWithValue("@maban", db.MaBan);
                cmd.Parameters.AddWithValue("@makhachhang", db.MaKhachHang);
                cmd.Parameters.AddWithValue("@tenkhachhang", db.TenKhachHang);
                cmd.Parameters.AddWithValue("@soluongnguoi", db.SoLuongNguoi);
                cmd.Parameters.AddWithValue("@trangthai", db.TrangThai);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }

        //Phương thức xóa đặt bàn khi đặt bàn thất bại
        public bool deleteDatBan(DatBanDTO db)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE DatBan
                            WHERE MaDatBan = @madatban";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@madatban", db.MaDatBan);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    return true;
                }
            }
            return false;
        }

        //Phương thức xóa đặt bàn sau khi thanh toán
        public bool xoaDatBan(DatBanDTO datBanDTO)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "DELETE FROM DatBan WHERE Maban = @maban";

                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@maban", datBanDTO.MaBan);
                    connection.Open();
                    int result = cmd.ExecuteNonQuery();
                    return (result > 0);
                }
            }
        }
    }
}