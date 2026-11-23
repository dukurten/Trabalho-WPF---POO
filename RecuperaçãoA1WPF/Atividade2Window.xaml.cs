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

public partial class Atividade2Window : Window
{
    public Atividade2Window() => InitializeComponent();

    private void Calcular_Click(object sender, RoutedEventArgs e)
    {
        var cultura = CultureInfo.GetCultureInfo("pt-BR");
        if (!decimal.TryParse(Nota1TextBox.Text, NumberStyles.Number, cultura, out decimal nota1) ||
            !decimal.TryParse(Nota2TextBox.Text, NumberStyles.Number, cultura, out decimal nota2))
        {
            MessageBox.Show("Informe duas notas válidas usando números, por exemplo: 8,5.", "Atenção",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }
        if (nota1 < 0 || nota1 > 10 || nota2 < 0 || nota2 > 10)
        {
            MessageBox.Show("As notas devem estar entre 0 e 10.", "Atenção",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        decimal media = (nota1 * 4m + nota2 * 6m) / 10m;
        ResultadoTextBlock.Text = $"Média ponderada: {media.ToString("N2", cultura)}";
    }
}