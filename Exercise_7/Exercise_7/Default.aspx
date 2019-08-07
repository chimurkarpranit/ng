<%--Day 8 : Exercise_7 Repeater and DataList Control
Created By: Pranit Chimurkar
Date: 2019/08/02--%>
<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exercise_7._Default" %>

<!DOCTYPE html>
<html>
    <head>
        <title>Repeater and DataList</title>
    </head>
    <body>
    <form id="form1" runat="server">
    <div style="text-align: center;margin-top:250px">
    <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-left: 116">
        <asp:ListItem Value="0">Please Select</asp:ListItem>
            <asp:ListItem Value="FirstName">FirstName </asp:ListItem>
            <asp:ListItem Value="Salary">Salary</asp:ListItem>
            <asp:ListItem Value="BirthDate">DOB</asp:ListItem>
    </asp:DropDownList>

    <asp:Button ID="BtnDisplay" runat="server" OnClick="ButtonDisplay" Text="Display Records" /><br />

    <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand">        
    <HeaderTemplate>
        <table cellspacing="0" rules="all" border="1">
            <tr>
                <th scope="col" style="width: 80px">Name</th>
                <th scope="col" style="width: 280px">Address</th>
                <th scope="col" style="width: 100px">HomePhone</th>
                <th scope="col" style="width: 100px">Salary</th>
                <th scope="col" style="width: 170px">BirthDate</th>
            </tr>
    </HeaderTemplate>            
      <ItemTemplate>
        <tr>
            <td><asp:Label ID="lblName" runat="server" Text='<%# Eval("FirstName") %>' /></td>
            <td><asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>' /></td>
            <td><asp:Label ID="lblHomePhone" runat="server" Text='<%# Eval("HomePhone") %>' /></td>
            <td><asp:Label ID="lblSalary" runat="server" Text='<%# Eval("Salary") %>' /></td>
            <td><asp:Label ID="lblBirthday" runat="server" Text='<%# Eval("BirthDate") %>' /></td>
        </tr>
    </ItemTemplate>        
    <AlternatingItemTemplate>
                <tr><td><%#DataBinder.Eval(Container,"DataItem.FirstName")%></td>
                    <td><%#DataBinder.Eval(Container,"DataItem.Address")%></td>
                    <td><%#DataBinder.Eval(Container,"DataItem.HomePhone")%></td>
                     <td><%#DataBinder.Eval(Container,"DataItem.Salary")%></td>
                     <td><%#DataBinder.Eval(Container,"DataItem.Birthdate")%></td>
                </tr>
    </AlternatingItemTemplate>      
    </asp:Repeater>   
   <br /><br />
     
    <asp:DataList ID="DataList1" runat="server" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">   
        <HeaderTemplate>
        <table cellspacing="0" rules="all" border="1">
            <tr>
                <th scope="col" style="width: 80px">Name</th>
                <th scope="col" style="width: 280px">Address</th>
                <th scope="col" style="width: 100px">HomePhone</th>
                 <th scope="col" style="width: 100px">Salary</th>
                 <th scope="col" style="width: 170px">BirthDate</th>
            </tr>
            <br /><br />
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td><asp:Label ID="lblName" runat="server" Text='<%# Eval("FirstName") %>' /></td>
            <td><asp:Label ID="lblAddress" runat="server" Text='<%# Eval("Address") %>' /></td>
            <td><asp:Label ID="lblHomePhone" runat="server" Text='<%# Eval("HomePhone") %>' /></td>
            <td><asp:Label ID="lblSalary" runat="server" Text='<%# Eval("Salary") %>' /></td>
            <td><asp:Label ID="lblBirthday" runat="server" Text='<%# Eval("BirthDate") %>' /></td>
        </tr>
    </ItemTemplate>        
    <AlternatingItemTemplate>
        <tr>
            <td><%#DataBinder.Eval(Container,"DataItem.FirstName")%></td>
            <td><%#DataBinder.Eval(Container,"DataItem.Address")%></td>
            <td><%#DataBinder.Eval(Container,"DataItem.HomePhone")%></td>
            <td><%#DataBinder.Eval(Container,"DataItem.Salary")%></td>
            <td><%#DataBinder.Eval(Container,"DataItem.Birthdate")%></td>
         </tr>
    </AlternatingItemTemplate>
    </asp:DataList> <br />
        <asp:Button ID="BtnOne" runat="server" Font-Bold="true" Text="1" onclick="Btn1_Click" style="height: 26px"/>
        <asp:Button ID="BtnTwo" runat="server" Font-Bold="true" Text="2" onclick="Btn2_Click"/>    
</div>
</form>   
</body>
</html>