using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JuanFer_Servers
{
    public partial class master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["nombre"] != null)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "perfil", "perfil()", true);
            }

            if (Session["tipoUser"] != null)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "panel", "panel()", true);
            }
        }
    }
}