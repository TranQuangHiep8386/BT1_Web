<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tuvi.aspx.cs" Inherits="WebApplication1.tuvi" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tử Vi</title>
    <style>
        .output {
            margin-top: 10px;
            padding: 8px;
            background: #f1f1f1;
            border: 1px solid #ccc;
            font-family: Arial;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label>Họ tên: </label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br /><br />

            <label>Giới tính: </label>
            <asp:DropDownList ID="ddlGender" runat="server">
                <asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
                <asp:ListItem Text="Nữ" Value="Nữ"></asp:ListItem>
            </asp:DropDownList>
            <br /><br />

            <label>Ngày sinh (dd/MM/yyyy): </label>
            <asp:TextBox ID="txtDob" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnXem" runat="server" Text="Xem Tử Vi" OnClick="btnXem_Click" />
            <br /><br />

            <asp:Literal ID="litResult" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
