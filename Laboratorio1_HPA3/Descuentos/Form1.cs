using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Descuentos
{
    public partial class Descuento : Form
    {
        public Descuento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Variables para los cálculos numéricos
            decimal ValorVentas = 0;
            decimal DescuentoPorcentaje = 0;
            decimal DescuentoVentas = 0;
            decimal VentasTotales = 0;

            // Validamos si el usuario ingresó un número válido en la caja de texto
            if (!decimal.TryParse(txtVventa.Text, out ValorVentas))
            {
                MessageBox.Show("Por favor, ingrese un valor de venta válido.", "Error de ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detiene el código si está vacío o no es un número
            }

            // Estructura de condiciones según las reglas del problema
            if (ValorVentas >= 500)
            {
                DescuentoPorcentaje = 0.30m; // 30%
            }
            else if (ValorVentas >= 300 && ValorVentas <= 499)
            {
                DescuentoPorcentaje = 0.20m; // 20%
            }
            else if (ValorVentas >= 100 && ValorVentas <= 299)
            {
                DescuentoPorcentaje = 0.10m; // 10%
            }
            else
            {
                DescuentoPorcentaje = 0; // Sin descuento si es menor a 100
            }

            // Operaciones matemáticas
            DescuentoVentas = ValorVentas * DescuentoPorcentaje;
            VentasTotales = ValorVentas - DescuentoVentas;

            // Mostrar los resultados en las cajas de texto correspondientes
            txtDescuento1.Text = (DescuentoPorcentaje * 100).ToString() + "%";
            txtDescuento2.Text = DescuentoVentas.ToString("F2");
            txtVfinal.Text = VentasTotales.ToString("F2");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVventa.Text = "";
            txtDescuento1.Text = "";
            txtDescuento2.Text = "";
            txtVfinal.Text = "";

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A continuación se cerrará la aplicación", "Cerrar Aplicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
