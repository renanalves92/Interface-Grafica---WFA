private void btnConverter_Click(object sender, EventArgs e)
{
    try
    {
        // Obter valores das TextBoxes
        double cotacaoDolar = Convert.ToDouble(txtCotacao.Text);
        double quantidadeDolares = Convert.ToDouble(txtQuantidade.Text);

        // Instanciar o objeto ConversorMoeda
        ConversorMoeda conversor = new ConversorMoeda(cotacaoDolar, quantidadeDolares);

        // Calcular o valor em reais
        double valorEmReais = conversor.ConverterParaReais();

        // Exibir o resultado
        lblResultado.Text = $"Reais: R$ {valorEmReais:F2}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
