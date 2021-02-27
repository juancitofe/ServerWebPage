using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace JuanFer_Servers
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Session["idCliente"] = null;
            Session["idEmpleado"] = null;
            Session["User"] = null;
            Session["Nombre"] = null;
            Session["Apellido"] = null;
            Session["Celular"] = null;
            Session["Provincia"] = null;
            Session["Ciudad"] = null;
            Session["uVencimiento"] = null;
            Session["cod_subdominio"] = null;
            Session["tipoUser"] = null;
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}