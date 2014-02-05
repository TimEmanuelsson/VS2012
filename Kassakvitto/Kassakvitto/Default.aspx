<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Kassakvitto.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <p>
            <asp:Label ID="kop" runat="server" Text="Total köpsumma:"></asp:Label>
            <asp:TextBox ID="kopinput" runat="server"></asp:TextBox><asp:Label ID="kr" runat="server" Text="Kr"></asp:Label>
        </p>
         <p>
            <asp:Button ID="berakna" runat="server" Text="Beräkna rabatt" OnClick="berakna_Click" />
        </p>
        <asp:PlaceHolder ID="tabort" Visible="false" runat="server">
            
            <h1>Tims</h1>
            <h4>Tel: xxxx-xxxxx</h4>
            <h5>Öppetider: 8-20</h5>
            <p>
               --------------------------
            </p>
            <p>
                <asp:Label ID="total" runat="server" Text="Totalt: {0}"></asp:Label>
                <asp:Label ID="rabatsats" runat="server" Text="Rabattsats: {0}"></asp:Label>
                <asp:Label ID="rabatt" runat="server" Text="Rabatt: {0}"></asp:Label>
                <asp:Label ID="betala" runat="server" Text="Att betala: {0}"></asp:Label>
            </p>
            <p>
                --------------------------
            </p>
            <h4>VÄLKOMMEN ÅTER!</h4>
        </asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
