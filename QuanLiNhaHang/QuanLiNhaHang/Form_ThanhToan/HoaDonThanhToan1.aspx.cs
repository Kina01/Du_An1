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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadMaban("B1", lblMaBan);
                loadTenKhachHang();
                layDuLieuVaoGVDeThanhToan();
                tongHoaDon("B1", txtTongHoaDon);
            }

        }

        BusBan busBan = new BusBan();
        BusDatBan busDatBan = new BusDatBan();
        BusBan_MonAn busBan_MonAn = new BusBan_MonAn();
        BusHoaDon busHoaDon = new BusHoaDon();
        BusKhachHang busKhachHang = new BusKhachHang();

        public void LoadMaban(string maBan, Label lblMaBan)
        {
            string idBan = busBan.getMaBan(maBan);
            lblMaBan.Text = idBan;
        }

        public Ban_MonAnDTO layMaBanFormHoaDon()
        {
            Ban_MonAnDTO hoaDon = new Ban_MonAnDTO
            {
                MaBan = lblMaBan.Text
            };
            return hoaDon;
        }

        public void layDuLieuVaoGVDeThanhToan()
        {
            gvThanhToan.DataSource = busBan_MonAn.loadDuLieuDeThanhToan(layMaBanFormHoaDon());
            gvThanhToan.DataBind();
        }

        public void loadTenKhachHang()
        {
            string ten = busKhachHang.loadTenKH();
            lblTenKH.Text = ten;
        }

        public void layTenKhachHang(Label lblTenKH)
        {
            lblTenKH.Text = busKhachHang.loadTenKH();
        }

        public void tongHoaDon(string maBan, TextBox txtTien)
        {
            float tien = busHoaDon.tongHoaDon(maBan);
            txtTien.Text = tien.ToString();
        }

        public HoaDonDTO layDuLieuTuForm()
        {
            HoaDonDTO hoaDon = new HoaDonDTO
            {
                MaKhachHang = lblMaBan.Text,
                ThanhTien = float.Parse(txtTongHoaDon.Text)
            };
            return hoaDon;
        }

        public BanDTO layMaBanTuForm()
        {
            BanDTO banDTO = new BanDTO
            {
                MaBan = lblMaBan.Text
            };
            return banDTO;
        }

        public DatBanDTO layMaBanTuForm1()
        {
            DatBanDTO datBanDTO = new DatBanDTO
            {
                MaBan = lblMaBan.Text
            };
            return datBanDTO;
        }

        public KhachHangDTO layTenKHTuForm()
        {
            KhachHangDTO khachHangDTO = new KhachHangDTO
            {
                TenKhachHang = lblTenKH.Text
            };
            return khachHangDTO;
        }

        public string layMaKH(string tenKhachHang)
        {
            string maKH = busKhachHang.getMaKH(tenKhachHang);
            return maKH;
        }

        public float layTien()
        {
            float tien = float.Parse(txtTongHoaDon.Text);
            return tien;
        }

        protected void btnXacNhan_Click(object sender, EventArgs e)
        {
            HoaDonDTO hoaDonDTO = new HoaDonDTO();
            string maKH = layMaKH(lblTenKH.Text);
            hoaDonDTO.MaKhachHang = maKH;
            hoaDonDTO.ThanhTien = layTien();
            bool result = busHoaDon.saveHoaDon(hoaDonDTO);
            
            if (result)
            {
                bool result1 = busBan.upBan1(layMaBanTuForm());
                bool result2 = busDatBan.deleteDatBan(layMaBanTuForm1());
                bool result3 = busBan_MonAn.xoaBanAn(layMaBanFormHoaDon());
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Thanh toán thành công!');  window.location = '../TrangChu.aspx';", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Thanh toán thất bại!');  window.location = '../TrangChu.aspx';", true);
            }
        }
    }
}