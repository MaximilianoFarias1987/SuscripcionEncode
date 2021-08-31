<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SuscripcionEncode._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <br />
    
    <h3 class="text-info">Suscripción</h3>
    <h5 class="text-info">Para realizar la suscripción complete los siguientes datos</h5>
    <asp:Panel runat="server" ID="pnlWarning" BackColor="Red" ForeColor="White" Width="100%" Height="50px" Font-Strikeout="false" Font-Overline="false" Font-Size="XX-Large" HorizontalAlign="NotSet" Visible="false">Ya existe un suscriptor registrado con ese nombre de usuario y/o documento<asp:Button ID="btnCerrarWarning" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="29px" style="margin-left: 17px" Text="X" Width="42px" OnClick="btnCerrarWarning_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlSuccessfully" runat="server" ForeColor="White" Width="100%" Height="50px" Font-Strikeout="False" Font-Overline="False" Font-Size="XX-Large" HorizontalAlign="NotSet" Visible="False" BackColor="#00CC00">El registro y la suscripcion fueron exitosos<asp:Button ID="btnCerrarSuccess" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="29px" style="margin-left: 23px" Text="X" Width="42px" OnClick="btnCerrarSuccess_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlUsuarioSuscripto" runat="server" ForeColor="White" Width="100%" Height="50px" Font-Strikeout="False" Font-Overline="False" Font-Size="XX-Large" HorizontalAlign="NotSet" Visible="False" BackColor="#ffcc00">El suscriptor tiene una suscripción vigente<asp:Button ID="btncerrarSuscriptorSuscripto" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="29px" style="margin-left: 23px" Text="X" Width="42px" OnClick="btncerrarSuscriptorSuscripto_Click" />
    </asp:Panel>
    <asp:Panel ID="pnlUsuarioNoSuscripto" runat="server" ForeColor="White" Width="100%" Height="47px" Font-Strikeout="False" Font-Overline="False" Font-Size="XX-Large" HorizontalAlign="NotSet" Visible="False" BackColor="#ffcc00">El suscriptor no tiene una suscripción. ¿Desea suscribirlo?
        <asp:Button ID="btnSuscribir" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="34px" style="margin-left: 23px" Text="Aceptar" Width="109px" OnClick="btnSuscribir_Click" />
        <asp:Button ID="btnCerrarSuscripcion" runat="server" BackColor="Black" Font-Bold="True" Font-Size="X-Large" ForeColor="White" Height="34px" style="margin-left: 23px" Text="Cancelar" Width="117px" OnClick="btnCerrarSuscripcion_Click" />
    </asp:Panel>
    <hr />
    
    <div class="border">
        <div class="row g-3">
            <div class="container">
                <h4>Buscar Suscriptor</h4>
                <br />
                <div class="form-group">
                    <div class="col-md-5">
                        <asp:Label ID="lblTipoDoc" Text="Tipo de Documento" Font-Bold="true" runat="server" />                        
                        <asp:DropDownList runat="server" ID="cboTipoDoc" CssClass="form-control">
                            <asp:ListItem Text="Seleccione un tipo de documento..." />
                            <asp:ListItem Text="DNI" />
                            <asp:ListItem Text="LC" />
                            <asp:ListItem Text="PASAPORTE" />
                        </asp:DropDownList>
                        <asp:Label ID="lblMsjTipoDoc" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-5">
                        <asp:Label ID="lblNumeroDoc" Text="Número de Documento" Font-Bold="true" runat="server" />
                        <asp:TextBox ID="txtNumeroDoc" runat="server" CssClass="form-control"   type="number" />
                        <asp:Label ID="lblMsjNumDoc" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-2">
                        <asp:Button ID="btnBuscar" Text="Buscar" runat="server" CssClass="btn btn-success" Width="100px" OnClick="btnBuscar_Click" />
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div class="row g-3">
            <div class="container">
                <h4>Datos del Suscriptor</h4>
                <br />
                <div class="form-group">
                    <div class="col-md-5">
                        <asp:Label ID="lblNombre" Text="Nombre" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                        <asp:Label ID="lblMsjNombre" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-5">
                        <asp:Label ID="lblApellido" Text="Apellido" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" />
                        <asp:Label ID="lblMsjApellido" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-2">
                        <asp:Button ID="btnNuevo" Text="Nuevo" runat="server" CssClass="btn btn-info" Width="100px" OnClick="btnNuevo_Click" />
                    </div>
                    <div class="col-md-5">
                        <asp:Label ID="lblDireccion" Text="Dirección" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" />
                        <asp:Label ID="lblMsjDireccion" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-5">
                        <asp:Label ID="lblEmail" Text="Email" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email" />
                        <asp:Label ID="lblMsjEmail" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-2">
                        <asp:Button ID="btnModificar" Text="Modificar" runat="server" CssClass="btn btn-primary" Width="100px" OnClick="btnModificar_Click" />
                    </div>
                    <div class="col-md-5">
                        <asp:Label ID="lblTelefono" Text="Teléfono" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" />
                        <asp:Label ID="lblMsjTelefono" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-5">
                        <%--<asp:Label ID="lblEstado" Text="Estado" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtEstado" runat="server" CssClass="form-control" Enabled="false" />--%>
                    </div>
                    <div class="col-md-2">
                        <asp:Button ID="btnGuardar" Text="Guardar" runat="server" CssClass="btn btn-success" Width="100px" OnClick="btnGuardar_Click" />
                        <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-warning float-right pt-3"  Width="100px" OnClick="btnCancelar_Click" />
                    </div>
                    
                    <%--<div class="">
                        <asp:Button ID="btnCancelar" Text="Cancelar" runat="server" CssClass="btn btn-warning "  Width="100px" OnClick="btnCancelar_Click" />
                    </div>--%>
                    
                </div>
            </div>
        </div>
        <hr />
        <div class="row g-2">
            <div class="container">
                <div class="form-group">
                    <div class="col-md-5">
                        <asp:Label ID="lblNombreUsuario" Text="Nombre de Usuario" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtNombreUsuario" runat="server" CssClass="form-control" />
                        <asp:Label ID="lblMsjNombreUsuario" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                    <div class="col-md-5">
                        <asp:Label ID="lblContrasena" Text="Contraseña" runat="server" Font-Bold="true" />
                        <asp:TextBox ID="txtContrasena" runat="server" CssClass="form-control"  type="password" />
                        <asp:Label ID="lblMsjContrasena" Text="" Font-Bold="true" runat="server" Visible="false" />
                    </div>
                </div>
            </div>
        </div>
        <hr />
        <div class="row">
            <div class="container">
                <div class="col-md-12">
                    <asp:Button ID="btnRegistrarSuscripcion" Text="Registrar Suscripción" runat="server" CssClass="btn btn-success" OnClick="btnRegistrarSuscripcion_Click" />
                </div>
            </div>
        </div>
    </div>
     
    
    <script>

        function MensajeError() {
            swal("Error", "No se pudo realizar la suscripcion", "error");
        }

        function MensajeSuccess() {
            swal("Muy Bien!", "Suscripción realizada con exito", "success");
        }

        function MensajeInsertarSuscriptorSuccess() {
            swal("Muy Bien!", "Suscriptor registrado con exito", "success");
        }

        function MensajeInsertarSuscriptorError() {
            swal("Error", "No se ha podido registrar el suscriptor", "error");
        }

        function MensajeEditarSuscriptorError() {
            swal("Error", "No se ha podido editar el suscriptor", "error");
        }

        function MensajeEditarSuscriptorSuccess() {
            swal("Muy Bien!", "Suscriptor editado con exito", "success");
        }
    </script>
</asp:Content>
