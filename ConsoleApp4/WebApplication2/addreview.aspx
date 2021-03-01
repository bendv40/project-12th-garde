<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addreview.aspx.cs" Inherits="WebApplication2.addreview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" style="position: absolute; z-index: 1; left: 414px; top: 95px; height: 32px" Text="here you can add a review to any song you want!" Font-Size="XX-Large" ForeColor="Lime"></asp:Label>
        </p>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 547px; top: 190px; position: absolute; width: 198px;"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 543px; top: 292px; position: absolute; width: 215px;"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 534px; top: 461px; position: absolute; height: 75px; width: 350px" Font-Size="Large"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 327px; top: 189px; position: absolute" Text="the name of the song:" Font-Size="X-Large" ForeColor="Blue"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 427px; top: 296px; position: absolute; height: 16px;" Text="performer:" Font-Size="X-Large" ForeColor="#FF9900"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 290px; top: 465px; position: absolute; height: 19px;" Text="write here your review:" Font-Size="X-Large" ForeColor="#33CC33"></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 541px; top: 630px; position: absolute; height: 52px; width: 284px;" Text="add the review!" />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="z-index: 1; top: 355px; position: absolute; left: 545px; width: 169px; height: 25px">
            <asp:ListItem>rock</asp:ListItem>
            <asp:ListItem>pop</asp:ListItem>
            <asp:ListItem>jaz</asp:ListItem>
            <asp:ListItem>rap</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label5" runat="server" Font-Size="X-Large" ForeColor="#339933" style="z-index: 1; left: 260px; top: 355px; position: absolute" Text="pick the ganre of the song:"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/homepage.aspx" style="z-index: 1; left: 1125px; top: 667px; position: absolute">return to home page</asp:HyperLink>
    </form>
</body>
</html>
