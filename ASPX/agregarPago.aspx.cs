using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace JuanFer_Servers.ASPX
{
    public partial class agregarPago : System.Web.UI.Page
    {
        string conexion = "server = DESKTOP-NFK8QSO\\SQLEXPRESS; database = netfreePage ; Integrated Security = True";
        int idCliente; 
        int precio;
        int promo;
        int dispositivos;
        string tiempo;


        protected void Page_Load(object sender, EventArgs e)
        {
            /*if (Session["tipoUser"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }*/
        }

        protected void infoServicio()
        {
            string cod_serv = dropServicio.SelectedValue;
            //BD
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();
            string query = "SELECT * FROM Servicio WHERE '" + cod_serv + "' LIKE cod_servicio";
            SqlCommand cmd = new SqlCommand(query, conx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            precio = dr.GetInt32(3);
            tiempo = dr.GetString(4);
        }

        protected void promocion()
        {
            switch (dropPromo.SelectedValue)
            {
                case "Ninguna":
                    promo = 0;
                    break;

                case "2x500":
                    promo = ((dispositivos / 2) * 100);
                    break;
            }
        }

        protected void cantDispositivos()
        {
            if (txtCantDisp.Text == "")
            {
                dispositivos = 1;
            }
            else
            {
                dispositivos = Convert.ToInt32(txtCantDisp.Text);
            }
        }

        protected void calcularPrecioFinal()
        {
            infoServicio();
            cantDispositivos();
            promocion();
            txtPrecioFinal.Text = (dispositivos * precio - promo).ToString();
        }

        protected void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            listClientes.Items.Clear();
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();
            string query = "SELECT id AS #, CONCAT(Nombre,' ',Apellido) AS 'Nombre y Apellido' , Ciudad, FORMAT(uVencimiento, 'dd/mm/yy') AS Vencimiento  FROM Cliente WHERE (CONCAT(Nombre,' ',Apellido) LIKE '%" + txtBuscar.Text + "%') and (Nombre <> '')";
            SqlCommand cmd = new SqlCommand(query, conx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string texto = dr.GetInt32(0).ToString() + "  |  " + dr.GetString(1) + "  |  " + dr.GetString(2) + "  |  " + dr.GetString(3);
                listClientes.Items.Add(texto);
            }
            calcularPrecioFinal();
        }

        protected void btnCalendar_Click(object sender, EventArgs e)
        {
            if (calendarPago.CssClass == "nodisplay")
            {
                calendarPago.CssClass = "";
            }
            else
            {
                calendarPago.CssClass = "nodisplay";
            }

        }

        protected void calendarPago_SelectionChanged(object sender, EventArgs e)
        {
            txtFecha.Text = calendarPago.SelectedDate.Date.ToShortDateString();
        }

        protected void listClientes_SelectedIndexChanged(object sender, EventArgs e)
        {            
            //Conseguir los datos del usuario
            string cliente = listClientes.SelectedValue;

            int separador1 = cliente.IndexOf('|', 0);
            int separador2 = cliente.IndexOf('|', separador1+1);
            int separador3 = cliente.IndexOf('|', separador2+1);

            string id = cliente.Substring(0, separador1-1).Trim();
            string NyA = cliente.Substring(separador1+1, separador2-separador1-1).Trim();
            string ciudad = cliente.Substring(separador2+1, separador3-separador2-1).Trim();
            string uVenc = cliente.Substring(separador3+1).Trim();

            txtNombre.Text = NyA;
            txtFecha.Text = uVenc;

            idCliente = Convert.ToInt32(id);

        }
      
        protected void txtCantDisp_TextChanged(object sender, EventArgs e)
        {            
            calcularPrecioFinal();
        }

        protected void dropServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPrecioFinal();
        }
        protected void dropPromo_SelectedIndexChanged(object sender, EventArgs e)
        {
            calcularPrecioFinal();
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            calcularPrecioFinal();
            //Cantidad de Tiempo
            int cantTiempo = Convert.ToInt32(tiempo.Substring(0, tiempo.Length - 1));
            DateTime fecVenc = Convert.ToDateTime(txtFecha.Text).AddMonths(1);
            switch (tiempo.Substring(tiempo.Length-1,1))
            {
                case "M":
                    fecVenc = Convert.ToDateTime(txtFecha.Text).AddMonths(cantTiempo);
                    break;
                case "D":
                    fecVenc = Convert.ToDateTime(txtFecha.Text).AddDays(cantTiempo);
                    break;
            }
            //Recibido
            string recibido;
            if (chkRecibido.Checked)
            {
                recibido = "SI";
            }
            else
            {
                recibido = "NO";
            }

            //BD Insert
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();//Hacer enteros a los que son enteros , ver BD
            string query = "INSERT INTO Detalle VALUES(" + dispositivos + ",'" + txtFecha.Text + "','" + fecVenc + "','GETDATE()','" + idCliente + "','" + Session["idEmpleado"] + "','" + dropPago.SelectedValue + "','" + dropPromo.SelectedValue + "','" + txtPrecioFinal.Text + "','" + dropServicio.SelectedValue + "','" + recibido + "')";
            SqlCommand cmd = new SqlCommand(query, conx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conx.Close();
        }
        
    }
}