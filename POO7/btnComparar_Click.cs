private void btnComparar_Click(object sender, EventArgs e)
{
    try
    {
        // Obter valores das TextBoxes
        double valor1 = Convert.ToDouble(txtValor1.Text);
        double valor2 = Convert.ToDouble(txtValor2.Text);

        // Instanciar o objeto Comparador
        Comparador comparador = new Comparador();

        // Comparar os valores
        double maiorValor = comparador.ObterMaior(valor1, valor2);

        // Exibir o resultado
        lblResultado.Text = $"Resultado: O maior valor é {maiorValor}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, insira valores numéricos válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
