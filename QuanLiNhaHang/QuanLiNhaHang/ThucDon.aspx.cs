﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLiNhaHang;

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

        //BUS_QuanLiNhaHang.BusThucDon thucDon = new BUS_QuanLiNhaHang.BusThucDon();

        public void LayDuLieuVaoGridView()
        {
            //gvThucDon.DataSource = BUSThucDon.loadThucDon();
            //gvThucDon.DataBind();
        }
    }
}