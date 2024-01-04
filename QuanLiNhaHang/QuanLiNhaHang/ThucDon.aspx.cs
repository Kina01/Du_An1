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
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LayDuLieuVaoGridView();
            }
        }

        BusThucDon thucDon = new BusThucDon();

        public void LayDuLieuVaoGridView()
        {
            gvThucDon.DataSource =thucDon.loadThucDon();
            gvThucDon.DataBind();
        }
    }
}