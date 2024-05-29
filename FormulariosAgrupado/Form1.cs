namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variables
        string operador = "";
        double num1 = 0;
        double num2 = 0;


        private void txtborrar_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";

        }

        private void txteliminar_Click(object sender, EventArgs e)
        {
            if (txtscreen.TextLength == 1) txtscreen.Text = "0";
            else txtscreen.Text = txtscreen.Text.Substring(0, txtscreen.Text.Length - 1);
        }

        private void txtuno_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "1";
        }

        private void txtdos_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "2";
        }

        private void txttres_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "3";
        }

        private void txtcuatro_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "4";
        }

        private void txtcinco_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "5";
        }

        private void txtseis_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "6";
        }

        private void txtsiete_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "7";
        }

        private void txtocho_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "8";
        }

        private void txtnueve_Click(object sender, EventArgs e)
        {
            if (txtscreen.Text == "0") txtscreen.Text = "";
            else
                txtscreen.Text = txtscreen.Text + "9";
        }

        private void t_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text + "0";
        }

        private void txtpunto_Click(object sender, EventArgs e)
        {
             txtscreen.Text = txtscreen.Text  + ",";
        }

        private void txtmas_Click(object sender, EventArgs e)
        {
            operador = "+";
            num1 = Convert.ToDouble(txtscreen.Text);
            txtscreen.Text = "0";

        }

        private void txtmenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            num1 = Convert.ToDouble(txtscreen.Text);
            txtscreen.Text = "0";
        }

        private void txtpor_Click(object sender, EventArgs e)
        {
            operador = "*";
            num1 = Convert.ToDouble(txtscreen.Text);
            txtscreen.Text = "0";
        }

        private void txtentre_Click(object sender, EventArgs e)
        {
            operador = "/";
            num1 = Convert.ToDouble(txtscreen.Text);
            txtscreen.Text = "0";
        }

        private void txtigual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtscreen.Text);

            switch (operador)
            {
                case "+":
                    txtscreen.Text = $"{num1 + num2}";
                    break;
                case "-":
                    txtscreen.Text = $"{num1 - num2}";
                    break;
                case "*":
                    txtscreen.Text = $"{num1 * num2}";
                    break;
                case "/":
                    txtscreen.Text = $"{num1 / num2}";
                    break;
            }
        }
    }
}
