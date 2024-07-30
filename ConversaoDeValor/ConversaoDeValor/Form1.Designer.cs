namespace ConversaoDeValor
{
    partial class frmCalculoCotacaoDolar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoCotacaoDolar));
            lblNomeProduto = new Label();
            lblValorProd = new Label();
            lblCotacao = new Label();
            txtNomeProduto = new TextBox();
            txtValorDolar = new TextBox();
            txtCotacao = new TextBox();
            btnCalculo = new Button();
            lblResultadoConversao = new Label();
            SuspendLayout();
            // 
            // lblNomeProduto
            // 
            lblNomeProduto.AutoSize = true;
            lblNomeProduto.Location = new Point(137, 69);
            lblNomeProduto.Name = "lblNomeProduto";
            lblNomeProduto.Size = new Size(103, 15);
            lblNomeProduto.TabIndex = 0;
            lblNomeProduto.Text = "Nome do Produto";
            // 
            // lblValorProd
            // 
            lblValorProd.AutoSize = true;
            lblValorProd.Location = new Point(137, 166);
            lblValorProd.Name = "lblValorProd";
            lblValorProd.Size = new Size(96, 15);
            lblValorProd.TabIndex = 1;
            lblValorProd.Text = "Valor do Produto";
            // 
            // lblCotacao
            // 
            lblCotacao.AutoSize = true;
            lblCotacao.Location = new Point(137, 253);
            lblCotacao.Name = "lblCotacao";
            lblCotacao.Size = new Size(99, 15);
            lblCotacao.TabIndex = 2;
            lblCotacao.Text = "Cotação do Dólar";
            // 
            // txtNomeProduto
            // 
            txtNomeProduto.Location = new Point(246, 61);
            txtNomeProduto.Name = "txtNomeProduto";
            txtNomeProduto.Size = new Size(171, 23);
            txtNomeProduto.TabIndex = 3;
            // 
            // txtValorDolar
            // 
            txtValorDolar.Location = new Point(246, 158);
            txtValorDolar.Name = "txtValorDolar";
            txtValorDolar.Size = new Size(171, 23);
            txtValorDolar.TabIndex = 4;
            // 
            // txtCotacao
            // 
            txtCotacao.Location = new Point(246, 250);
            txtCotacao.Name = "txtCotacao";
            txtCotacao.Size = new Size(171, 23);
            txtCotacao.TabIndex = 5;
            // 
            // btnCalculo
            // 
            btnCalculo.Location = new Point(246, 346);
            btnCalculo.Name = "btnCalculo";
            btnCalculo.Size = new Size(171, 23);
            btnCalculo.TabIndex = 6;
            btnCalculo.Text = "Calcular o valor do produto";
            btnCalculo.UseVisualStyleBackColor = true;
            btnCalculo.Click += btnCalculo_Click;
            // 
            // lblResultadoConversao
            // 
            lblResultadoConversao.AutoSize = true;
            lblResultadoConversao.BackColor = SystemColors.AppWorkspace;
            lblResultadoConversao.Location = new Point(246, 309);
            lblResultadoConversao.Name = "lblResultadoConversao";
            lblResultadoConversao.Size = new Size(0, 15);
            lblResultadoConversao.TabIndex = 7;
            // 
            // frmCalculoCotacaoDolar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultadoConversao);
            Controls.Add(btnCalculo);
            Controls.Add(txtCotacao);
            Controls.Add(txtValorDolar);
            Controls.Add(txtNomeProduto);
            Controls.Add(lblCotacao);
            Controls.Add(lblValorProd);
            Controls.Add(lblNomeProduto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmCalculoCotacaoDolar";
            Text = "Conversão Dólar em Real";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNomeProduto;
        private Label lblValorProd;
        private Label lblCotacao;
        private TextBox txtNomeProduto;
        private TextBox txtValorDolar;
        private TextBox txtCotacao;
        private Button btnCalculo;
        private Label lblResultadoConversao;
    }
}