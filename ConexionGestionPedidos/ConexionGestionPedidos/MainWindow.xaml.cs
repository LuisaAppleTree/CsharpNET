using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ConexionGestionPedidos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection miConexionSql;

        public MainWindow()
        {
            InitializeComponent();
            string miConexion = ConfigurationManager.ConnectionStrings["ConexionGestionPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            miConexionSql = new SqlConnection(miConexion);

            MuestraClientes();
            MuestraTodosPedidos();
        }

        private void MuestraClientes()
        {
            try
            {
                string consulta = "SELECT * FROM CLIENTE";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable clientesTabla = new DataTable();

                    miAdaptadorSql.Fill(clientesTabla);
                    listaClientes.DisplayMemberPath = "nombre";
                    listaClientes.SelectedValuePath = "Id";
                    listaClientes.ItemsSource = clientesTabla.DefaultView;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void MuestraPedidos()
        {
            try
            {
                string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.Id = P.cCliente WHERE C.Id = @ClienteId";

                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlComando);

                using (miAdaptadorSql)
                {
                    sqlComando.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
                    DataTable pedidosTabla = new DataTable();

                    miAdaptadorSql.Fill(pedidosTabla);
                    listaPedidosCliente.DisplayMemberPath = "fechaPedido";
                    listaPedidosCliente.SelectedValuePath = "Id";
                    listaPedidosCliente.ItemsSource = pedidosTabla.DefaultView;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void MuestraTodosPedidos()
        {
            try
            {
                string consulta = "SELECT *, CONCAT (cCliente, ' ' , fechaPedido, ' ' , formaPago) AS infoPedidoCompleta FROM PEDIDO";

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(consulta, miConexionSql);

                using (miAdaptadorSql)
                {
                    DataTable todosPedidosTabla = new DataTable();
                    miAdaptadorSql.Fill(todosPedidosTabla);
                    listaTodosPedidos.DisplayMemberPath = "infoPedidoCompleta";
                    listaTodosPedidos.SelectedValuePath = "Id";
                    listaTodosPedidos.ItemsSource = todosPedidosTabla.DefaultView;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(listaTodosPedidos.SelectedValue.ToString());
            string borrarConsulta = "DELETE FROM PEDIDO WHERE Id=@PedidoId";

            SqlCommand sqlCommand = new SqlCommand(borrarConsulta, miConexionSql);

            miConexionSql.Open();
            sqlCommand.Parameters.AddWithValue("@PedidoId", listaTodosPedidos.SelectedValue);
            sqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            MuestraTodosPedidos();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string insertarConsulta = "INSERT INTO CLIENTE (nombre) VALUES (@nombre)";

            SqlCommand sqlCommand = new SqlCommand(insertarConsulta, miConexionSql);

            miConexionSql.Open();
            sqlCommand.Parameters.AddWithValue("@nombre", insertarCliente.Text);
            sqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            MuestraClientes();

            insertarCliente.Text = " ";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string borrarConsulta = "DELETE FROM CLIENTE WHERE Id=@ClienteId";

            SqlCommand sqlCommand = new SqlCommand(borrarConsulta, miConexionSql);

            miConexionSql.Open();
            sqlCommand.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
            sqlCommand.ExecuteNonQuery();
            miConexionSql.Close();

            MuestraClientes();
        }

        private void listaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ActualizarClientes ventanaActualizar = new ActualizarClientes((int)listaClientes.SelectedValue);

            try
            {
                string consulta = "SELECT nombre FROM CLIENTE WHERE Id = @ClienteId";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSql);

                SqlDataAdapter miAdaptadorSql = new SqlDataAdapter(sqlCommand);

                using (miAdaptadorSql)
                {
                    sqlCommand.Parameters.AddWithValue("@ClienteId", listaClientes.SelectedValue);
                    DataTable clientesTabla = new DataTable();
                    miAdaptadorSql.Fill(clientesTabla);

                    ventanaActualizar.cuadroActualizar.Text = clientesTabla.Rows[0]["nombre"].ToString();
                }
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.ToString());
            }
            ventanaActualizar.ShowDialog();
            MuestraClientes();
        }

        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraClientes();
        }
    }
}
