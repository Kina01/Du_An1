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
    public partial class WebForm4 : System.Web.UI.Page

        
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public DatBanDTO LayDuLieuTuFormDatBan()
        {
            DatBanDTO datBan = new DatBanDTO
            {
                MaDatBan = txtMaDatBan.Text,
                MaBan = cbxMaban.Text,
                MaKhachHang = txtMaKhachHang.Text,
                TenKhachHang = txtTenKhachHang.Text,
                SoLuongNguoi = int.Parse(txtSoLuong.Text),
                TrangThai = cbxTrangThai.Text
            };
            return datBan;
        }


        public BanDTO LayDuLieuTuFormBan()
        {
            BanDTO ban = new BanDTO
            {
                MaBan = cbxMaban.Text,
                SoLuongNguoi = int.Parse(txtSoLuong.Text),
                TrangThai = cbxTrangThai.Text
            };

            return ban;
        }

        public KhachHangDTO LayDuLieuTuFormKhachHang()
        {
            KhachHangDTO khachhang = new KhachHangDTO
            {
                MaKhachHang = txtMaKhachHang.Text,
                TenKhachHang = txtTenKhachHang.Text
            };
            return khachhang;
        }

        protected void btnDatBan_Click(object sender, EventArgs e)
        {
            DatBanDTO datbanDTO = LayDuLieuTuFormDatBan();
            BanDTO banDTO = LayDuLieuTuFormBan();
            KhachHangDTO khachhangDTO = LayDuLieuTuFormKhachHang();
            busDatBan datbanBUS = new busDatBan();
            BusBan banBUS = new BusBan();
            BusKhachHang khachhangBUS = new BusKhachHang();

            bool result = khachhangBUS.SAVEKhachHang(khachhangDTO);
            if (result)
            {
                bool result1 = banBUS.upBan(banDTO);
                if (result1)
                {
                    bool result2 = datbanBUS.SAVEDatBan(datbanDTO);
                    if (result2)
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đặt bàn thành công!');  window.location = 'TrangChu.aspx';", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Lỗi đặt bàn');", true);
                    }
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Bàn đã có người!');", true);
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Lỗi đặt bàn!');", true);
            }
        }
    }
}