<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThucDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Menu.css" />
    <link rel="icon" type="image/png" href="Images/ThucDon.png">
    <div class="Menu">
        <div class="Menu-1">
            <asp:GridView class="gvThucDon" ID="gvThucDon" runat="server" AutoGenerateColumns="False" style="margin-left: 528px;" Width="460px" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
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
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
        </div>    
    </div>
</asp:Content>
