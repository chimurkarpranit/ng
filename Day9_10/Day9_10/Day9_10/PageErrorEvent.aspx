<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageErrorEvent.aspx.cs" Inherits="Day9_10.PageErrorEvent" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Error Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center;margin-top:250px">
        <asp:Panel runat="server" ID="panel1">
            <asp:Button ID="ErrorButton1" runat="server" Text="ErrorButton" OnClick="ErrorButtonClick1" Height="37px" Width="151px" />
            <br />
            <asp:Label ID="FileContents" runat="server"></asp:Label>
            <br />
            <asp:Button ID="ErrorButton2" runat="server" Text="ErrorButton for Page Error Event" OnClick="ErrorButtonClick2" Height="37px" Width="151px" />
            <br />
        </asp:Panel>
    </div>
    </form>
</body>
</html>