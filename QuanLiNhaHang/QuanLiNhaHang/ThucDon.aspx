<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThucDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Menu.css" />
    <div class="Menu">
        <asp:GridView ID="gvThucDon" runat="server" AutoGenerateColumns="False" style="margin-left: 528px;;" Width="490px">
            <Columns>
                <asp:BoundField DataField="TenMon" HeaderText="Tên món" >
                    <ItemStyle HorizontalAlign="Center" Width="300px" />
                </asp:BoundField>
                <asp:ImageField DataImageUrlField="HinhAnh" DataImageUrlFormatString="~/Image/{0}">
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
