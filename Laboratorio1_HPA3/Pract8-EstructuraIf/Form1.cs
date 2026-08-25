using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract8_EstructuraIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdbSuma_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSuma.Checked) lblSimbolo.Text = "+";
        }

        private void rdbResta_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbResta.Checked) lblSimbolo.Text = "-";
        }

        private void rdbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbMultiplicacion.Checked) lblSimbolo.Text = "*";
        }

        private void rdbDivision_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDivision.Checked) lblSimbolo.Text = "/";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = 0;
            double num2 = 0;
            double resultado = 0;

            // Validar que se ingresen números válidos en ambos campos
            if (!double.TryParse(txtValor1.Text, out num1) || !double.TryParse(txtValor2.Text, out num2))
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en ambos campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Estructura IF para decidir la operación matemática
            if (rdbSuma.Checked)
            {
                resultado = num1 + num2;
            }
            else if (rdbResta.Checked)
            {
                resultado = num1 - num2;
            }
            else if (rdbMultiplicacion.Checked)
            {
                resultado = num1 * num2;
            }
            else if (rdbDivision.Checked)
            {
                // Validación especial: no se puede dividir entre cero
                if (num2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero.", "Error Matemático", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtResultado.Text = "Error";
                    return;
                }
                resultado = num1 / num2;
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una operación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mostrar el resultado final en la pantalla
            txtResultado.Text = resultado.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor1.Text = "";
            txtValor2.Text = "";
            txtResultado.Text = "";
            rdbSuma.Checked = true; // Deja seleccionada la suma por defecto
            lblSimbolo.Text = "+";

        }
    }
}
