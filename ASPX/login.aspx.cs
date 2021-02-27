using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JuanFer_Servers.ASPX
{
    public partial class login : System.Web.UI.Page
    {
        string conexion = "server = DESKTOP-NFK8QSO\\SQLEXPRESS; database = netfreePage ; Integrated Security = True";
        protected void Page_Load(object sender, EventArgs e)
        {
            object nombre = Session["nombre"];
            if (nombre != null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void loginClick(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();
            string query = "select * from Cliente where usuario = '" + txtUser.Text + "' and contraseña = '" + txtPass.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conx);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Session["idCliente"] = dr.GetValue(0);
                Session["user"] = dr.GetValue(1);
                Session["nombre"] = dr.GetValue(3);
                Session["apellido"] = dr.GetValue(4);
                //Session["Celular"] = dr.GetValue(5);
                Session["Provincia"] = dr.GetValue(5);
                Session["Ciudad"] = dr.GetValue(6);
                Session["uVencimiento"] = dr.GetValue(7);
                Session["idEmpleado"] = dr.GetValue(8);
                Session["cod_subdominio"] = dr.GetValue(9);
                Response.Redirect("Inicio.aspx");
            }
            else
            {
                Response.Write("Incorrecto");
            }
        }
    }
}