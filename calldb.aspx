<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calldb.aspx.cs" Inherits="mathcalldll.calldb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnview" runat="server" Text="View" OnClick="btnview_Click" />
            <asp:Button ID="btndb" runat="server" Text="View Data Table" OnClick="btndb_Click" />
             <asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" />
        </div>
        <div>
            <asp:GridView ID="gdview1" runat="server"></asp:GridView>
            <br />
            <br />
            <asp:GridView ID="gdview2" runat="server"></asp:GridView>
        </div>
        <div>
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
