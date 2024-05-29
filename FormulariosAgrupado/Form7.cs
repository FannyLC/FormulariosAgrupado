namespace CalculadorPasajeMetro
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Verificar si los valores ingresados son números válidos
            if (double.TryParse(txtDistance.Text, out double distance) && int.TryParse(txtDays.Text, out int days))
            {
                // Definir el precio por kilómetro
                double pricePerKm = 0.80;
                double totalPrice = distance * pricePerKm * 2; // Ida y vuelta

                // Verificar si se aplica la reducción
                if (days > 7 && distance > 800)
                {
                    totalPrice *= 0.7; // Aplicar reducción del 30%
                }

                // Mostrar el resultado
                lblResult.Text = $"El precio del pasaje de ida y vuelta es: ${totalPrice:F2}";
            }
            else
            {
                // Mostrar un mensaje de error si los valores ingresados no son válidos
                lblResult.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblDistance_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
  