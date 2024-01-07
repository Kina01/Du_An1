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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMaban("B2", txtMaBan);
                LayDuLieuVaoGridView();
            }
        }

        BusBan_MonAn busBanMonAn = new BusBan_MonAn();

        private void LoadMaban(string maBan, TextBox txtMaBan)
        {
            BusBan banBUS = new BusBan();
            string idBan = banBUS.getMaBan(maBan);
            txtMaBan.Text = idBan;
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
            Response.Redirect("/Form_ThanhToan/HoaDonThanhToan2.aspx");
        }
    }
}