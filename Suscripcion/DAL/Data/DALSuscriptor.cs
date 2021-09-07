using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class DALSuscriptor
    {
        //METODO INSERTAR

        public static bool Insertar(Suscriptor suscriptor)
        {
            //Conexion conexion = new Conexion();
            try
            {
                string nombreSP = "sp_InsertarSuscriptor";
                Conexion.AbrirConexion();
                Conexion.Cmd.CommandType = CommandType.StoredProcedure;
                Conexion.Cmd.CommandText = nombreSP;
                Conexion.Cmd.Parameters.AddWithValue("@Nombre", suscriptor.Nombre);
                Conexion.Cmd.Parameters.AddWithValue("@Apellido", suscriptor.Apellido);
                Conexion.Cmd.Parameters.AddWithValue("@NumeroDocumento", suscriptor.Documento);
                Conexion.Cmd.Parameters.AddWithValue("@TipoDocumento", suscriptor.TipoDocumento);
                Conexion.Cmd.Parameters.AddWithValue("@Direccion", suscriptor.Direccion);
                Conexion.Cmd.Parameters.AddWithValue("@Telefono", suscriptor.Telefono);
                Conexion.Cmd.Parameters.AddWithValue("@Email", suscriptor.Email);
                Conexion.Cmd.Parameters.AddWithValue("@NombreUsuario", suscriptor.NombreUsuario);
                Conexion.Cmd.Parameters.AddWithValue("@Password", EncryptKeys.EncriptarPassword(suscriptor.Contrasena, "keys"));
                Conexion.transaction = Conexion.conexion.BeginTransaction();
                Conexion.Cmd.Transaction = Conexion.transaction;
                Conexion.Cmd.ExecuteNonQuery();
                Conexion.Cmd.Parameters.Clear();
                Conexion.CommitTransaction();
                return true;
            }
            catch (Exception)
            {
                Conexion.BeginTransaction();
                return false;
            }
            //finally
            //{
            //    Conexion.CerrarConexion();
            //}
            
            
        }


        //METODO EDITAR

       
        public static bool Editar(Suscriptor suscriptor)
        {
            //Conexion conexion = new Conexion();
            try
            {
                string nombreSP = "sp_EditarSuscriptor";
                Conexion.AbrirConexion();
                Conexion.Cmd.CommandType = CommandType.StoredProcedure;
                Conexion.Cmd.CommandText = nombreSP;
                Conexion.Cmd.Parameters.AddWithValue("@Nombre", suscriptor.Nombre);
                Conexion.Cmd.Parameters.AddWithValue("@Apellido", suscriptor.Apellido);
                Conexion.Cmd.Parameters.AddWithValue("@NumeroDocumento", suscriptor.Documento);
                Conexion.Cmd.Parameters.AddWithValue("@Direccion", suscriptor.Direccion);
                Conexion.Cmd.Parameters.AddWithValue("@Telefono", suscriptor.Telefono);
                Conexion.Cmd.Parameters.AddWithValue("@Email", suscriptor.Email);
                Conexion.Cmd.Parameters.AddWithValue("@NombreUsuario", suscriptor.NombreUsuario);
                Conexion.Cmd.Parameters.AddWithValue("@Password", EncryptKeys.EncriptarPassword(suscriptor.Contrasena, "keys"));
                Conexion.transaction = Conexion.conexion.BeginTransaction();
                Conexion.Cmd.Transaction = Conexion.transaction;
                Conexion.Cmd.ExecuteNonQuery();
                Conexion.Cmd.Parameters.Clear();
                Conexion.CommitTransaction();
                return true;
            }
            catch (Exception)
            {
                Conexion.BeginTransaction();
                return true;
            }
            //finally
            //{
            //    Conexion.CerrarConexion();
            //}
            
            
        }



        //VALIDAR SUSCRIPTOR
        public static bool ValidarSuscriptor(string tipoDoc, int numDoc)
        {
            try
            {
                Conexion conexion = new Conexion();
                Conexion.CerrarConexion();
                return conexion.ValidarSuscriptor(tipoDoc, numDoc);


            }
            catch (Exception e)
            {
                return false;
                //throw new Exception("Ha ocurrido un error" + e.Message);

            }
        }



        //METODO CARGAR OBJETO
        public static Suscriptor CrearObjetoSuscriptor(SqlDataReader dr)
        {
            var suscriptor = new Suscriptor();

            if (!dr.IsDBNull(0))
            {
                suscriptor.IdSuscriptor = (int)dr["IdSuscriptor"];
            }
            if (!dr.IsDBNull(1))
            {
                suscriptor.Nombre = dr["Nombre"].ToString();
            }
            if (!dr.IsDBNull(2))
            {
                suscriptor.Apellido = dr["Apellido"].ToString();
            }
            if (!dr.IsDBNull(3))
            {
                suscriptor.Documento = (int)dr["NumeroDocumento"];
            }
            if (!dr.IsDBNull(4))
            {
                suscriptor.TipoDocumento = dr["TipoDocumento"].ToString();
            }
            if (!dr.IsDBNull(5))
            {
                suscriptor.Direccion = dr["Direccion"].ToString();
            }
            if (!dr.IsDBNull(6))
            {
                suscriptor.Telefono = dr["Telefono"].ToString();
            }
            if (!dr.IsDBNull(7))
            {
                suscriptor.Email = dr["Email"].ToString();
            }
            if (dr["NombreUsuario"].ToString() != null )
            {
                suscriptor.NombreUsuario = dr["NombreUsuario"].ToString();
            }
            if (!dr.IsDBNull(9))
            {
                suscriptor.Contrasena = dr["Password"].ToString();
            }





            return suscriptor;
        }


        


        //LEER TABLA
        public static List<Suscriptor> listaSuscriptores(string tabla)
        {
             
            try
            {
                List<Suscriptor> lista = new List<Suscriptor>();
                Suscriptor s = null;
                Conexion conexion = new Conexion();
                conexion.Leer(tabla);
                lista.Clear();
                while (conexion.Dr.Read())
                {
                    //s = new Suscriptor();
                    //if (!conexion.Dr.IsDBNull(0))
                    //{
                    //    s.IdSuscriptor = conexion.Dr.GetInt32(0);
                    //}
                    //if (!conexion.Dr.IsDBNull(1))
                    //{
                    //    s.Nombre = conexion.Dr.GetString(1);
                    //}
                    //if (!conexion.Dr.IsDBNull(2))
                    //{
                    //    s.Apellido = conexion.Dr.GetString(2);
                    //}
                    //if (!conexion.Dr.IsDBNull(3))
                    //{
                    //    s.Documento = conexion.Dr.GetInt32(3);
                    //}
                    //if (!conexion.Dr.IsDBNull(4))
                    //{
                    //    s.TipoDocumento = conexion.Dr.GetString(4);
                    //}
                    //if (!conexion.Dr.IsDBNull(5))
                    //{
                    //    s.Direccion = conexion.Dr.GetString(5);
                    //}
                    //if (!conexion.Dr.IsDBNull(6))
                    //{
                    //    s.Telefono = conexion.Dr.GetString(6);
                    //}
                    //if (!conexion.Dr.IsDBNull(7))
                    //{
                    //    s.Email = conexion.Dr.GetString(7);
                    //}
                    //if (!conexion.Dr.IsDBNull(8))
                    //{
                    //    s.NombreUsuario = conexion.Dr.GetString(8);
                    //}
                    //if (!conexion.Dr.IsDBNull(9))
                    //{
                    //    s.Contrasena = conexion.Dr.GetString(9);
                    //}
                    s = CrearObjetoSuscriptor(conexion.Dr);
                    lista.Add(s);
                }
                Conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {

                throw new Exception("Ha ocurrido un error");
            }
        }
    }
}
