<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="WcfNotesAppClient1.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Title:
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        Details:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
    
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
