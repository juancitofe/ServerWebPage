using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JuanFer_Servers
{
    public partial class agregarServidor : System.Web.UI.Page
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
            if (txtCodigo.Text == "")
            {
                msgError += "Ingrese un Codigo para el Servidor<br>";
            }

            if (txtIP.Text == "")
            {
                msgError += "Ingrese la IP del Servidor<br>";
            }

            if (txtProveedor.Text == "")
            {
                msgError += "Ingrese el Nombre del Proveedor<br>";
            }

            if (msgError!="")
            {
                lblError.Text = msgError;
                lblError.CssClass = "mensaje error block";
                lblConfirmacion.CssClass = "mensaje confirmacion nodisplay";
            } else {
                string vCPU = txtvCPU.Text != "" ? txtvCPU.Text : (string)"null";
                string RAM = txtRAM.Text != "" ? txtRAM.Text : (string)"null";
                SqlConnection conx = new SqlConnection(conexion);
                conx.Open();
                string query = "insert into Servidores values ('" + txtCodigo.Text + "','" + txtIP.Text + "','" + txtProveedor.Text + "','" + txtPrecio.Text + "'," + vCPU + "," + RAM + ",'" + txtTransferencia.Text + "','" + txtBandwith.Text + "','" + dropSO.SelectedValue + "')";
                SqlCommand cmd = new SqlCommand(query, conx);
                cmd.ExecuteNonQuery();

                txtCodigo.Text = "";
                txtIP.Text = "";
                txtProveedor.Text = "";
                txtPrecio.Text = "";
                txtvCPU.Text = "";
                txtRAM.Text = "";
                txtTransferencia.Text = "";
                txtBandwith.Text = "";
                dropSO.ClearSelection();

                lblError.CssClass = "mensaje error nodisplay";
                lblConfirmacion.CssClass = "mensaje confirmacion block";
            }
        }
    }
}