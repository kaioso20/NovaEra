using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NovaEra
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Sapato(object sender, RoutedEventArgs e)
        {
          windowAuxSapato wix = 
          new windowAuxSapato();
          wix.ShowDialog();
        }

        private void Button_Click_CadPJ(object sender, RoutedEventArgs e)
        {
            CadastroPJ nwPage = new CadastroPJ();
            nwPage.ShowDialog();
        }

        private void Button_Click_Venda(object sender, RoutedEventArgs e)
        {
            windowAuxVenda wix = new windowAuxVenda();
            wix.ShowDialog();
        }

        private void Button_Click_Estoque(object sender, RoutedEventArgs e)
        {
            Estoque wix = new Estoque();
            wix.ShowDialog();
        }
    }
}
