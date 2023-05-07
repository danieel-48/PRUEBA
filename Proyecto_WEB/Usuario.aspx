<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Proyecto_WEB.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Menu ID="Menu1" runat="server" Orientation="Horizontal">
                <Items>
                    <asp:MenuItem Text="Usuario Consulta" Value="Consultar">
                        <asp:MenuItem NavigateUrl="~/Usuario_Consulta.aspx" Text="Consultar" Value="Consultar"></asp:MenuItem>
                    </asp:MenuItem>
                    <asp:MenuItem Text="Usuario" Value="Usuario" NavigateUrl="~/Usuario.aspx">
                        <asp:MenuItem Text="Registrar" Value="Registrar" NavigateUrl="~/Usuario.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
         <div>
            <br />
            <br />
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" ></asp:Label>
            <br />
            <asp:TextBox ID="txtNombre_Mod" runat="server" ></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Requerido" ForeColor="Red"
                ControlToValidate="txtNombre_Mod" ValidationGroup="Guardar" />
            <br />
            <asp:Label ID="lblFecha" runat="server" Text="Fecha Nacimiento:" ></asp:Label>
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender"></asp:Calendar>
             
             <br />
             <asp:Label ID="lblSexo" runat="server" Text="Sexo:"></asp:Label>
             <br />
             <asp:DropDownList ID="ddlSexo" runat="server">
                 <asp:ListItem Value="M">M</asp:ListItem>
                 <asp:ListItem Value="F">F</asp:ListItem>
             </asp:DropDownList>
             <br />
             <br />
            <asp:Button ID="btn_Registrar_Mod" runat="server" Text="Registrar" OnClick="btn_Registrar_Mod_Click" OnClientClick="return validarFecha();" ValidationGroup="Guardar" />
        </div>
    </form>
</body>
</html>
