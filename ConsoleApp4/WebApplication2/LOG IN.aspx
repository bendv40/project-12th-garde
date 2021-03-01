<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOG IN.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 364px; top: 78px; position: absolute; height: 82px; width: 381px;" Text="wellcome to the song review website! log in to see reviews or to add them!" Font-Size="X-Large"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 425px; top: 295px; position: absolute" Text="PASSWORD:"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 528px; top: 199px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 527px; top: 293px; position: absolute"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 528px; top: 345px; position: absolute; width: 118px;" Text="sign in!" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 413px; top: 400px; position: absolute"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/SIGN UP.aspx" style="z-index: 1; left: 700px; top: 356px; position: absolute">new to the site ?CREATE A NEW USER !</asp:HyperLink>
        <p>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 415px; top: 201px; position: absolute; bottom: 552px;" Text="USERNAME"></asp:Label>
        </p>
    </form>
</body>
</html>
