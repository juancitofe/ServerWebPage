using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JuanFer_Servers.aspx
{
    public partial class editsv : System.Web.UI.Page
    {
        string conexion = "server = DESKTOP-NFK8QSO\\SQLEXPRESS; database = netfreePage ; Integrated Security = True";
        string msgError = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string cod = Request.QueryString["cod"].ToString();
                    SqlConnection conx = new SqlConnection(conexion);
                    conx.Open();
                    string query = "SELECT * FROM SERVIDORES WHERE COD_SERVIDOR = '" + cod + "'";
                    SqlCommand cmd = new SqlCommand(query, conx);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    lblCodigo.Text = cod;
                    txtCod.Text = cod;
                    txtIP.Text = dr.GetString(1);
                    txtProveedor.Text = dr.GetString(2);
                    txtPrecio.Text = dr.GetString(3);
                    txtvCPU.Text = dr.GetValue(4).ToString();
                    txtRAM.Text = dr.GetValue(5).ToString();
                    txtTransferencia.Text = dr.GetString(6);
                    txtBandwith.Text = dr.GetString(7);
                    dropSO.Text = dr.GetString(8);

                    if (Session["edit"]!=null)
                    {
                        lblMensaje.Text = "Servidor " + cod + " editado correctamente";
                        lblMensaje.CssClass = "mensaje confirmacion block";
                        Session.Remove("edit");
                    }
                }
                catch (Exception)
                {
                    Session.Add("Inexistente", Request.QueryString["cod"].ToString());
                    Response.Redirect("listaServidores.aspx");
                    throw;
                }
            }            
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string cod = Request.QueryString["cod"].ToString();
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();
            string query = "DELETE FROM SERVIDORES WHERE COD_SERVIDOR = '" + cod + "'";
            SqlCommand cmd = new SqlCommand(query, conx);
            cmd.ExecuteNonQuery();
            Session.Add("Borrado", cod);
            Response.Redirect("listaServidores.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCod.Text == "")
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

                if (msgError != "")
                {
                    lblError.Text = msgError;
                    lblError.CssClass = "mensaje error block";
                }
                else
                {
                    string vCPU = txtvCPU.Text != "" ? txtvCPU.Text : (string)"null";
                    string RAM = txtRAM.Text != "" ? txtRAM.Text : (string)"null";
                    string cod = Request.QueryString["cod"].ToString();
                    SqlConnection conx = new SqlConnection(conexion);
                    conx.Open();
                    string query = "UPDATE SERVIDORES SET cod_servidor='" + txtCod.Text + "',cod_ip='" + txtIP.Text + "',Proveedor='" + txtProveedor.Text + "',Precio='" + txtPrecio.Text + "',vCPU=" + vCPU + ",RAM=" + RAM + ",Transferencia='" + txtTransferencia.Text + "',Bandwith='" + txtBandwith.Text + "',SO='" + dropSO.SelectedValue + "' WHERE cod_servidor='" + cod + "'";
                    SqlCommand cmd = new SqlCommand(query, conx);
                    cmd.ExecuteNonQuery();
                    Session.Add("edit", true);
                    Response.Redirect("servidor.aspx?cod=" + txtCod.Text);
                }
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("pkServidorCod")) msgError += "Codigo Existente. Ingrese un Codigo distinto";
                if (ex.Message.Contains("ukServidorIP")) msgError += "IP Existente. Ingrese una IP distinta";
                lblError.Text = msgError;
                lblError.CssClass = "mensaje error block";
            }
        }
    }
}