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

        //Phương thức thực hiện truy vấn dữ liệu từ bang 'ThucDon' và trả về dữ liệu đó dưới dạng một đối tượng DataTable
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

        //Phương thức lấy tên món ăn lên form
        public DataTable loadBanMonAnDTO()
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"SELECT Ban_MonAn.MaMon, ThucDon.TenMon
                                JOIN ThucDon 
                                ON Ban_MonAn.MaMon = ThucDon.MaMon";
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
            }
            return data;
        }

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

        //Phương thức cập nhật lại trạng thái bàn trong cơ sở dữ liệu sau khi dặt bàn thành công
        public bool updateBan(BanDTO ban)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE BAN SET TrangThai = @trangthai
                            WHERE MaBan = @maban and SoLuongNguoi >= @soluongnguoi and TrangThai = N'Chưa đặt'";
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

        //Phương thức load bảng bàn
        public List<BanDTO> loadDanhSachBan()
        {
            List<BanDTO> danhSachBan = new List<BanDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Ban";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    BanDTO ban = new BanDTO
                    {
                        MaBan = reader["MaBan"].ToString(),
                        SoLuongNguoi = Convert.ToInt32(reader["SoLuongNguoi"]),
                        TrangThai = reader["TrangThai"].ToString()
                    };

                    danhSachBan.Add(ban);
                }
            }

            return danhSachBan;
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

        //Phường thức xóa đặt bàn khi đặt bàn thất bại
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
    }
}
