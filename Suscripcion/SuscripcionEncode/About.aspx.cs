using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SuscripcionEncode
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                CargarTabla();
            }
            
        }

        private void CargarTabla()
        {
            List<Suscriptor> lista = BLL.BLLSuscriptor.listaSuscriptores("Suscriptor");

            
            dtgSuscriptor.DataSource = BLL.BLLSuscriptor.listaSuscriptores("Suscriptor");
            dtgSuscriptor.DataBind();
        }
    }
}