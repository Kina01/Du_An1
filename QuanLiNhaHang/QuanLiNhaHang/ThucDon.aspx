<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThucDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Menu.css" />
    <link rel="icon" type="image/png" href="Images/ThucDon.png">
    <div class="Menu">
        <asp:GridView CssClass="grdMenu" ID="gvThucDon" runat="server" AutoGenerateColumns="False" style="margin-left: 528px;" Width="460px">
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
        </asp:GridView>    
    </div>
</asp:Content>
