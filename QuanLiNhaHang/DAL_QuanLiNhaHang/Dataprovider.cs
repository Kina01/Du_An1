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

        //Phương thức xóa đặt bàn
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

        // Phương thức này để lưu ThucDonDTO vào cơ sở dữ liệu
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

        //Phương thức lấy trạng thái bàn
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
