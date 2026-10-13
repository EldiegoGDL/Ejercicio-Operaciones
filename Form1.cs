namespace Ejercicio_Operaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbOperaciones.Items.Add("Suma");
            this.cmbOperaciones.Items.Add("Resta");
            this.cmbOperaciones.Items.Add("División");
            this.cmbOperaciones.Items.Add("Multiplicación");
            // el valor por defecto es "Suma" si no se selecciona ninguna operación
            cmbOperaciones.SelectedItem = "Suma";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string operacion = this.cmbOperaciones.SelectedItem?.ToString();
            decimal resultado = 0;
            switch (operacion)
            {
                case "Suma":
                    if (string.IsNullOrEmpty(this.txtNum1.Text) || string.IsNullOrEmpty(this.txtNum2.Text))
                    {
                        MessageBox.Show("Ingrese ambos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    resultado = decimal.Parse(this.txtNum1.Text) + decimal.Parse(this.txtNum2.Text);
                    break;
                case "Resta":
                    if (string.IsNullOrEmpty(this.txtNum1.Text) || string.IsNullOrEmpty(this.txtNum2.Text))
                    {
                        MessageBox.Show("Ingrese ambos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    resultado = decimal.Parse(this.txtNum1.Text) - decimal.Parse(this.txtNum2.Text);
                    break;
                case "División":
                    if (string.IsNullOrEmpty(this.txtNum1.Text) || string.IsNullOrEmpty(this.txtNum2.Text))
                    {
                        MessageBox.Show("Ingrese ambos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    if (string.IsNullOrEmpty(this.txtNum2.Text) || decimal.Parse(this.txtNum2.Text) == 0)
                    {
                        MessageBox.Show("No se puede dividir por cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    resultado = decimal.Parse(this.txtNum1.Text) / decimal.Parse(this.txtNum2.Text);
                    break;
                case "Multiplicación":
                    if (string.IsNullOrEmpty(this.txtNum1.Text) || string.IsNullOrEmpty(this.txtNum2.Text))
                    {
                        MessageBox.Show("Ingrese ambos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    resultado = decimal.Parse(this.txtNum1.Text) * decimal.Parse(this.txtNum2.Text);
                    break;
                case null:
                    MessageBox.Show("Seleccione una operación VALIDA!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
            }
            this.txtResultado.Text = resultado.ToString();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, el punto decimal y la tecla de retroceso
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        
    }
}
