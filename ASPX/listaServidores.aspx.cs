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
        }

        protected void gridServidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string indice = gridServidores.SelectedDataKey.Value.ToString();
            Response.Write("Indice: " + indice);
            // gridServidores.SelectedIndex.ToString();*/
        }
    }
}