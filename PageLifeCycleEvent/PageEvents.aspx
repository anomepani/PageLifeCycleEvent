<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEvents.aspx.cs" Inherits="PageLifeCycleEvent.PageEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList ID="ddlCountry" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged"
                OnInit="ddlCountry_Init" OnLoad="ddlCountry_Load" OnPreRender="ddlCountry_PreRender">
                <asp:ListItem>India</asp:ListItem>
                <asp:ListItem>USA</asp:ListItem>
                <asp:ListItem>UK</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" OnInit="btnSave_Init" OnLoad="btnSave_Load" OnPreRender="btnSave_PreRender"/>
        </div>
    </form>
</body>
</html>
