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
    /// Lógica interna para CadastroCorSapato.xaml
    /// </summary>
    public partial class CadastroCorSapato : Window
    {
        private BibliotecaModalSapataria.Cor _CorSelecionada = new BibliotecaModalSapataria.Cor();
        public BibliotecaModalSapataria.Cor CorSelecionada
        {
            get
            {
                return _CorSelecionada;
            }
            set
            {
                _CorSelecionada = value;
                this.NotifyPropertyChanged("CorSelecionada");
            }
        }
       
        private ICollection<Cor> _Cores;

        public ICollection<Cor> Cores
        {
            get { return _Cores; }
            set
            {
                _Cores = value;
                this.NotifyPropertyChanged("Cores");
            }
        }
        

        private void NotifyPropertyChanged(string v)
        {
            //throw new NotImplementedException();
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

       

        public CadastroCorSapato()
        {
            InitializeComponent();

            this.DataContext = this;

            BibliotecaModalSapataria.FacedeCor facade = new BibliotecaModalSapataria.FacedeCor();
            this.Cores = facade.RetornarLista();
        }

        private void Button_ClickOK(object sender, RoutedEventArgs e)
        {

            Cor cor = new Cor
            {
                cor = Nome.Text
            };
            try
            {
                if (FacedeCor.AdicionarCor(cor))
                {
                    MessageBox.Show("Adicionou Cor!");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Deu ruim Cor");
            }
        }
      //  private void Button_ClickRemove(object sender, RoutedEventArgs e)
       // {
            //FacedeCor.RemoverCor(cor)
       // }
    }
}
