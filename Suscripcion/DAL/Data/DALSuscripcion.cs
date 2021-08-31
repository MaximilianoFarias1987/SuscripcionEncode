﻿using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public class DALSuscripcion
    {
        //Insertar

        public static bool Insertar(Suscripcion suscripcion)
        {
            //Conexion con = new Conexion();
            //Conexion.BeginTransaction();
            //SqlCommand Cmd = new SqlCommand();
            try
            {
                string nombreSP = "sp_InsertarSuscripcion";
                Conexion.AbrirConexion();
                Conexion.Cmd.CommandType = CommandType.StoredProcedure;
                Conexion.Cmd.CommandText = nombreSP;
                Conexion.Cmd.Parameters.AddWithValue("@IdSuscriptor", suscripcion.IdSuscriptor);
                Conexion.Cmd.ExecuteNonQuery();
                Conexion.Cmd.Parameters.Clear();

                //Conexion.CommitTransaction();
                return true;
                
            }
            catch (Exception)
            {
                Conexion.RollbackTransaction();
                return false;
            }
            finally
            {
                Conexion.CerrarConexion();
            }
            
            
            
        }


        //VALIDAR SUSCRIPCION
        public static bool ValidarSuscripcion(string tipoDoc, int numDoc)
        {
            try
            {
                Conexion conexion = new Conexion();
                Conexion.CerrarConexion();
                return conexion.ValidarSuscripcion(tipoDoc, numDoc);
                
                
            }
            catch (Exception e)
            {
                //return false;
                throw new Exception("Ha ocurrido un error" + e.Message);

            }
        }
    }
}
