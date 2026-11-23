using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;


namespace RecuperaçãoA1WPF;

public partial class Atividade1Window : Window
{
    public Atividade1Window() => InitializeComponent();

    private void Calcular_Click(object sender, RoutedEventArgs e)
    {
        var cultura = CultureInfo.GetCultureInfo("pt-BR");
        var texto = SalarioTextBox.Text.Trim();
        if (!decimal.TryParse(texto, NumberStyles.Currency, cultura, out decimal salario) &&
            !decimal.TryParse(texto.Replace(',', '.'), NumberStyles.Number, CultureInfo.InvariantCulture, out salario))
        {
            MessageBox.Show("Informe um salário-base válido.", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
            SalarioTextBox.Focus();
            return;
        }
        if (salario < 0)
        {
            MessageBox.Show("O salário não pode ser negativo.", "Atenção", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        if (PercentualComboBox.SelectedItem is not ComboBoxItem item ||
            !decimal.TryParse(item.Tag?.ToString(), out decimal percentual))
        {
            MessageBox.Show("Selecione um percentual de bonificação.");
            return;
        }

        decimal bonificacao = salario * percentual / 100m;
        decimal salarioFinal = salario + bonificacao;
        BonificacaoTextBlock.Text = $"Bonificação: {bonificacao.ToString("C2", cultura)}";
        SalarioFinalTextBlock.Text = $"Salário final: {salarioFinal.ToString("C2", cultura)}";
    }
}
