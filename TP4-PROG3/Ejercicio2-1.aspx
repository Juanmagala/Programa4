<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2-1.aspx.cs" Inherits="TP4_PROG3.Ejercicio2_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 33px;
        }
        .auto-style5 {
            width: 208px;
        }
        .auto-style6 {
            height: 33px;
            width: 208px;
        }
        .auto-style7 {
            width: 203px;
        }
        .auto-style8 {
            height: 33px;
            width: 203px;
        }
        .auto-style9 {
            width: 245px;
        }
        .auto-style10 {
            height: 33px;
            width: 245px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">Id Producto:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlProducto" runat="server">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtProducto" runat="server" Width="247px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Id Categoria:</td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlCategoria" runat="server">
                            <asp:ListItem Value="=">Igual a:</asp:ListItem>
                            <asp:ListItem Value="&gt;">Mayor a:</asp:ListItem>
                            <asp:ListItem Value="&lt;">Menor a:</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:TextBox ID="txtCategoria" runat="server" Width="247px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style9">
                        <asp:Button ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" Text="Filtrar" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnQuitarFiltro" runat="server" OnClick="btnQuitarFiltro_Click" Text="Quitar Filtro" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <asp:GridView ID="grdProductos" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
