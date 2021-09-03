using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class Conexion
    {
        public static SqlConnection conexion;
        public static SqlTransaction transaction;
        private static SqlCommand cmd;
        private  SqlDataReader dr = null;

        public  SqlDataReader Dr { get => dr; set => dr = value; }
        public  static SqlCommand Cmd { get => cmd; set => cmd = value; }

        public Conexion()
        {
            conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["connDb"].ConnectionString);
            Cmd = new SqlCommand();
            
        }

        

        //TRANSACCIONES
        public static void BeginTransaction()
        {
            int TimeOut = 36;
            while ( conexion != null)
            {
                Thread.Sleep(250);
                TimeOut--;

                if (TimeOut == 0)
                {
                    RollbackTransaction();
                }
            }
            
        }

        //COMMIT

        public static void CommitTransaction()
        {
            transaction.Commit();
            transaction.Dispose();
            conexion.Dispose();
            conexion = null;
        }

        //ROLLBACK
        public static void RollbackTransaction()
        {
            transaction.Rollback();
            transaction.Dispose();
            conexion.Dispose();
            conexion = null;
        }

        public void Leer(string tabla)
        {
            AbrirConexion();
            Cmd.CommandText = "select * from " + tabla;
            Dr = Cmd.ExecuteReader(); 
        }


        public bool ValidarSuscripcion(string tipoDoc, int numDoc)
        {

            AbrirConexion();
            Cmd.CommandText = "select * from Suscriptor s join Suscripcion su on s.IdSuscriptor = su.IdSuscriptor where s.TipoDocumento  = '"+tipoDoc+"' and s.NumeroDocumento = "+numDoc+"";
            Dr = Cmd.ExecuteReader();
            
            if (Dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool ValidarSuscriptor(string tipoDoc, int numDoc)
        {

            AbrirConexion();
            Cmd.CommandText = "select * from Suscriptor where TipoDocumento  = '" + tipoDoc + "' and NumeroDocumento = " + numDoc + "";
            Dr = Cmd.ExecuteReader();

            if (Dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void AbrirConexion()
        {
            conexion.Open();
            cmd.Connection = conexion;
        }


        public static void CerrarConexion()
        {
            conexion.Close();
        }
    }
}
