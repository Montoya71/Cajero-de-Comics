using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

         public void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            string textoN1;
            string textoN2;
            int N1;
            int N2;
            int Resultado;

            textoN1 = txtPrecio.Text;
            textoN2 = txtCantidad.Text;
            N1 = Convert.ToInt32(textoN1);
            N2 = Convert.ToInt32(textoN2);
            Resultado = N1 * N2;

            txtTotal.Text = Resultado.ToString();
        }

        public void btnResta_Click(object sender, EventArgs e)
        {
            string textoN3;
            string textoN4;
            float N3;
            float N4;
            float Resultado2;
            float Resultado3;
            float Resultado4;
            double V = 0.16;

            textoN3 = txtTotal.Text;
            textoN4 = txtRecibido.Text;
            N3 = Convert.ToInt32(txtTotal.Text);
            N4 = Convert.ToInt32(txtRecibido.Text);

            Resultado2 = N4 - N3;
            Resultado3 = (float)(Resultado2 * V);
            Resultado4 = Resultado2 - Resultado3;

            txtCambio.Text = Resultado4.ToString();
        }

           
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
