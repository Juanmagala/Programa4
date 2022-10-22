<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3-2.aspx.cs" Inherits="TP4_PROG3.Ejercicio3_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblListado" runat="server" Font-Bold="True" Font-Size="Larger" Text="Listado de libros:"></asp:Label>
        </div>
        <asp:GridView ID="grdLibros" runat="server">
        </asp:GridView>
        <asp:LinkButton ID="lbtnConsultarTema" runat="server" OnClick="lbtnConsultarTema_Click">Consultar Otro Tema</asp:LinkButton>
    </form>
</body>
</html>
