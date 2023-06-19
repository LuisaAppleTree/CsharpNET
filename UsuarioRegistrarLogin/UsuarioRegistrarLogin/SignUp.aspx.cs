using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsuarioRegistrarLogin
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text == tbConfirmarPassword.Text)
            {
                if(tbUsuario.Text.Length <=0 || tbCorreo.Text.Length <= 0 || tbPassword.Text.Length <= 0 || tbConfirmarPassword.Text.Length <= 0)
                {
                    lblWarn.Text = "Debes llenar todo el formulario.";

                }else
                {
                    string conectarBD = ConfigurationManager.ConnectionStrings["conexionString"].ConnectionString;
                    SqlConnection sqlConectar = new SqlConnection(conectarBD);
                    SqlCommand cmd = new SqlCommand("SP_AgregarUsuario", sqlConectar)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.Connection.Open();

                    cmd.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = tbUsuario.Text;
                    cmd.Parameters.Add("@Correo", SqlDbType.VarChar, 50).Value = tbCorreo.Text;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar, 50).Value = tbPassword.Text;
                    SqlDataReader dr = cmd.ExecuteReader();

                    lblWarn.Text = "Usuario Creado Correctamente.";
                    Session["usuariologueado"] = tbUsuario.Text;
                    Response.Redirect("Index.aspx");
                   
                    cmd.Connection.Close();
                }

            }
            else
            {
                lblWarn.Text = "Las contraseñas no coinciden.";
            }
        }
    }
}