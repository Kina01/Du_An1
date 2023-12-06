<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="QuanLiNhaHang.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="/CSS/Login.css" />
     <div class="container_container_login" style="">
            <div class="logonForm">
                <h2 class="title_Form">Login</h2>
                <div class="row_Ip">
                    <label for="" class="title_Ip_Form">UserName</label>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                   <%-- <input type="text" id="txtUserName">--%>
                </div>
                <div class="row_Ip">
                    <label for="" class="title_Ip_Form">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                   <%-- <input type="text" id="txtPassword">--%>
                </div>
                <div class="txtbingBug">
                    <asp:TextBox ForeColor="Red" ID="txtbingBug" runat="server" BorderStyle="None" Width="272px"/>
                </div>
                <div class="contain_Btn">
                    <%--<input type="submit" id="btnSubmitLogin">--%>
                    <%--<asp:Button " ID="btnSubmitLogin" runat="server" Text="Đăng Nhập" />--%>
                    <asp:Button ID="btnLogin" runat="server" Text="Đăng Nhập" style="min-width: 100%;
                                                                                     padding: 8px 4px;
                                                                                     border: 1px solid black;
                                                                                     border-radius: 50px;
                                                                                     background-color: rgba(56,53,76,45);
                                                                                     margin-top:10px;
                                                                                     color: #fff;
                                                                                     " OnClick="btnLogin_Click"
                     />
                </div>
            </div>
        </div>
    <script src="./JS/javascrip.js"></script>
</asp:Content>
