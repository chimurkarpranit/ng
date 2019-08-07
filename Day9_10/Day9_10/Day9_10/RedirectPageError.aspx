<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectPageError.aspx.cs" Inherits="Day9_10.RedirectPageError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;margin-top:250px">
        <asp:Panel ID="Panel1" runat="server">
            <asp:Button ID="ErrorButton3" runat="server" Text="ErrorButton" OnClick="ErrorButtonClick3" Height="37px" Width="151px" />
            <br />
            <asp:Label ID="filedata" runat="server"></asp:Label>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
