<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SIGN UP.aspx.cs" Inherits="WebApplication2.SIGN_UP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 620px; top: 202px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 613px; top: 294px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 638px; top: 381px; position: absolute; width: 106px;" Text="sign up" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 425px; top: 203px; position: absolute" Text="enter your new username:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 434px; top: 295px; position: absolute" Text="enter your new password:"></asp:Label>
        <asp:Label ID="Label3" runat="server" Font-Size="XX-Large" style="z-index: 1; left: 455px; top: 99px; position: absolute; height: 42px; width: 313px" Text="sign up to the site here!!"></asp:Label>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/LOG IN.aspx" style="z-index: 1; left: 544px; top: 530px; position: absolute; height: 30px; width: 235px">return to log in page</asp:HyperLink>
        </p>
    </form>
</body>
</html>
