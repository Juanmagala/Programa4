using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP4_PROG3
{
    public partial class Ejercicio1_1 : System.Web.UI.Page
    {
        public SqlConnection cnViajes =new SqlConnection( "Data Source=localhost\\sqlexpress;Initial Catalog=Viajes;Integrated Security=True");

        public SqlDataReader obtenerDatosProvincias(string consulta, SqlConnection cnViajes)
        {
            SqlCommand cmd1 = new SqlCommand(consulta, cnViajes);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            return dr1;
        }

        public void cargarProvInicio()
        {
            string consulta1sql = "select * from provincias";
            cnViajes.Open();
            ddlProvInicio.DataSource = obtenerDatosProvincias(consulta1sql, cnViajes);
            ddlProvInicio.DataTextField = "NombreProvincia";
            ddlProvInicio.DataValueField = "IdProvincia";
            ddlProvInicio.DataBind();

            ddlProvInicio.Items.Insert(0, new ListItem("Seleccione una provincia", "-1"));
            ddlProvFinal.Items.Insert(0, new ListItem("Seleccione una provincia", "-1"));
            ddlLocalidadInicio.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));
            ddlLocalidadFinal.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));


            cnViajes.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {    
            if(!IsPostBack)
            {
                cargarProvInicio();
            }
        }

        public void cargarProvFinal()
        {
            string consulta1sql = "select * from provincias where IdProvincia<>" + ddlProvInicio.SelectedValue;
            cnViajes.Open();

            ddlProvFinal.DataSource = obtenerDatosProvincias(consulta1sql, cnViajes);
            ddlProvFinal.DataTextField = "NombreProvincia";
            ddlProvFinal.DataValueField = "IdProvincia";
            ddlProvFinal.DataBind();

            ddlProvFinal.Items.Insert(0, new ListItem("Seleccione una provincia", "-1"));
            ddlLocalidadFinal.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));

            cnViajes.Close();
        }

        public SqlDataReader obtenerDatosLocalidades(string consulta, SqlConnection cnViajes)
        {
            SqlCommand cmd2 = new SqlCommand(consulta, cnViajes);
            SqlDataReader dr2 = cmd2.ExecuteReader();

            return dr2;
        }

        protected void ddlProvInicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlLocalidadFinal.Items.Clear();

            string consulta2sql = "select * from Localidades where IdProvincia=" + ddlProvInicio.SelectedValue;

            cnViajes.Open();

            ddlLocalidadInicio.DataSource = obtenerDatosLocalidades(consulta2sql, cnViajes);
            ddlLocalidadInicio.DataTextField = "NombreLocalidad";
            ddlLocalidadInicio.DataValueField = "IdLocalidad";
            ddlLocalidadInicio.DataBind();
            ddlLocalidadInicio.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));

            cnViajes.Close();

            cargarProvFinal();

            ddlLocalidadFinal.SelectedIndex = 0;
        }

        protected void ddlProvFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string consulta2sql = "select * from Localidades where IdProvincia=" + ddlProvFinal.SelectedValue;

            cnViajes.Open();

            ddlLocalidadFinal.DataSource = obtenerDatosLocalidades(consulta2sql, cnViajes);
            ddlLocalidadFinal.DataTextField = "NombreLocalidad";
            ddlLocalidadFinal.DataValueField = "IdLocalidad";
            ddlLocalidadFinal.DataBind();
            ddlLocalidadFinal.Items.Insert(0, new ListItem("Seleccione una localidad", "-1"));

            cnViajes.Close();
        }
    }
}
