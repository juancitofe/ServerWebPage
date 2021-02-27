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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUser"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();
            string query = "insert into Servidores values ('" + txtCodigo.Text + "','" + txtIP.Text + "','" + txtProveedor.Text + "','" + txtPrecio.Text + "'," + (txtvCPU.Text) + "," + txtRAM.Text + ",'" + txtTransferencia.Text + "','" + txtBandwith.Text + "','" + dropSO.SelectedValue + "')";
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
        }
    }
}