﻿using DAL.Data;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuscripcionEncode
{
    public partial class _Default : Page
    {
        Conexion conexion = new Conexion();
        Suscriptor oSuscriptor = new Suscriptor();
        Suscripcion oSuscripcion = new Suscripcion();

        bool nuevo;
        int id;
        public _Default()
        {
            nuevo = false;
            id = 0;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                btnGuardar.Enabled = false;
                DeshabilitarTxt();
            }
        }


        //METODO DESHABILITAR TODOS LOS TXT
        public void DeshabilitarTxt()
        {
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            txtContrasena.Enabled = false;
            txtNombreUsuario.Enabled = false;
            
        }
        //METODO HABILITAR TODOS LOS TXT
        public void HabilitarTxt()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            txtContrasena.Enabled = true;
            txtNombreUsuario.Enabled = true;

        }

        //METODO PARA LIMPIAR LOS CAMPOS
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNumeroDoc.Text = "";
            cboTipoDoc.SelectedIndex = 0;
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombreUsuario.Text = "";
            txtContrasena.Text = "";
        }

        //METODO PARA CARGAR LOS TEXTBOX
        private void CargarTextBox()
        {
            List<Suscriptor> lista = BLL.BLLSuscriptor.listaSuscriptores("Suscriptor");
            if (lista != null)
            {
                foreach (var x in lista)
                {
                    if (cboTipoDoc.SelectedValue == x.TipoDocumento && txtNumeroDoc.Text == x.Documento.ToString())
                    {
                        id = x.IdSuscriptor;
                        ViewState["variableId"] = id;
                        txtNombre.Text = x.Nombre;
                        txtApellido.Text = x.Apellido;
                        txtDireccion.Text = x.Direccion;
                        txtEmail.Text = x.Email;
                        txtTelefono.Text = x.Telefono;
                        txtNombreUsuario.Text = x.NombreUsuario;
                        txtContrasena.Text = x.Contrasena;
                    }
                    
                }
            }
        }

        //VALIDAR NOMBRE DE USUARIO Y DNI
        private bool Validar(string nomUsuario, int documento, string tipoDoc)
        {
            //bool valido = false;
            List<Suscriptor> lista = BLL.BLLSuscriptor.listaSuscriptores("Suscriptor");
                foreach (var x in lista)
                {
                    if ((x.TipoDocumento == tipoDoc && x.Documento == documento) || x.NombreUsuario == nomUsuario)
                    {
                        pnlWarning.Visible = true;
                        return true;
                    }
                    
                }
            return false;

        }


        //VALIDAR SUSCRIPTOR CON SUSCRIPCION
        public static bool ValidarSuscripcion(string tipoDoc, int numDoc)
        {
            

            return BLL.BLLSuscripcion.ValidarSuscripcion(tipoDoc, numDoc);

        }

        //INSERTAR
        public bool InsertarSuscriptor(string nombre, string apellido, int numDoc, string tipoDoc, string direccion, string tel, string email, string user, string pass)
        {
            Suscriptor suscriptor = new Suscriptor();
            suscriptor.Nombre = nombre;
            suscriptor.Apellido = apellido;
            suscriptor.Documento = numDoc;
            suscriptor.TipoDocumento = tipoDoc;
            suscriptor.Direccion = direccion;
            suscriptor.Telefono = tel;
            suscriptor.Email = email;
            suscriptor.NombreUsuario = user;
            suscriptor.Contrasena = pass;
            return BLL.BLLSuscriptor.Insertar(suscriptor);
        }


        //EDITAR
        public bool EditarSuscriptor(string nombre, string apellido, int numDoc, string direccion, string tel, string email, string user, string pass)
        {
            Suscriptor suscriptor = new Suscriptor();
            suscriptor.Nombre = nombre;
            suscriptor.Apellido = apellido;
            suscriptor.Documento = numDoc;            
            suscriptor.Direccion = direccion;
            suscriptor.Telefono = tel;
            suscriptor.Email = email;
            suscriptor.NombreUsuario = user;
            suscriptor.Contrasena = pass;
            return BLL.BLLSuscriptor.Editar(suscriptor);
        }


        //INSERTAR SUSCRIPCION

        public bool InsertarSuscripcion(int id)
        {
            
            Suscripcion suscripcion = new Suscripcion();
            suscripcion.IdSuscriptor= id;
            return BLL.BLLSuscripcion.Insertar(suscripcion);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarSuscripcion(cboTipoDoc.Text,Convert.ToInt32(txtNumeroDoc.Text)))
            {
                pnlUsuarioSuscripto.Visible = true;
                CargarTextBox();
            }
            else
            {
                pnlUsuarioNoSuscripto.Visible = true;
            }
            
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            nuevo = false;
            ViewState["variableNuevo"] = nuevo;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            HabilitarTxt();
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            btnNuevo.Enabled = false;
            nuevo = true;
            ViewState["variableNuevo"] = nuevo;
            btnGuardar.Enabled = true;
            btnModificar.Enabled = false;
            HabilitarTxt();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnRegistrarSuscripcion_Click(object sender, EventArgs e)
        {

            id = (int)ViewState["variableId"];
            bool resultado = InsertarSuscripcion(id);
            if (resultado)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "MyFunction", "MensajeSuccess();", true);
                Limpiar();
                DeshabilitarTxt();
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "MyFunction", "MensajeError();", true);
                Limpiar();
                DeshabilitarTxt();
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            nuevo = (bool)ViewState["variableNuevo"];
            if (nuevo)
            {
                if (cboTipoDoc.SelectedIndex < 1)
                {
                    lblMsjTipoDoc.ForeColor = Color.Red;
                    lblMsjTipoDoc.Text = "Debe ingresar un número de documento";
                    lblMsjTipoDoc.Visible = true;
                    cboTipoDoc.Focus();
                }
                if (txtNumeroDoc.Text == string.Empty)
                {
                    lblMsjNumDoc.ForeColor = Color.Red;
                    lblMsjNumDoc.Text = "Debe ingresar un número de documento";
                    lblMsjNumDoc.Visible = true;
                    txtNumeroDoc.Focus();
                }
                if (txtNombre.Text == string.Empty)
                {
                    lblMsjNombre.ForeColor = Color.Red;
                    lblMsjNombre.Text = "Debe ingresar un nombre";
                    lblMsjNombre.Visible = true;
                    txtNombre.Focus();
                }
                if (txtApellido.Text == string.Empty)
                {
                    lblMsjApellido.ForeColor = Color.Red;
                    lblMsjApellido.Text = "Debe ingresar un apellido";
                    lblMsjApellido.Visible = true;
                    txtApellido.Focus();
                }
                if (txtDireccion.Text == string.Empty)
                {
                    lblMsjDireccion.ForeColor = Color.Red;
                    lblMsjDireccion.Text = "Debe ingresar un direccion";
                    lblMsjDireccion.Visible = true;
                    txtDireccion.Focus();
                }
                if (txtEmail.Text == string.Empty)
                {
                    lblMsjEmail.ForeColor = Color.Red;
                    lblMsjEmail.Text = "Debe ingresar un email";
                    lblMsjEmail.Visible = true;
                    txtEmail.Focus();
                }
                if (txtTelefono.Text == string.Empty)
                {
                    lblMsjTelefono.ForeColor = Color.Red;
                    lblMsjTelefono.Text = "Debe ingresar un telefono";
                    lblMsjTelefono.Visible = true;
                    txtTelefono.Focus();
                }
                if (txtNombreUsuario.Text == string.Empty)
                {
                    lblMsjNombreUsuario.ForeColor = Color.Red;
                    lblMsjNombreUsuario.Text = "Debe ingresar un nombre de usuario";
                    lblMsjNombreUsuario.Visible = true;
                    txtNombreUsuario.Focus();
                }
                if (txtContrasena.Text == string.Empty)
                {
                    lblMsjContrasena.ForeColor = Color.Red;
                    lblMsjContrasena.Text = "Debe ingresar un contraseña";
                    lblMsjContrasena.Visible = true;
                    txtContrasena.Focus();
                }
                else if(!Validar(txtNombreUsuario.Text, Convert.ToInt32(txtNumeroDoc.Text), cboTipoDoc.Text))
                {
                    InsertarSuscriptor(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNumeroDoc.Text), cboTipoDoc.Text, txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtNombreUsuario.Text, txtContrasena.Text);
                    //pnlSuccessfully.Visible = true;
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "MyFunction", "MensajeInsertarSuscriptorSuccess();", true);
                    Limpiar();
                    btnModificar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    DeshabilitarTxt();
                }
                
            }
            else
            {
                EditarSuscriptor(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNumeroDoc.Text), txtDireccion.Text, txtTelefono.Text, txtEmail.Text, txtNombreUsuario.Text, txtContrasena.Text);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "MyFunction", "MensajeEditarSuscriptorSuccess();", true);
                Limpiar();
                btnModificar.Enabled = true;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                DeshabilitarTxt();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            btnNuevo.Enabled = true;
            btnModificar.Enabled = true;
            pnlSuccessfully.Visible = false;
            DeshabilitarTxt();
        }

        protected void btnCerrarSuccess_Click(object sender, EventArgs e)
        {
            pnlSuccessfully.Visible = false;
        }

        protected void btnCerrarWarning_Click(object sender, EventArgs e)
        {
            pnlWarning.Visible = false;
        }

        protected void btncerrarSuscriptorSuscripto_Click(object sender, EventArgs e)
        {
            pnlUsuarioSuscripto.Visible = false;
        }

        protected void btnCerrarSuscripcion_Click(object sender, EventArgs e)
        {
            pnlUsuarioNoSuscripto.Visible = false;
        }

        protected void btnSuscribir_Click(object sender, EventArgs e)
        {
            pnlUsuarioNoSuscripto.Visible = false;
            CargarTextBox();
        }
    }
}