using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cajero_automatico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            double[] denominaciones = { 100, 50, 20, 10, 5, 1, 0.50, 0.25, 0.1, 0.05, 0.01 };
            double cantidad = double.Parse(txtcantidad.Text);
            SByte n = 0; /* contador */
            String respuesta = "Respuesta: \n";

            /* Recorrer todos los valores en las dominaciones */

            foreach (double denominacion in denominaciones)
            {

                while (denominacion <= Math.Round (cantidad, 2)) {
                    n++;

                    cantidad -= denominacion;

                }

                if (n > 0)
                {
                    respuesta += n + (denominacion > 1 ? "Billete" : "Monedas") + denominacion + "\n";

                }
                n = 0;

            }
            lblrespuesta.Text = respuesta;

        }
    }
}
