<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication2.homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" visible="True">
        <div>
            <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 1071px; top: 685px; position: absolute; height: 45px; width: 149px;" Text="add a review!" OnClick="Button1_Click" />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large"></asp:Label>
        </div>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" style="z-index: 1; left: 38px; top: 130px; position: absolute" Text="refrash table" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" style="z-index: 1; left: 295px; top: 94px; position: absolute; height: 528px; width: 568px">
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server" style="z-index: 1; left: 275px; top: 628px; position: absolute; height: 145px; width: 304px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 38px; top: 572px; position: absolute; height: 44px; width: 140px" Text="delete selected music" Visible="False" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" style="z-index: 1; left: 40px; top: 748px; position: absolute; height: 32px; width: 139px" Text="delete selcted review" Visible="False" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 617px; top: 670px; position: absolute" Text="the performer of the song:"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 796px; top: 674px; position: absolute"></asp:Label>
        <p>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 619px; top: 717px; position: absolute" Text="the ganre of the song:"></asp:Label>
        </p>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 776px; top: 721px; position: absolute"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 622px; top: 788px; position: absolute" Text="the user who wrote the review:"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; left: 832px; top: 792px; position: absolute"></asp:Label>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click1" style="z-index: 1; left: 1154px; top: 105px; position: absolute; height: 32px; width: 177px" Text="logout" />
    </form>
</body>
</html>
