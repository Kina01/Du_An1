<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ThucDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Menu.css" />
    <div class="Menu">
        <div>
            <asp:GridView ID="gvThucDon" runat="server" AutoGenerateColumns="False" Height="107px" style="margin-left: 126px" Width="981px">
                <Columns>
                    <asp:BoundField DataField="TenMon" HeaderText="Tên món" />
                    <asp:ImageField DataImageUrlField="HinhAnh" DataImageUrlFormatString="/~Image/{0}" HeaderText="Hình ảnh">
                        <ControlStyle CssClass="Anh" Height="100px" Width="100px" />
                    </asp:ImageField>
                    <asp:BoundField DataField="DonGia" HeaderText="Giá" />
                </Columns>
            </asp:GridView>
        </div>
         <%--<div class="container">
             <asp:GridView ID="gvThucDon" runat="server" AutoGenerateColumns="False" style="margin-left: 363px" Width="859px">
                 <Columns>
                     <asp:BoundField HeaderText="Tên món" DataField="TenMon" />
                     <asp:ImageField DataImageUrlField="HinhAnh" DataImageUrlFormatString="~/Image/{0}">
                         <ControlStyle Height="100px" Width="100px";/>
                     </asp:ImageField>
                     <asp:BoundField HeaderText="Giá" DataField="DonGia" />
                 </Columns>

             </asp:GridView>
         </div>--%>
    </div>
</asp:Content>
