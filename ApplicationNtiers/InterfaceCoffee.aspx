<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InterfaceCoffee.aspx.cs" Inherits="ApplicationNtiers.InterfaceCoffee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="ButtonObtenir" runat="server" OnClick="ButtonObtenir_Click" Text="Obtenir infos cafes" />
        <br />
        <br />
        <br />
        <asp:Label ID="LabelID" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LabelName" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LabelType" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LabelPrice" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
