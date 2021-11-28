<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QLNVForm.aspx.cs" Inherits="lab4_SA.QLNVForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="SEARCH" OnClick="Button1_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="true" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"></asp:GridView>
        <br/>
        <table>
        <tr>
            <td>MaNV</td> 
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Ten</td> 
        <td><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Chucvu</td> 
        <td><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Phongban</td> 
        <td><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
        <td>Chuthich</td> 
        <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
        </tr>
        </table><br />
        <asp:Button ID="Button2" runat="server" Text="ADD" OnClick="Button2_Click" />
        <asp:Button ID="Button3" runat="server" Text="UPDATE" OnClick="Button3_Click" />
        <asp:Button ID="Button4" runat="server" Text="DELETE" OnClick="Button4_Click" OnClientClick="return confirm('ARE U SURE');" />
    </form>
</body>
</html>
