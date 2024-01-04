<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="QuanLiNhaHang.DangNhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="/CSS/Login.css" />
    <link rel="icon" type="image/png" href="Images/DangNhap.png"/>
    <script src="/Icons/fontawesome-free-6.5.1-web/js/all.min.js" ></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div class="container_container_login" style="">
            <div class="logonForm">
                <h2 class="title_Form">Login</h2>
                <div class="row_Ip">
                    <label for="" class="title_Ip_Form">UserName</label>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </div>
                <div class="row_Ip">
                    <label for="" class="title_Ip_Form">Password</label>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="txtbingBug">
                    <asp:TextBox ForeColor="Red" ID="txtbingBug" runat="server" style="margin-top:10px;" BorderStyle="None" Width="272px"/>
                </div>
                <div class="contain_Btn">
                    <asp:Button ID="btnLogin" runat="server" Text="Đăng Nhập" style="min-width: 100%;
                                                                                     padding: 8px 4px;
                                                                                     border: 1px solid black;
                                                                                     border-radius: 13px;
                                                                                     background-color: rgba(56,53,76,45);
                                                                                     margin-top:10px;
                                                                                     color: #fff;
                                                                                     cursor: pointer;
                                                                                     " OnClick="btnLogin_Click"
                     />
                </div>
            </div>
        </div>
    <script src="./JS/javascrip.js"></script>
    </form>
</body>
</html>
