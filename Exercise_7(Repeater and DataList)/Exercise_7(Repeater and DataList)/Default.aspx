<%--Day 8 : Exercise_7 Repeater and DataList Control
Created By: Pranit Chimurkar
Date: 2019/08/02--%>
<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise_7_Repeater_and_DataList_._Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Emp_Details7</title>  
    <style type="text/css">
        .table
        {
           font-family:Times New Roman;
           background-color:#D8D8D8; 
           border:2px Solid;                  
        }
        .color
        {
            background-color:#4a712c;
            height:50px;
            font-size:larger;
        }
    </style>  
</head>
<body>
    <form id="form1" runat="server">
    <div style="align-content: center;margin-top:250px">  
    <asp:Label ID="LabelSort" runat="server" Text="Sort By"></asp:Label>
        <%--DropDownList--%>
        <asp:DropDownList ID="ddlSort" runat="server" AppendDataBoundItems="True">
            <asp:ListItem Value="0">--SELECT--</asp:ListItem>
            <asp:ListItem Value="FirstName">FirstName</asp:ListItem>
            <asp:ListItem Value="BirthDate">BirthDate</asp:ListItem>
            <asp:ListItem Value="Salary">Salary</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="BtnRecords" runat="server" Text="Display Records" onclick="BtnRecords_Click" />
        
        <%--Repeater--%>
        <asp:Repeater ID="Repeater1" runat="server">
        <HeaderTemplate>
        <table style="border-collapse:collapse;background-color:#D8D8D8" border="2px">
            <tr align="left" class="color">
            <th>FirstName</th>
            <th>BirthDate</th>
            <th>Salary</th>
            </tr>
        </table>
        </HeaderTemplate>
        <ItemTemplate>
        <table>
        <tr>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"FirstName") %>' ID="LabelFirstName"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"BirthDate") %>' ID="LabelBirthDate"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Salary") %>' ID="LabelSalary"></asp:Label></td>      
        </tr>
        </table>
        </ItemTemplate>
        </asp:Repeater><br />

        <%--DataList--%>
        <asp:DataList ID="DataList1" runat="server">
        <HeaderTemplate>
        <table class="table">
            <tr align="left" class="color">
            <th>FirstName</th>
            <th>BirthDate</th>
            <th>Salary</th>
            </tr>
        </table>
        </HeaderTemplate>
        <ItemTemplate>
        <table>
        <tr>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"FirstName") %>' ID="LblFirstName"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"BirthDate") %>' ID="LblBirthDate"></asp:Label></td>
        <td><asp:Label runat="server" Text='<%#DataBinder.Eval(Container.DataItem,"Salary") %>' ID="LblSalary"></asp:Label></td>        
        </tr>
        </table>
        </ItemTemplate>        
        </asp:DataList>
        <table>
        <tr>
            <td>
                <br />
                <asp:LinkButton runat="server" ID="BtnOne" Text="1" onclick="Btn1_Click"></asp:LinkButton>
                <asp:LinkButton runat="server" ID="BtnTwo" Text="2" onclick="Btn2_Click"></asp:LinkButton>
            </td>
        </tr>
        </table>
        </div>         
    </form>
</body>
</html>