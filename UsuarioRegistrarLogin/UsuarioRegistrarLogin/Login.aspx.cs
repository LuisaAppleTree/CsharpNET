using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Web.Services.Description;

namespace UsuarioRegistrarLogin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string conectarBD = ConfigurationManager.ConnectionStrings["conexionString"].ConnectionString;
            SqlConnection sqlConectar = new SqlConnection(conectarBD);
            SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", sqlConectar)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Connection.Open();
            cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = tbCorreo.Text;
            cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = tbPassword.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Session["usuariologueado"] = tbCorreo.Text;
                Response.Redirect("Index.aspx");
                Response.Write("<script>alert('Usuario Correcto')</script>");
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectas.";
            }
            cmd.Connection.Close();


        }
    }
}