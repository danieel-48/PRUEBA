<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario_Consulta.aspx.cs" Inherits="Proyecto_WEB.Consulta" %>

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
                    <asp:MenuItem Text="Usuario" Value="Usuario">
                        <asp:MenuItem Text="Registrar" Value="Registrar" NavigateUrl="~/Usuario.aspx"></asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>
            <br />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand">
                <Columns>
                    <asp:BoundField DataField="Cod_Persona" HeaderText="Codigo" ReadOnly="True"/>
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Fecha_nacimiento" HeaderText="Fecha Nacimiento" DataFormatString="{0:d}"/>
                    <asp:BoundField DataField="Sexo" HeaderText="Sexo" />
                        <asp:TemplateField>
                            <itemtemplate>
                                <asp:Button ID="btnModificar" runat="server" Text="Modificar" CommandName="Modificar" CommandArgument='<%# Container.DataItemIndex %>' OnClick="btnModificar_Click" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CommandName="Eliminar" CommandArgument='<%# Container.DataItemIndex %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <br />
        <div>
            <asp:Label ID="lblCod" runat="server" Text="Codigo:" Visible="false"></asp:Label>
            <br />
            <asp:TextBox ID="txtCod_Mod" runat="server" Visible="False" Enabled="false"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Nombre:" Visible="false"></asp:Label>
            <br />
            <asp:TextBox ID="txtNombre_Mod" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:RequiredFieldValidator runat="server" ErrorMessage="Campo Requerido" ForeColor="Red"
                ControlToValidate="txtNombre_Mod" ValidationGroup="Guardar" />
            <br />
             <asp:Label ID="lblFecha" runat="server" Text="Fecha Nacimiento:" Visible="false" ></asp:Label>
            <br />
            <asp:Calendar ID="Calendar1" runat="server" OnDayRender="Calendar1_DayRender" Visible="false"></asp:Calendar>
             
             <br />
             <asp:Label ID="lblSexo" runat="server" Text="Sexo:" Visible="false"></asp:Label>
             <br />
             <asp:DropDownList ID="ddlSexo" runat="server" Visible="false">
                 <asp:ListItem Value="M">M</asp:ListItem>
                 <asp:ListItem Value="F">F</asp:ListItem>
             </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="btn_Aceptar_Mod" runat="server" Text="Actualizar" OnClick="btn_Aceptar_Click" Visible="false" OnClientClick="return validarFecha();" ValidationGroup="Guardar" />
        </div>
    </form>
</body>
</html>
