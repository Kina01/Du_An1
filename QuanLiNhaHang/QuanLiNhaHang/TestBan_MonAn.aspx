<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestBan_MonAn.aspx.cs" Inherits="QuanLiNhaHang.Ban_MonAn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label runat="server">Mã bàn</label>
            <asp:TextBox ID="txtMaBan" runat="server"></asp:TextBox>
        </div>
        <div>
            <label runat="server">Mã món</label>
            <asp:TextBox ID="txtMaMon" runat="server"></asp:TextBox>
        </div>
        <div>
            <label runat="server">Số lượng</label>
            <asp:TextBox ID="txtSoLuong" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="Thêm món" OnClick="btnAdd_Click" OnClientClick="return confirm('Bạn muốn thêm món này?')" />
            <asp:Button ID="btnDelete" runat="server" Text="Xóa món" OnClick="btnDelete_Click" OnClientClick="return confirm('Bạn muốn xóa món này?')" />
            <asp:Button ID="btnClear" runat="server" Text="Làm mới" OnClick="btnClear_Click" />
            <asp:Button ID="btnThanhToan" runat="server" Text="Thanh toán" OnClick="btnThanhToan_Click" />
            <asp:Label ID="lblMessage" runat="server" ></asp:Label>
        </div>
        <div>
            <asp:GridView ID="gvMon" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="MaMon" HeaderText="Mã món" />
                    <asp:BoundField DataField="TenMon" HeaderText="Tên món" />
                    <asp:BoundField DataField="SoLuong" HeaderText="Số lượng" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
