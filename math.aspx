<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="math.aspx.cs" Inherits="mathcalldll.math" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbladd" runat="server" Text="First Number"></asp:Label>
            <asp:TextBox ID="txtfirst" runat="server" Text=""></asp:TextBox><br />
            <asp:Label ID="lbladd1" runat="server" Text="Second Number"></asp:Label>
            <asp:TextBox ID="txtsecond" runat="server" Text=""></asp:TextBox><br />
            <asp:Label ID="lbltotal" runat="server" Text="Result"></asp:Label>
            <asp:TextBox ID="txttotal" runat="server" Text=""></asp:TextBox>
            <br />
            
        </div>

        <div>
            <asp:Button ID="btnsum" runat="server" Text="ADD" OnClick="btnsum_Click" />
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
