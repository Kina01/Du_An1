using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLiNhaHang;

namespace QuanLiNhaHang
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        BusDangNhap DN = new BusDangNhap();

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtUserName.Text;
            string mk = txtPassword.Text;

            if (!string.IsNullOrEmpty(tk) && ! string.IsNullOrEmpty(mk))
            {
                if (DN.CheckAccount(tk, mk))
                {
                    Response.Redirect("TrangChu.aspx");
                }
                else
                {
                    txtbingBug.Text = "Tài khoản hoặc mật khẩu không đúng";
                }
            }
            else
            {
                txtbingBug.Text = "Vui lòng điền đầy đủ thông tin";
            }

        }
    }
}