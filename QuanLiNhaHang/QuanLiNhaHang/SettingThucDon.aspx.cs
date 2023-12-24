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
            txtMonAn.Text = "";
            txtGia.Text = "";
        }

        protected void btnThemmon_Click(object sender, EventArgs e)
        {

            // Tạo thể hiện của lớp BusThucDon
            BusThucDon busThucDon = new BusThucDon();
            // Tạo đối tượng ThucDonDTO và điền dữ liệu từ giao diện người dùng
            ThucDonDTO thucDon = new ThucDonDTO
            {
                MaMon = txtMaMon.Text,
                TenMon = txtMonAn.Text,
                HinhAnh = "", // Bạn cần xử lý riêng phần tải ảnh lên
                DonGia = float.Parse(txtGia.Text)
            };

            if (fupMonAn.HasFile)
            {
                // Lấy đường dẫn tuyệt đối đến thư mục lưu trữ hình ảnh
                string uploadFolder = Server.MapPath("~/Images/");

                // Lấy tên file của hình ảnh
                string fileName = Path.GetFileName(fupMonAn.FileName);

                // Kết hợp đường dẫn thư mục và tên file để tạo đường dẫn đầy đủ
                string filePath = Path.Combine(uploadFolder, fileName);

                // Lưu trữ hình ảnh vào thư mục
                fupMonAn.SaveAs(filePath);

                // Lưu đường dẫn hình ảnh vào đối tượng ThucDonDTO
                thucDon.HinhAnh = fileName;
            }
            else
            {
                // Xử lý khi không có tệp tin được chọn
                thucDon.HinhAnh = "~/Images/default.jpg";
            }
            // Gọi phương thức LuuThucDon từ thể hiện của lớp BusThucDon để lưu vào cơ sở dữ liệu
            bool result = busThucDon.LuuThucDon(thucDon);

            // Kiểm tra kết quả và hiển thị thông báo (bạn có thể điều chỉnh theo yêu cầu cụ thể của mình)
            if (result)
            {
                // Lưu dữ liệu thành công
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Dữ liệu đã được lưu thành công.');", true);
                Response.Redirect("ThucDon.aspx");
            }
            else
            {
                // Lỗi khi lưu dữ liệu
                ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "alert('Có lỗi xảy ra khi lưu dữ liệu.');", true);
            }
        }
    }
}