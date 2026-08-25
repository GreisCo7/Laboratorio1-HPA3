using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controles_Nuevo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // mensaje indicando el cierre
            MessageBox.Show("Se cerrará la ventana");

            this.Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // Validación
            if (string.IsNullOrWhiteSpace(txtDia.Text) ||
                string.IsNullOrWhiteSpace(txtMes.Text) ||
                string.IsNullOrWhiteSpace(txtAnio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos (Día, Mes y Año).", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            lblResultado.Text = "La fecha es: " + txtDia.Text + " " + txtMes.Text + " " + txtAnio.Text;

        }
    }
}
