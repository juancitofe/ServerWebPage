using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JuanFer_Servers.ASPX
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            object nombre = Session["nombre"];
            if (nombre == null)
            {
                Response.Redirect("Inicio.aspx");
            }

            lblNombreUsr.Text = Session["nombre"] + " " + Session["Apellido"];

            //Datos
            txtNombre.Text = Session["Nombre"].ToString();
            txtApellido.Text = Session["Apellido"].ToString();
            //txtCelular.Text = Session["Celular"].ToString();
            txtProvincia.Text = Session["Provincia"].ToString();
            txtCiudad.Text = Session["Ciudad"].ToString();
            txtUVenc.Text = Session["uVencimiento"].ToString();

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session["idCliente"] = null;
            Session["idEmpleado"] = null;
            Session["User"] = null;
            Session["Nombre"] = null;
            Session["Apellido"] = null;
            //Session["Celular"] = null;
            Session["Provincia"] = null;
            Session["Ciudad"] = null;
            Session["uVencimiento"] = null;
            Session["cod_subdominio"] = null;
            Session["tipoUser"] = null;
            Response.Redirect("Inicio.aspx");
        }
    }
}