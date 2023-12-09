<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DatBan.aspx.cs" Inherits="QuanLiNhaHang.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/DatBan.css" />
   <div class="datban">
        <asp:Image ID="img" runat="server" ImageUrl="/Image/Backgroud.png" CssClass="imgBackgroud" />
        <div class="container">
            <div class="khoangcach">
                <label for="txtMaDatBan" class="tieude">Mã đặt bàn</label>
                <asp:TextBox ID="txtMaDatBan" runat="server"></asp:TextBox>
            </div>
            <div class="khoangcach">
                <label for="cbxMaBan" class="tieude">Mã bàn</label>
                <asp:DropDownList ID="cbxMaban" runat="server">
                    <asp:ListItem>B1</asp:ListItem>
                    <asp:ListItem>B2</asp:ListItem>
                    <asp:ListItem>B3</asp:ListItem>
                    <asp:ListItem>B4</asp:ListItem>
                    <asp:ListItem>B5</asp:ListItem>
                    <asp:ListItem>B6</asp:ListItem>
                    <asp:ListItem>B7</asp:ListItem>
                    <asp:ListItem>B8</asp:ListItem>
                    <asp:ListItem>B9</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="khoangcach">
                <label for="txtMaKhachHang" class="tieude">Mã khách hàng</label>
                <asp:TextBox ID="txtMaKhachHang" runat="server"></asp:TextBox>
            </div>
            <div class="khoangcach">
                <label for="txtTenKhachHang" class="tieude">Tên khách hàng</label>
                <asp:TextBox ID="txtTenKhachHang" runat="server"></asp:TextBox>
            </div>
            <div class="khoangcach">
                <label for="txtSoLuong" class="tieude">Số lượng người</label>
                <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
            </div>
            <div class="khoangcach">
                <label for="cbxTrangThai" class="tieude">Trạng thái</label>
                <asp:DropDownList ID="cbxTrangThai" runat="server">
                    <asp:ListItem>Chưa đặt</asp:ListItem>
                    <asp:ListItem>Đã đặt</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="khoangcach" id="button">
                <asp:Button ID="btnDatBan" runat="server" Text="Đặt bàn" OnClick="btnDatBan_Click" />
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
