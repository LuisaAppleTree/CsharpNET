using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorPropinas
{
    public partial class FormCalculadoraPropinas : Form
    {
        public FormCalculadoraPropinas()
        {
            InitializeComponent();
            comboBoxPorcentajeProps.Items.Add("10");
            comboBoxPorcentajeProps.Items.Add("20");
            comboBoxPorcentajeProps.Items.Add("30");
            comboBoxPorcentajeProps.Items.Add("40");
            comboBoxPorcentajeProps.Items.Add("50");
            comboBoxPorcentajeProps.Items.Add("60");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsPunctuation(e.KeyChar)) 
            { 
                e.Handled = true;
            }
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double monto;
            monto = double.Parse(textBoxMonto.Text.ToString());

            int porcentajeProp = int.Parse(comboBoxPorcentajeProps.SelectedItem.ToString());


            double calcularPrecioFinal (double costo, int porcentaje) {
                double dinero;
                dinero = ((costo * porcentaje) / 100) + costo;
                labelDinero.Text = dinero.ToString("C2");
                return dinero;
            }
            calcularPrecioFinal(monto, porcentajeProp);
        }

        private void FormCalculadoraPropinas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
