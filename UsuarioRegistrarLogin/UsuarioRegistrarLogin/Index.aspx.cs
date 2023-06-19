using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace UsuarioRegistrarLogin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuariologueado"] != null)
            {
                string usuarioLogueado = Session["usuariologueado"].ToString();
                lblBienvenida.Text = " " + usuarioLogueado.Replace("@gmail.com", " ");
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

            CargarTabla();
        }

        void CargarTabla()
        {
            SqlCommand cmd = new SqlCommand("SP_MostrarProductos", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridViewTablaProductos.DataSource = dt;
            gridViewTablaProductos.DataBind();
            con.Close();
        }

        protected void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrador.aspx?op=C");
        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedRow.Cells[1].Text;
            Response.Redirect("Administrador.aspx?id=" + id + "&op=R");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedRow.Cells[1].Text;
            Response.Redirect("Administrador.aspx?id=" + id + "&op=U");
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            string id;
            Button btnConsultar = (Button)sender;
            GridViewRow selectedRow = (GridViewRow)btnConsultar.NamingContainer;
            id = selectedRow.Cells[1].Text;
            Response.Redirect("Administrador.aspx?id=" + id + "&op=D");
        }
    }
}