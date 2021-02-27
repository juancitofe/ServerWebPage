using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JuanFer_Servers
{
    public partial class listaClientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUser"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
            gridClientes.HeaderRow.TableSection = TableRowSection.TableHeader;
        }


        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            //Declarar Variables
            string filtro = txtBuscar.Text.ToUpper();

            /*Recorrer todas las filas de la tabla y oculte aquellas que no
            coincidan con la consulta de búsqueda*/
            int cant_filas = gridClientes.Rows.Count;
            for (int i = 0; i < cant_filas; i++)
            {
                string nombre = gridClientes.Rows[i].Cells[1].Text;
                if (nombre.ToUpper().IndexOf(filtro) > -1)
                {
                    gridClientes.Rows[i].CssClass = "";
                }
                else
                {

                    gridClientes.Rows[i].CssClass = "nodisplay";
                }
            }


        }
    }
}