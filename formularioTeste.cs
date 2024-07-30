namespace WinFormsAula
{
    public partial class frmPrimeiroPrograma : Form
    {
        public frmPrimeiroPrograma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //Declarando variáveis
            string nome;
            int idade;

            //Atribuindo valores das caixas de texto para as variáveis
            nome = txtNome.Text;
            idade = int.Parse(txtIdade.Text);

            lblMensagem.Text = "Seu nome é " + nome + ". Sua idade é: " + idade;

            //Se for maior que 30 "Você tem mais de 30 anos, senão você tem menos de 30 anos"

            if (idade >= 30)
                lblMensagemIf.Text = "Você tem MAIS de 30 anos.";
            else
                lblMensagemIf.Text = "Você tem MENOS de 30 anos.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMensagemIf_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtIdade.Clear();
            txtNome.Clear();
            lblMensagem.Text = "";
            lblMensagemIf.Text = "";
            txtNome.Focus(); //Leva o cursor para a caixa de texto
        }
    }
}