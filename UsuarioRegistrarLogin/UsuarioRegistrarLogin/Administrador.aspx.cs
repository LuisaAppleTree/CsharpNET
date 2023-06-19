using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UsuarioRegistrarLogin
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionString"].ConnectionString);
        public static string sID = "-1";
        public static string sOpcion = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            //obtener el ID
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    sID = Request.QueryString["id"].ToString();
                    CargarDatos();
                }

                if (Request.QueryString["op"]!= null)
                {
                    sOpcion = Request.QueryString["op"].ToString();

                    switch (sOpcion)
                    {
                        case "C":
                            this.lblTitulo.Text = "Agregar nuevo producto";
                            this.btnCreate.Visible = true;
                            break;
                        case "R":
                            this.lblTitulo.Text = "Busqueda de producto";
                            break;
                        case "U":
                            this.lblTitulo.Text = "Modificar Producto";
                            this.btnUpdate.Visible = true;
                            break;
                        case "D":
                            this.lblTitulo.Text = "Eliminar producto";
                            this.btnDelete.Visible = true;
                            break;
                    }
                }
            }
        }

        void CargarDatos()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SP_BuscarProducto", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@IDProducto", SqlDbType.Int).Value = sID;
            DataSet ds = new DataSet();
            ds.Clear();
            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            DataRow row = dt.Rows[0];
            tbNombreProducto.Text = row[1].ToString();
            tbDescripcion.Text = row[2].ToString();
            tbPrecio.Text = row[3].ToString();
            con.Close();
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_CR_RegistrarProductos",con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre_Producto", SqlDbType.NVarChar).Value = tbNombreProducto.Text;
            cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
            cmd.Parameters.Add("@Precio", SqlDbType.Money).Value = tbPrecio.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Index.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_U_ModificarProducto", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDProducto", SqlDbType.Int).Value = sID;
            cmd.Parameters.Add("@Nombre_Producto", SqlDbType.NVarChar).Value = tbNombreProducto.Text;
            cmd.Parameters.Add("@Descripcion", SqlDbType.NVarChar).Value = tbDescripcion.Text;
            cmd.Parameters.Add("@Precio", SqlDbType.Money).Value = tbPrecio.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Index.aspx");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SP_BorrarProducto", con);
            con.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@IDProducto", SqlDbType.Int).Value = sID;
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("Index.aspx");
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Index.aspx");
        }
    }
}