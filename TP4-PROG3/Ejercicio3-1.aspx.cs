using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_PROG3
{
    public partial class Ejercicio3_1 : System.Web.UI.Page
    {
        public SqlConnection cnLibreria = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True");
        
        protected void CargarLibros()
        {
            string consultasql = "select * from Temas";
            cnLibreria.Open();
            ddlTemas.DataSource = obtenerTemas(consultasql, cnLibreria);
            ddlTemas.DataTextField = "Tema";
            ddlTemas.DataValueField = "IdTema";
            ddlTemas.DataBind();

            ddlTemas.Items.Insert(0, new ListItem("Seleccione un tema", "-1"));

            cnLibreria.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                CargarLibros();
            } 
        }

        public SqlDataReader obtenerTemas(string consulta, SqlConnection cnLibreria)
        {
            SqlCommand cmd = new SqlCommand(consulta, cnLibreria);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        protected void lbtnVerLibros_Click(object sender, EventArgs e)
        {
            if(ddlTemas.SelectedIndex!=0)
            {
                lblError.Visible = false;
                Response.Redirect("Ejercicio3-2.aspx?tem=" + ddlTemas.SelectedValue);
            }   
            else
            {
                lblError.Visible = true;
            }
        }
    }
}