namespace AulaPratica
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblOpEsquerdo_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int opEsq = int.Parse(txtOpEsq.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int opDrt = int.Parse(txtOpDrt.Text);
        }

        private void rdoSoma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtOpEsq.Text, out double opEsq) &&
                double.TryParse(txtOpDrt.Text, out double opDrt))
            {
                if (rdSoma.Checked)
                    txtResultado.Text = (opEsq + opDrt).ToString();

                else if (rdSubtracao.Checked)
                    txtResultado.Text = (opEsq - opDrt).ToString();

                else if (rdMultiplicacao.Checked)
                    txtResultado.Text = (opEsq * opDrt).ToString();

                else if (rdDivisao.Checked)
                {
                    if (opDrt != 0)
                        txtResultado.Text = (opEsq / opDrt).ToString();
                    else
                        txtResultado.Text = "Erro: Divisão por zero!";
                }
            }
            else
            {
                txtResultado.Text = "Erro: Insira números válidos.";
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
