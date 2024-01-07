<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HoaDonThanhToan7.aspx.cs" Inherits="QuanLiNhaHang.WebForm22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="../CSS/HoaDonThanhToan.css" />
    <div class="HoaDonThanhToan">
        <div class="HoaDonThanhToan-1">
            <div class="maban">
                <asp:Label ID="lblMaBan" runat="server" Text="Label"></asp:Label>                 
            </div>
            <div class="maban">
                <asp:Label ID="lblTenKH" runat="server" Text="Label"></asp:Label>                 
            </div>
            <div class="thongtin">
                <asp:GridView ID="gvThanhToan" runat="server" AutoGenerateColumns="False" Width="350px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
                    <Columns>
                        <asp:BoundField DataField="TenMon" HeaderText="Tên món" />
                        <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" ItemStyle-CssClass="Column" />
                        <asp:BoundField DataField="Gia" HeaderText="Giá" ItemStyle-CssClass="Column" />
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" />
                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
                    <RowStyle ForeColor="#000066" />
                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F1F1F1" />
                    <SortedAscendingHeaderStyle BackColor="#007DBB" />
                    <SortedDescendingCellStyle BackColor="#CAC9C9" />
                    <SortedDescendingHeaderStyle BackColor="#00547E" />
                </asp:GridView>
            </div>
            <div class="submit">
                <asp:Label ID="lblTongHoaDon" CssClass="tieude" runat="server" Text="Tổng hóa đơn:"></asp:Label>
                <asp:TextBox ID="txtTongHoaDon" CssClass="tien" runat="server"></asp:TextBox>
            </div>
            <div class="submit">
                <asp:Button ID="btnXacNhan" CssClass="button" runat="server" Text="Xác nhận thanh toán" OnClick="btnXacNhan_Click" />
            </div>
        </div>
    </div>
</asp:Content>
