namespace Calculo_Pagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculoSalario calculo = new CalculoSalario();

            calculo.CPF = txtCpf.Text;
            calculo.Nome = txtNome.Text;
            calculo.Valor = Convert.ToDouble(txtValor.Text);
            calculo.Horas = Convert.ToDouble(txtHoras.Text);

            calculo.CalcularSalario();

            txtSalario.Text = calculo.Salario.ToString();
        }
    }
}