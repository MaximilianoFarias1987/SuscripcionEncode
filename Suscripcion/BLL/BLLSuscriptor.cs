using DAL.Data;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSuscriptor
    {
        Conexion conexion = new Conexion();
        public static bool Insertar(Suscriptor suscriptor)
        {

            return DALSuscriptor.Insertar(suscriptor);
        }

        public static bool Editar(Suscriptor suscriptor)
        {

            return DALSuscriptor.Editar(suscriptor);
        }





        public static List<Suscriptor> listaSuscriptores(string tabla)
        {
            return DALSuscriptor.listaSuscriptores(tabla);
        }

       
    }
}
