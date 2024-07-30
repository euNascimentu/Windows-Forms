using System.Net.Http.Headers;

namespace ConversaoDeValor
{
    public partial class frmCalculoCotacaoDolar : Form
    {
        public frmCalculoCotacaoDolar()
        {
            InitializeComponent();
        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {


            if (txtNomeProduto.Text != String.Empty
                && txtCotacao.Text != String.Empty
                && txtValorDolar.Text != String.Empty)
            {
                if (double.Parse(txtValorDolar.Text) >= 0
                    && double.Parse(txtCotacao.Text) >= 0)
                {
                    //Variáveis
                    double valorProdutoDolar = double.Parse(txtValorDolar.Text);
                    double valorCotacao = double.Parse(txtCotacao.Text);
                    string nomeProduto = txtNomeProduto.Text;
                    double valorProdutoReal;

                    //Cálculo
                    valorProdutoReal = valorProdutoDolar * valorCotacao;

                    lblResultadoConversao.Text =
                    //Template String
                    $"O valor do produto {nomeProduto} em Real é: {valorProdutoReal.ToString("n2")}";

                }
                else
                {
                    MessageBox.Show("Preencha com valores POSITIVOS!");
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os dados corretamente!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}