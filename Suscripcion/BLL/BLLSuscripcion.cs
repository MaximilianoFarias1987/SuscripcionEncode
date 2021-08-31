using DAL.Data;
using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLSuscripcion
    {
        public static bool Insertar(Suscripcion suscripcion)
        {
            return DALSuscripcion.Insertar(suscripcion);
        }


        public static bool ValidarSuscripcion(string tipoDoc, int numDoc)
        {

            
            return DALSuscripcion.ValidarSuscripcion(tipoDoc, numDoc); ;
        }
    }
}
