using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comparar_numeros
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonComparar_Click(object sender, EventArgs e)
        { // Obtener los valores introducidos por el usuario
            string textoNumero1 = textBoxNumero1.Text;
            string textoNumero2 = textBoxNumero2.Text;

            // Intentar convertir los textos a números
            if (double.TryParse(textoNumero1, out double numero1) && double.TryParse(textoNumero2, out double numero2))
            {
                // Comparar los números y mostrar el mensaje correspondiente
                if (numero1 > numero2)
                {
                    labelResultado.Text = "El primer número es el mayor.";
                }
                else if (numero1 < numero2)
                {
                    labelResultado.Text = "El primer número es el más pequeño.";
                }
                else
                {
                    labelResultado.Text = "Ambos números son iguales.";
                }
            }
            else
            {
                labelResultado.Text = "Por favor, introduce números válidos.";
            }
        }
    }
}