﻿using System;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["tipoUser"] == null)
            {
                Response.Redirect("Inicio.aspx");
            }
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
            SqlConnection conx = new SqlConnection(conexion);
            conx.Open();
            string query = "SELECT FORMAT(uVencimiento, 'dd/mm/yyyy') from Cliente";
            SqlCommand cmd = new SqlCommand(query, conx);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            //string nombre = dr.GetValue(0).ToString();
            string uVenc = dr.GetValue(0).ToString();
            //txtNombre.Text = nombre;
            txtFecha.Text = uVenc;
            conx.Close();
        }
    }
}