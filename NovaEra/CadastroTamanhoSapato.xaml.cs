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
using BibliotecaModalSapataria;

namespace NovaEra
{
    /// <summary>
    /// Lógica interna para CadastroTamanhoSapato.xaml
    /// </summary>
    public partial class CadastroTamanhoSapato : Window
    {
        private BibliotecaModalSapataria.Tamanho _Tamanho = new BibliotecaModalSapataria.Tamanho();
        public BibliotecaModalSapataria.Tamanho CorSelecionada
        {
            get
            {
                return _Tamanho;
            }
            set
            {
                _Tamanho = value;
                this.NotifyPropertyChanged("TamanhoSelecionado");
            }
        }

        private void NotifyPropertyChanged(string v)
        {
            throw new NotImplementedException();
        }

        public Boolean ModoCriacaoTime { get; set; } = false;

        public Visibility VisibilidadeDataGrid
        {
            get
            {
                if (ModoCriacaoTime)
                {
                    return Visibility.Hidden;
                }
                else
                {
                    return Visibility.Visible;
                }
            }
        }

        public IList<BibliotecaModalSapataria.Tamanho> Tamanhos { get; set; }


        public CadastroTamanhoSapato()
        {
            InitializeComponent();

            this.DataContext = this;

            BibliotecaModalSapataria.FacedeTamanho facede = new BibliotecaModalSapataria.FacedeTamanho();
            this.Tamanhos = facede.RetornarLista();
        }

        private void Button_ClickOK(object sender, RoutedEventArgs e)
        {

            Tamanho tamanho = new Tamanho
            {
                tamanho = Int32.Parse(Tamanho.Text)
            };
            try
            {
                if (FacedeTamanho.AdicionarTamanho(tamanho))
                {
                    MessageBox.Show("Adicionou Tamanho!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Deu ruim Tamanho");
            }
        }
    }
}
