using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLiNhaHang;
using DTO_QuanLiNhaHang;

namespace QuanLiNhaHang
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMaban("B6", txtMaBan);
                LayDuLieuVaoGridView();
            }
        }

        BusBan_MonAn busBanMonAn = new BusBan_MonAn();

        private void LoadMaban(string maBan, TextBox txtTrangThai)
        {
            // Tạo đối tượng BUS để truy xuất dữ liệu từ CSDL
            BusBan banBUS = new BusBan();

            // Lấy mã bàn của bàn từ CSDL dựa vào mã bàn
            // (Bạn cần thay đổi phương thức GetMaBan thành phương thức thực tế trong BusBan)
            string idBan = banBUS.getMaBan(maBan);

            // Gán mã bàn vào TextBox tương ứng trên giao diện
            txtTrangThai.Text = idBan;
        }

        public Ban_MonAnDTO layMaBanFormBanMonAn()
        {
            Ban_MonAnDTO ban_MonAn = new Ban_MonAnDTO
            {
                MaBan = txtMaBan.Text
            };
            return ban_MonAn;
        }

        public void LayDuLieuVaoGridView()
        {
            gvMon.DataSource = busBanMonAn.loadBan_MonAn(layMaBanFormBanMonAn());
            gvMon.DataBind();
        }

        public Ban_MonAnDTO layDuLieuTuFormBanMonAn()
        {
            Ban_MonAnDTO ban_MonAn = new Ban_MonAnDTO
            {
                MaBan = txtMaBan.Text,
                MaMon = txtMaMon.Text,
                SoLuong = int.Parse(txtSoLuong.Text)
            };
            return ban_MonAn;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            BusBan_MonAn busBanMonAn = new BusBan_MonAn();
            Ban_MonAnDTO ban_MonAn = layDuLieuTuFormBanMonAn();
            bool result = busBanMonAn.saveBanAn(ban_MonAn);
            if (result)
            {
                lblMessage.Text = "Gọi món thành công";
                LayDuLieuVaoGridView();
            }
            else
            {
                lblMessage.Text = "Gọi món thất bại";
            }
        }

        public Ban_MonAnDTO layDuLieuMonTuFormBanMonAn()
        {
            Ban_MonAnDTO ban_MonAn = new Ban_MonAnDTO
            {
                MaMon = txtMaMon.Text,
                SoLuong = int.Parse(txtSoLuong.Text)
            };
            return ban_MonAn;
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Ban_MonAnDTO banAn = layDuLieuMonTuFormBanMonAn();
            busBanMonAn = new BusBan_MonAn();
            bool result = busBanMonAn.deleteMonAn(banAn);

            if (result)
            {
                LayDuLieuVaoGridView();
                lblMessage.Text = "Xóa món thành công";
                LayDuLieuVaoGridView();
            }
            else
            {
                lblMessage.Text = "Xóa không thành công vui lòng thử lại";
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = "";
            txtSoLuong.Text = "";
            lblMessage.Text = "";
        }

        protected void btnThanhToan_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Form_ThanhToan/HoaDonThanhToan6.aspx");
        }
    }
}