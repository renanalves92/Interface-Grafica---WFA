private void btnConverter_Click(object sender, EventArgs e)
{
    try
    {
        // Obter o valor da TextBox
        double milhasMaritimas = Convert.ToDouble(txtMilhas.Text);

        // Instanciar o objeto Conversor
        Conversor conversor = new Conversor();

        // Realizar a conversão
        double quilometros = conversor.ConverterMilhasParaQuilometros(milhasMaritimas);

        // Exibir o resultado
        lblResultado.Text = $"Km: {quilometros:F2}";
    }
    catch (FormatException)
    {
        MessageBox.Show("Por favor, insira um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
