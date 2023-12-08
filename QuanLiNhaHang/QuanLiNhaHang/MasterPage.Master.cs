using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiNhaHang
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //// Kiểm tra xem có người dùng đã đăng nhập hay không
            //if (Session["UserName"] != null)
            //{
            //    // Nếu đã đăng nhập, thay đổi trạng thái và hiển thị tên người dùng
            //    IsUserLoggedIn = true;
            //    UserName = Session["UserName"].ToString();
            //}
            // Kiểm tra xem có người dùng đã đăng nhập hay không
            if (Session["UserName"] != null)
            {
                // Nếu đã đăng nhập, thay đổi trạng thái và hiển thị tên người dùng
                IsUserLoggedIn = true;
                UserName = Session["UserName"].ToString();
            }
        }

        //public string UserName
        //{
        //    get { return txtUser.Text; }
        //    set { txtUser.Text = value; }
        //}

        //public bool IsUserLoggedIn
        //{
        //    set
        //    {
        //        if (value)
        //        {
        //            btnLogout.InnerText = "Đăng xuất";
        //        }
        //        else
        //        {
        //            btnLogout.InnerText = "Đăng nhập";
        //        }
        //    }
        //}
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Xóa Session và đăng xuất người dùng
            Session.Clear();
            Session.Abandon();

            // Chuyển hướng đến trang đăng nhập
            Response.Redirect("DangNhap.aspx");
        }

        public string UserName
        {
            get { return txtUser.Text; }
            set { txtUser.Text = value; }
        }

        public bool IsUserLoggedIn
        {
            set
            {
                if (value)
                {
                    btnLogout.InnerText = "Đăng xuất";
                }
                else
                {
                    btnLogout.InnerText = "Đăng nhập";
                }
            }
        }



    }
}