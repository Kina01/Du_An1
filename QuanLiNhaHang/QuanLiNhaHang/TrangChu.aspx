<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TrangChu.aspx.cs" Inherits="QuanLiNhaHang.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="/CSS/Ban.css" />
    <div class="Ban">
        <table>
            <tr>
                <td class="bann"><a href="DatBan.aspx"> Bàn 1  </a>
                    <div>
                        <asp:Label ID="Label10" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 7 người "></asp:Label> 
                    </div>
                    <div>
                        <asp:Label ID="Label1" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox1" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>

                </td>
                <td class="bann"><a href="DatBan.aspx"> Bàn 2 </a>
                    <div>
                        <asp:Label ID="Label11" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 10 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label2" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox2" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
                </td>
                <td class="bann"><a href="DatBan.aspx"> Bàn 3  </a>
                    <div>
                        <asp:Label ID="Label12" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 5 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label3" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox3" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
               </td>
            </tr>
            <tr>
                <td class="bann"><a href="DatBan.aspx"> Bàn 4  </a>
                    <div>
                        <asp:Label ID="Label13" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 7 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label4" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox4" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
              </td>
                <td class="bann"><a href="DatBan.aspx"> Bàn 5  </a>
                    <div>
                        <asp:Label ID="Label14" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 9 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label5" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox5" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
               </td>
                <td class="bann"><a href="DatBan.aspx"> Bàn 6  </a>
                    <div>
                        <asp:Label ID="Label15" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 5 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label6" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox6" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
              </td>
            </tr>
            <tr>
                <td class="bann"><a href="DatBan.aspx"> Bàn 7  </a>
                    <div>
                        <asp:Label ID="Label16" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 8 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label7" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox7" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
               </td>
                <td class="bann"><a href="DatBan.aspx"> Bàn 8  </a>
                    <div>
                        <asp:Label ID="Label17" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 11 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label8" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox8" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
              </td>
                <td class="bann"><a href="DatBan.aspx"> Bàn 9  </a>
                    <div>
                        <asp:Label ID="Label18" Font-Size="20px" runat="server" Text="Số lượng khách/bàn : 5 người "></asp:Label> 
                    </div>
                     <div>
                        <asp:Label ID="Label9" Font-Size="20px" runat="server" Text="Trạng thái : "></asp:Label> 
                        <asp:TextBox ID="TextBox9" runat="server" BorderStyle="None" BackColor="#ccccff"></asp:TextBox>
                    </div>
              </td>
            </tr>
        </table>
    </div>
</asp:Content>
