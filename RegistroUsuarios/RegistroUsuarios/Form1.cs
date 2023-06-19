using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroUsuarios
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            this.Hide();
           FormRegistroUsuario ventanaInicioSesion = new FormRegistroUsuario();
            ventanaInicioSesion.Show();
        }

        private void buttonCrearCuenta_Paint(object sender, PaintEventArgs e)
        {   
        }
    }
}
