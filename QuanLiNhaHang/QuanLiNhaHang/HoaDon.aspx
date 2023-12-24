<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="HoaDon.aspx.cs" Inherits="QuanLiNhaHang.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/HoaDon.css" />
     <div class="HoaDon">
         <div class="HoaDon1">
            <div style="font-size:25px;margin-bottom:20px;">Hóa đơn</div>
            <table>
                <tr>
                    <td>Tên món</td>
                    <td>Số lượng</td>
                    <td>Đơn giá</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox></td>
                    <td> <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox></td>
                </tr>

             
                </table>
            Thành tiền : <asp:TextBox ID="txtThanhTien" runat="server"></asp:TextBox>
            <h4 style="margin-top:10px;">Cảm ơn quý khách đã lựa chọn nhà hàng chúng tôi giữa muôn vàn sự lựa chọn. Xin chân thành cảm ơn và hẹn gặp lại.</h4>
         </div>
    </div>
</asp:Content>
