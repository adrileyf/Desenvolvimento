<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="baixar.aspx.cs" Inherits="VhsAsp.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/Site.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
      <h1>VHSDesenvolvimento LTDA.</h1> 
      <h2> Desenvolvimento de Sistema para Integração Contábil, Versão para web.</h2>
    
    </div>
        <asp:Label ID="Label1" runat="server" Text="Selecione o Arquivo Download"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" Height="162px" Width="354px"></asp:ListBox>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click1" Text="Baixar" />
        <br />
        
    </form>
</body>
</html>
