using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JuanFer_Servers.ASPX
{
    public partial class agregarCliente : System.Web.UI.Page
    {
        string conexion = "server = DESKTOP-NFK8QSO\\SQLEXPRESS; database = netfreePage ; Integrated Security = True";
        string msgError = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUser"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                msgError += "Por favor ingrese un Nombre<br>";
            }

            if (txtApellido.Text == "")
            {
                msgError += "Por favor ingrese un Apellido<br>";
            }

            if (msgError!="")
            {
                lblError.Text = msgError;
                lblError.CssClass = "mensaje error block";
                lblConfirmacion.CssClass = "mensaje confirmacion nodisplay";
            } else {        
                SqlConnection conx = new SqlConnection(conexion);
                conx.Open();
                string query = "insert into Cliente values('" + txtUser.Text + "','" + txtPass.Text + "','" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtProvincia.Text + "','" + txtCiudad.Text + "','" + txtVencimiento.Text + "','" + Session["idEmpleado"].ToString() + "','" + dropSubdominio.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.ExecuteNonQuery();
                conx.Close();

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtProvincia.Text = "";
                txtCiudad.Text = "";
                txtVencimiento.Text = "";
                dropSubdominio.ClearSelection();
                txtUser.Text = "";
                txtPass.Text = "";

                lblError.CssClass = "mensaje error nodisplay";
                lblConfirmacion.CssClass = "mensaje confirmacion block";
            }
        }
    }
}