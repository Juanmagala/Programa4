using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_PROG3
{   
    public partial class Ejercicio2_1 : System.Web.UI.Page
    {
        public SqlConnection cnNeptuno = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True");
       
        protected void Page_Load(object sender, EventArgs e)
        {
            string consultasql = "select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad " +
                                 "from productos";

            if(!IsPostBack)
            {
                cargarGridView(consultasql, cnNeptuno);
            }
        }

        public void cargarGridView(string consulta, SqlConnection cnNeptuno)
        {
            SqlCommand cmd = new SqlCommand(consulta, cnNeptuno);
            cnNeptuno.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            grdProductos.DataSource = dr;
            grdProductos.DataBind();
            cnNeptuno.Close();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string consultasql = "select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from productos ";
            if (txtCategoria.Text.Trim()=="" && txtProducto.Text.Trim()!="")
            {
                consultasql += "where IdProducto" + ddlProducto.SelectedValue + txtProducto.Text.Trim();
                cargarGridView(consultasql, cnNeptuno);
            } 
            else if(txtCategoria.Text.Trim() != "" && txtProducto.Text.Trim() == "")
            {
                consultasql += "where IdCategoría" + ddlCategoria.SelectedValue + txtCategoria.Text.Trim();
                cargarGridView(consultasql, cnNeptuno);
            }
            else if(txtCategoria.Text.Trim() != "" && txtProducto.Text.Trim() != "")
            {
                consultasql += "where IdProducto" + ddlProducto.SelectedValue + txtProducto.Text.Trim() +
                               "and IdCategoría" + ddlCategoria.SelectedValue + txtCategoria.Text.Trim();
                cargarGridView(consultasql, cnNeptuno);
            }
            else
            {
                cargarGridView(consultasql, cnNeptuno);
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            txtCategoria.Text = "";
            txtProducto.Text = "";
            ddlCategoria.SelectedIndex = 0;
            ddlProducto.SelectedIndex = 0;

            string consultasql = "select IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad from productos";
            cargarGridView(consultasql, cnNeptuno);
        }
    }
}