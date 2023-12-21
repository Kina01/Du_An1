using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLiNhaHang;

namespace QuanLiNhaHang
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                LoadTrangThaiBan("B1", txtTrangThai1);
                LoadTrangThaiBan("B2", txtTrangThai2);
                LoadTrangThaiBan("B3", txtTrangThai3);
                LoadTrangThaiBan("B4", txtTrangThai4);
                LoadTrangThaiBan("B5", txtTrangThai5);
                LoadTrangThaiBan("B6", txtTrangThai6);
                LoadTrangThaiBan("B7", txtTrangThai7);
                LoadTrangThaiBan("B8", txtTrangThai8);
                LoadTrangThaiBan("B9", txtTrangThai9);
            }
        }

        private void LoadTrangThaiBan(string maBan, TextBox txtTrangThai)
        {
            // Tạo đối tượng BUS để truy xuất dữ liệu từ CSDL
            BusBan banBUS = new BusBan();

            // Lấy trạng thái của bàn từ CSDL dựa vào mã bàn
            // (Bạn cần thay đổi phương thức GetTrangThaiBan thành phương thức thực tế trong BusBan)
            string trangThaiBan = banBUS.GetTrangThaiBan(maBan);

            // Gán trạng thái vào TextBox tương ứng trên giao diện
            txtTrangThai.Text = trangThaiBan;
        }

    }
}