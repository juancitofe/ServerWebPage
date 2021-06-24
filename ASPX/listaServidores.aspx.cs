using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JuanFer_Servers.ASPX
{
    public partial class listaServidores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUser"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
            gridServidores.HeaderRow.TableSection = TableRowSection.TableHeader;

            if (Session["Borrado"] != null)
            {
                lblMensaje.Text = "Servidor " + Session["Borrado"] + " eliminado correctamente";                
                lblMensaje.CssClass = "mensaje confirmacion block";                
                Session.Remove("Borrado");
            }   
            else lblMensaje.CssClass = "nodisplay";

            if (Session["Inexistente"] != null)
            {
                lblMensaje.Text = "No existe el servidor " + Session["Inexistente"];                
                lblMensaje.CssClass = "mensaje error block";                
                Session.Remove("Inexistente");
            }
            else lblMensaje.CssClass = "nodisplay";
        }

        protected void gridServidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = gridServidores.SelectedDataKey.Value.ToString();
            Response.Write("Codigo: " + codigo);
            Response.Redirect("servidor.aspx?cod=" + codigo);
        }
    }
}