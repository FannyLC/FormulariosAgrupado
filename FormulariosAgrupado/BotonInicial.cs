using Calculadora;
using CalculadorPasajeMetro;
using Comparar_numeros;

namespace FormulariosAgrupado
{
    public partial class BotonInicial : Form
    {
        public BotonInicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
