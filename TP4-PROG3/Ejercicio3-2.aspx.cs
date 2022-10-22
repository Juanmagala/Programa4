using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_PROG3
{
    public partial class Ejercicio3_2 : System.Web.UI.Page
    {
        public SqlConnection cnLibreria = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
                string tema= Request["tem"];
                string consultasql = "select * from Libros where IdTema = " +tema;
                SqlCommand cmd = new SqlCommand(consultasql, cnLibreria);
                cnLibreria.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                grdLibros.DataSource = dr;
                grdLibros.DataBind();
                cnLibreria.Close();            
        }

        protected void lbtnConsultarTema_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ejercicio3-1.aspx");
        }
    }
}