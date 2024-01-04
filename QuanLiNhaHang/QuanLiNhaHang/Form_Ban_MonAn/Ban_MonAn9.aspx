<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Ban_MonAn9.aspx.cs" Inherits="QuanLiNhaHang.WebForm16" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Ban_MonAn.css" />
    <div class="BanMonAn">
        <div class="BanMonAn-1">
            <div class="row">
                <label class="title" for="txtMaBan" runat="server">Mã bàn</label>
                <asp:TextBox ID="txtMaBan" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <label class="title" for="txtMaMon" runat="server">Mã món</label>
                <asp:TextBox ID="txtMaMon" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <label class="title" for="txtSoLuong" runat="server">Số lượng</label>
                <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
            </div>
            <div class="row">
                <asp:Button ID="btnAdd" runat="server" Text="Thêm món" OnClick="btnAdd_Click" OnClientClick="return confirm('Bạn muốn thêm món này?')" />
                <asp:Button ID="btnDelete" runat="server" Text="Xóa món" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn muốn xóa món này?')" />
                <asp:Button ID="btnClear" runat="server" Text="Làm mới" OnClick="btnClear_Click" />
                <asp:Button ID="btnThanhToan" runat="server" Text="Thanh toán" OnClick="btnThanhToan_Click" />
            </div>
            <div class="row">
                <asp:Label CssClass="ThongBao" ID="lblMessage" runat="server" ></asp:Label>
            </div>
            <div class="bang">
                <asp:GridView ID="gvMon" runat="server" AutoGenerateColumns="False" Width="433px" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="MaMon" HeaderText="Mã món" />
                        <asp:BoundField DataField="TenMon" HeaderText="Tên món" />
                        <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" ItemStyle-CssClass="SoLuongColumn" />
                    </Columns>
                    <EditRowStyle BackColor="#2461BF" />
                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#EFF3FB" />
                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                    <SortedDescendingHeaderStyle BackColor="#4870BE" />
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
