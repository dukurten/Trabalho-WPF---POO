using RecuperaçãoA1WPF;
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

namespace RecuperaçãoA1WPF;

public partial class MainWindow : Window
{
    public MainWindow() => InitializeComponent();

    private void Atividade1_Click(object sender, RoutedEventArgs e) =>
        new Atividade1Window { Owner = this }.ShowDialog();

    private void Atividade2_Click(object sender, RoutedEventArgs e) =>
        new Atividade2Window { Owner = this }.ShowDialog();

    private void Sobre_Click(object sender, RoutedEventArgs e) =>
        new SobreWindow { Owner = this }.ShowDialog();

    private void Sair_Click(object sender, RoutedEventArgs e) => Application.Current.Shutdown();
}
