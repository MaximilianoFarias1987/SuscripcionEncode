using SuscripcionEncode.App_Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SuscripcionEncode.Entidades
{
    public class Suscripcion
    {
        Conexion con = new Conexion();
        public int IdAsociacion { get; set; }
        public int IdSuscriptor { get; set; }
        public Suscriptor suscriptor { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime? FechaFin { get; set; }
        public string MotivoFin { get; set; }





        //Insertar

        public void Insertar(Suscripcion suscripcion)
        {
            string nombreSP = "sp_InsertarSuscripcion";
            con.AbrirConexion();
            con.Cmd.CommandType = CommandType.StoredProcedure;
            con.Cmd.CommandText = nombreSP;
            con.Cmd.Parameters.AddWithValue("@IdSuscriptor", suscripcion.IdSuscriptor);
            con.Cmd.ExecuteNonQuery();
            con.Cmd.Parameters.Clear();
            con.CerrarConexion();
        }

    }
}