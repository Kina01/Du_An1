<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThucDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Menu.css" />
    <link rel="icon" type="image/png" href="Images/ThucDon.png">
    <div class="Menu">
        <div class="Menu-1">
            <asp:GridView class="gvThucDon" ID="gvThucDon" runat="server" AutoGenerateColumns="False" style="margin-left: 528px;" Width="460px" CellPadding="4" ForeColor="Black" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellSpacing="2">
                <Columns>
                    <asp:BoundField DataField="MaMon" HeaderText="Mã món" />
                    <asp:BoundField DataField="TenMon" HeaderText="Tên món" >
                        <ItemStyle HorizontalAlign="Center" Width="300px" />
                    </asp:BoundField>
                    <asp:ImageField DataImageUrlField="HinhAnh" HeaderText="Hình ảnh" DataImageUrlFormatString="~/Images/{0}">
                        <ControlStyle Height="100px" Width="100px" />
                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="101px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="DonGia" HeaderText="Giá" >
                        <ItemStyle HorizontalAlign="Center" Width="100px" />
                    </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
        </div>    
    </div>
</asp:Content>
