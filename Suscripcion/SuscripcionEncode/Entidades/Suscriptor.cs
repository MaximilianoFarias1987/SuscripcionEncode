using SuscripcionEncode.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace SuscripcionEncode.Entidades
{
    public class Suscriptor
    {
        Conexion conexion = new Conexion();


        public int IdSuscriptor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Documento { get; set; }
        public string TipoDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }


        //METODO INSERTAR

        public void Insertar(Suscriptor suscriptor)
        {
            string nombreSP = "sp_InsertarSuscriptorSuscripcion";
            conexion.AbrirConexion();
            conexion.Cmd.CommandType = CommandType.StoredProcedure;
            conexion.Cmd.CommandText = nombreSP;
            conexion.Cmd.Parameters.AddWithValue("@Nombre", suscriptor.Nombre);
            conexion.Cmd.Parameters.AddWithValue("@Apellido", suscriptor.Apellido);
            conexion.Cmd.Parameters.AddWithValue("@NumeroDocumento", suscriptor.Documento);
            conexion.Cmd.Parameters.AddWithValue("@TipoDocumento", suscriptor.TipoDocumento);
            conexion.Cmd.Parameters.AddWithValue("@Direccion", suscriptor.Direccion);
            conexion.Cmd.Parameters.AddWithValue("@Telefono", suscriptor.Telefono);
            conexion.Cmd.Parameters.AddWithValue("@Email", suscriptor.Email);
            conexion.Cmd.Parameters.AddWithValue("@NombreUsuario", suscriptor.NombreUsuario);
            conexion.Cmd.Parameters.AddWithValue("@Password", suscriptor.Contrasena);
            conexion.Cmd.ExecuteNonQuery();
            conexion.Cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }


        //METODO EDITAR

        public void Editar(Suscriptor suscriptor)
        {
            string nombreSP = "sp_EditarSuscriptor";
            conexion.AbrirConexion();
            conexion.Cmd.CommandType = CommandType.StoredProcedure;
            conexion.Cmd.CommandText = nombreSP;
            conexion.Cmd.Parameters.AddWithValue("@Nombre", suscriptor.Nombre);
            conexion.Cmd.Parameters.AddWithValue("@Apellido", suscriptor.Apellido);
            conexion.Cmd.Parameters.AddWithValue("@NumeroDocumento", suscriptor.Documento);            
            conexion.Cmd.Parameters.AddWithValue("@Direccion", suscriptor.Direccion);
            conexion.Cmd.Parameters.AddWithValue("@Telefono", suscriptor.Telefono);
            conexion.Cmd.Parameters.AddWithValue("@Email", suscriptor.Email);
            conexion.Cmd.Parameters.AddWithValue("@NombreUsuario", suscriptor.NombreUsuario);
            conexion.Cmd.Parameters.AddWithValue("@Password", suscriptor.Contrasena);
            conexion.Cmd.ExecuteNonQuery();
            conexion.Cmd.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}