<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyValuableCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Min värdefulla kalkylator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="op1" runat="server"></asp:TextBox>
        +
        <asp:TextBox ID="op2" runat="server"></asp:TextBox>
        <asp:Button ID="calbutton" runat="server" Text="Button" OnClick="calbutton_Click" />
        <asp:Label ID="mylable" runat="server" Text="Label"></asp:Label>
    </div>
    </form>
</body>
</html>
