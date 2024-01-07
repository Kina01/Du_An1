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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDuLieuVaoGV();
            }
        }

        BusKhachHang kh = new BusKhachHang();

        public void loadDuLieuVaoGV()
        {
            gvKH.DataSource = kh.loadKH();
            gvKH.DataBind();
        }
    }
}