<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SettingThucDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/SettingThucDon.css" />
    <div class="SettingMenu">
        <div class="SettingMenu-1">
            <div>
                 <h2 style="margin-top:8px;">QUẢN LÝ THỰC ĐƠN</h2>
             </div>
            <table>
                <tr>
                    <td style="text-align:left">
                        Tên món ăn
                    </td>
                    <td>
                        <asp:TextBox ID="txtMonAn" runat="server" Width="232px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:left">
                        Mã món
                    </td>
                    <td>
                        <asp:TextBox ID="txtMaMon" runat="server" Width="232px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align:left">
                        Hình ảnh
                    </td>
                    <td style="margin:initial">
                        <asp:FileUpload ID="fupMonAn" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td style="text-align:left">
                        Đơn giá
                    </td>
                    <td>
                        <asp:TextBox ID="txtGia" runat="server" Width="232px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <div class="">
                <table>
                    <tr>
                        <td class="auto-style2">
                            <asp:Button ID="btnThemmon" runat="server" Text="Thêm món" Width="84px" OnClick="btnThemmon_Click"/>
                        </td>
                        <td class="auto-style3">
                            <asp:Button ID="btnUpdate" runat="server" Text="Cập nhật"/>
                        </td>
                        <td class="auto-style4">
                            <asp:Button ID="btnDelete" runat="server" Text="Xóa"/>
                        </td>
                        <td class="auto-style5">
                            <asp:Button ID="btnClear" runat="server" Text="Làm mới" Width="80px" OnClick="btnClear_Click" />
                        </td>
                    </tr>
                </table>
        </div>
        </div>
        
    </div>
</asp:Content>
