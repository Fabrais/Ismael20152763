using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculadoraDePrestamos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vrPrestamo, vrInteres, anios, monto;
            String cadena = "";

            vrPrestamo = Convert.ToDouble(txtPrestamo.Text);
            vrInteres = Convert.ToDouble(txtInteres.Text);
            anios = Convert.ToDouble(mmAnios.Value);

            for (int i = 1; i<= anios; i++) {
                monto = (vrPrestamo * (1 + (vrInteres / 100) * i)) ;
                cadena += (i + "\t" + string.Format("{0:C}", monto + "\r\n"));
            }
            txtResultado.Text = cadena;
        }

        private void txtPrestamo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
