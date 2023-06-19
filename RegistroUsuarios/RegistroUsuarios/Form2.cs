using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegistroUsuarios
{
    public partial class FormRegistroUsuario : Form
    {
        public FormRegistroUsuario()
        {
            InitializeComponent();
        }

        private void textBoxRUNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRURegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter registrarUsuario = new StreamWriter(@"C:\Users\Luisa\OneDrive\Documentos\Okhosting\Capacitacion C#\RegistroUsuarios\RegistroUsuarios\bin\Debug\" + textBoxRUNombre.Text + ".txt", true);
                registrarUsuario.WriteLine(textBoxRUPassword.Text);
                registrarUsuario.Close();

                string registroExitoso = "Registro de usuario exitoso.";
                labelRURegistroExito.Text = registroExitoso;

                if (registrarUsuario != null)
                {
                    labelRURegistroExito.Show();
                }
                else
                {
                    labelRURegistroExito.Hide();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un problema: " + ex);
            }

        }

        private void labelRURegistroExito_Click(object sender, EventArgs e)
        { 

        }
    }
}
