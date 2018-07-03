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
using System.Windows.Shapes;

namespace NovaEra
{
    /// <summary>
    /// Lógica interna para windowCadastrarSapato.xaml
    /// </summary>
    public partial class windowAuxSapato : Window
    {
        public windowAuxSapato()
        {
            InitializeComponent();
        }

        private void Button_Click_CadTmSapato(object sender, RoutedEventArgs e)
        {
            CadastroTamanhoSapato nwPage = new CadastroTamanhoSapato();
            nwPage.ShowDialog();
        }
        private void Button_Click_CadCorSapato(object sender, RoutedEventArgs e)
        {
            CadastroCorSapato nwPage = new CadastroCorSapato();
            nwPage.ShowDialog();
        }
        private void Button_Click_CadSapato(object sender, RoutedEventArgs e)
        {
            CadastroSapato nwPage = new CadastroSapato();
            nwPage.ShowDialog();
        }
    }
}
