<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">


    <h1>Web service sand pit.</h1>


    <div>
        <asp:DropDownList ID="dropNames" runat="server" />

    </div>
    <div>       
        <asp:button runat="server" text="Button" OnClick="Unnamed1_Click" />
    </div>
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label" />
    </div>
        
    </form>
</body>

</html>
