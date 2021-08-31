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
                Conexion.Cmd.Parameters.AddWithValue("@Password", suscriptor.Contrasena);
                Conexion.Cmd.ExecuteNonQuery();
                Conexion.Cmd.Parameters.Clear();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            
            
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
                Conexion.Cmd.Parameters.AddWithValue("@Password", suscriptor.Contrasena);
                Conexion.Cmd.ExecuteNonQuery();
                Conexion.Cmd.Parameters.Clear();
                return true;
            }
            catch (Exception)
            {

                return true;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            
            
        }



        //public static Suscriptor CrearObjeto()
        //{
        //    Conexion conexion = new Conexion();

        //    Suscriptor s = new Suscriptor();
        //    if (!conexion.Dr.IsDBNull(0))
        //    {
        //        s.IdSuscriptor = conexion.Dr.GetInt32(0);
        //    }
        //    if (!conexion.Dr.IsDBNull(1))
        //    {
        //        s.Nombre = conexion.Dr.GetString(1);
        //    }
        //    if (!conexion.Dr.IsDBNull(2))
        //    {
        //        s.Apellido = conexion.Dr.GetString(2);
        //    }
        //    if (!conexion.Dr.IsDBNull(3))
        //    {
        //        s.Documento = conexion.Dr.GetInt32(3);
        //    }
        //    if (!conexion.Dr.IsDBNull(4))
        //    {
        //        s.TipoDocumento = conexion.Dr.GetString(4);
        //    }
        //    if (!conexion.Dr.IsDBNull(5))
        //    {
        //        s.Direccion = conexion.Dr.GetString(5);
        //    }
        //    if (!conexion.Dr.IsDBNull(6))
        //    {
        //        s.Telefono = conexion.Dr.GetString(6);
        //    }
        //    if (!conexion.Dr.IsDBNull(7))
        //    {
        //        s.Email = conexion.Dr.GetString(7);
        //    }
        //    if (!conexion.Dr.IsDBNull(8))
        //    {
        //        s.NombreUsuario = conexion.Dr.GetString(8);
        //    }
        //    if (!conexion.Dr.IsDBNull(9))
        //    {
        //        s.Contrasena = conexion.Dr.GetString(9);
        //    }
        //    return s;
        //}


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
                    s = new Suscriptor();
                    if (!conexion.Dr.IsDBNull(0))
                    {
                        s.IdSuscriptor = conexion.Dr.GetInt32(0);
                    }
                    if (!conexion.Dr.IsDBNull(1))
                    {
                        s.Nombre = conexion.Dr.GetString(1);
                    }
                    if (!conexion.Dr.IsDBNull(2))
                    {
                        s.Apellido = conexion.Dr.GetString(2);
                    }
                    if (!conexion.Dr.IsDBNull(3))
                    {
                        s.Documento = conexion.Dr.GetInt32(3);
                    }
                    if (!conexion.Dr.IsDBNull(4))
                    {
                        s.TipoDocumento = conexion.Dr.GetString(4);
                    }
                    if (!conexion.Dr.IsDBNull(5))
                    {
                        s.Direccion = conexion.Dr.GetString(5);
                    }
                    if (!conexion.Dr.IsDBNull(6))
                    {
                        s.Telefono = conexion.Dr.GetString(6);
                    }
                    if (!conexion.Dr.IsDBNull(7))
                    {
                        s.Email = conexion.Dr.GetString(7);
                    }
                    if (!conexion.Dr.IsDBNull(8))
                    {
                        s.NombreUsuario = conexion.Dr.GetString(8);
                    }
                    if (!conexion.Dr.IsDBNull(9))
                    {
                        s.Contrasena = conexion.Dr.GetString(9);
                    }
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
