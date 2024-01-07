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
    public class DAL_HoaDon
    {
        string connectionString = ConfigurationManager.ConnectionStrings["QLNH"].ConnectionString;

        public float tongHoaDon(string maBan)
        {
            float tong = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT SUM(ThucDon.DonGia * Ban_MonAn.SoLuong) AS TongHoaDon
                                FROM Ban_MonAn JOIN ThucDon
                                ON Ban_MonAn.MaMon = ThucDon.MaMon
                                WHERE MaBan = @maban";
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@MaBan", maBan);
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            tong = float.Parse(reader["TongHoaDon"].ToString());
                        }
                    }
                }
            }
            return tong;
        }

        public bool saveHoaDon(HoaDonDTO hoaDonDTO)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO HoaDon (MaKhachHang, ThanhTien)
                                   VALUES ( @makhachhang, @thanhtien)";
                SqlCommand cmd = new SqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("@makhachhang", hoaDonDTO.MaKhachHang);
                cmd.Parameters.AddWithValue("@thanhtien", hoaDonDTO.ThanhTien);
                connection.Open();
                int result = cmd.ExecuteNonQuery();
                return (result >= 1);
            }
        }
    }
}
