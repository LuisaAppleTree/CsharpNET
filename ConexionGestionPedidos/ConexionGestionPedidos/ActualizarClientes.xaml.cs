using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Configuration;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para ActualizarClientes.xaml
    /// </summary>
    public partial class ActualizarClientes : Window
    {
        SqlConnection miConexionSql;

        private int IdCliente;
        public ActualizarClientes(int idCliente)
        {
            InitializeComponent();

            IdCliente = idCliente;
            
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string insertarConsulta = "UPDATE CLIENTE SET nombre = @nombre WHERE Id =" + IdCliente;

            SqlCommand sqlCommand = new SqlCommand(insertarConsulta, miConexionSql);

            miConexionSql.Open();
            sqlCommand.Parameters.AddWithValue("@nombre", cuadroActualizar.Text);
            sqlCommand.ExecuteNonQuery();
            miConexionSql.Close();
            this.Close();
        }
    }
}
