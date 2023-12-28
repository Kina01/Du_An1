using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS_QuanLiNhaHang;
using DTO_QuanLiNhaHang;
using System.IO;

namespace QuanLiNhaHang
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtMaMon.Text = "";
            txtMonAn.Text = "";
            txtGia.Text = "";
        }

        protected void btnThemmon_Click(object sender, EventArgs e)
        {
            BusThucDon busThucDon = new BusThucDon();
            ThucDonDTO thucDon = new ThucDonDTO
            {
                MaMon = txtMaMon.Text,
                TenMon = txtMonAn.Text,
                HinhAnh = "",
                DonGia = float.Parse(txtGia.Text)
            };

            if (fupMonAn.HasFile)
            {
                string uploadFolder = Server.MapPath("~/Images/");

                string fileName = Path.GetFileName(fupMonAn.FileName);

                string filePath = Path.Combine(uploadFolder, fileName);

                fupMonAn.SaveAs(filePath);

                thucDon.HinhAnh = fileName;
            }
            else
            {
                thucDon.HinhAnh = "~/Images/default.jpg";
            }
            bool result = busThucDon.LuuThucDon(thucDon);
            if (result)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Dữ liệu đã được lưu thành công.');", true);
                Response.Redirect("ThucDon.aspx");
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Có lỗi xảy ra khi lưu dữ liệu.');", true);
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Vui lòng nhập mã món trước khi xóa.');", true);
                return;
            }
            string maMon = txtMaMon.Text;
            BusThucDon busThucDon = new BusThucDon();
            bool result = busThucDon.XoaThucDon(maMon);
            if (result)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Đã xóa món ăn thành công.');setTimeout(function(){ window.location.href = 'ThucDon.aspx'; }, 300);", true);
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Có lỗi xảy ra khi xóa món ăn.');", true);
            }
        }
    }
}