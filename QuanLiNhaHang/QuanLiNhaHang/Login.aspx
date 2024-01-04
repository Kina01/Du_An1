﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="QuanLiNhaHang.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<link rel="stylesheet" href="/CSS/Login.css" />
<link rel="icon" type="image/png" href="Images/DangNhap.png"/>

     <div class="container_container_login" style="">
            <div class="logonForm">
                <h2 class="title_Form">Login</h2>
                <div class="row_Ip">
                    <label for="" class="title_Ip_Form">UserName</label>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </div>
                <div class="row_Ip">
                    <label for="" class="title_Ip_Form">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="SingleLine"></asp:TextBox>
                </div>
                <div>
                    <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" AutoPostBack="true" Text="Hiện mật khẩu" />
                </div>
                <div class="txtbingBug">
                    <asp:TextBox ForeColor="Red" ID="txtbingBug" runat="server" style="margin-top:10px;" BorderStyle="None" Width="272px"/>
                </div>
                <div class="contain_Btn">
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
