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
    /// Lógica interna para CadastroSapato.xaml
    /// </summary>
    public partial class CadastroSapato : Window
    {
        private ICollection<Sapato> _Sapato;
        private ICollection<Cor> _Cores;
        private Sapato _SapatoSelecionado;

        public Sapato SapatoSelecionado
        {
            get
            {
                return _SapatoSelecionado;
            }
            set
            {
                _SapatoSelecionado = value;
                this.NotifyPropertyChanged("SapatoSelecionado");
            }
        }
        public ICollection<Sapato> Sapatos
        {
            get
            {
                return _Sapato;
            }
            set
            {
                _Sapato = value;
                this.NotifyPropertyChanged("Sapatos");
            }
        }

        private ICollection<Cor> Cores {
            get
            {
                return _Cores;
            }
            set
            {
                this._Cores = value;
                NotifyPropertyChanged("Cores");
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
        

        public CadastroSapato()
        {
            InitializeComponent();

            this.DataContext = this;

            BibliotecaModalSapataria.FacedeSapato facade = new BibliotecaModalSapataria.FacedeSapato();
            this.Sapatos = facade.RetornarLista();
        }

        private void CadastrarBtn(object sender, RoutedEventArgs e)
        {
            int idCor = (int) cboCor.SelectedValue;
            Cor corSelec = FacedeCor.BuscarCorPorId(idCor);
            int idTamanho = (int) cboTamanho.SelectedValue;
            Tamanho tamanhoSelec = FacedeTamanho.BuscarSapatoPorId(idTamanho);


            var auxCadarço = false;
            if (Cadarco_sim.IsChecked == true)
            {
                auxCadarço = true;
            }
            else if (Cadarco_nao.IsChecked == true)
            {
                auxCadarço = false;
            }

            Sapato sapato = new Sapato

            {
                Nome = NomeSapato.Text,
                cadarco = auxCadarço,
                cor = corSelec.cor,
                tamanho = tamanhoSelec.tamanho,
                material = NomeTamanho.Text,
                preco = Decimal.Parse(CampoPreco.Text)

            };

            try
            {
                if (FacedeSapato.AdicionarSapato(sapato))
                {
                    MessageBox.Show("Adicionou Sapato!");
                }
                else
                {
                    MessageBox.Show("Não foi possível cadastrar o sapato!");
                }
            }
            catch (Exception)
            {             
            }
        }

       
     


        private void Windows_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
               from cor in FacedeCor.RetomarLista()
               where cor.idCor != 0
               orderby cor.cor
               select  cor ;
            cboCor.ItemsSource = query.ToList();

            var queryy =
               from tamanho in FacedeTamanho.RetomarLista()
               where tamanho.idTamanho != 0
               orderby tamanho.tamanho
               select tamanho;
            cboTamanho.ItemsSource = queryy.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sapato sapato = new Sapato();

            int idSapato = SapatoSelecionado.idSapato;

            sapato = FacedeSapato.BuscarSapatoPorId(idSapato);

            if (FacedeSapato.RemoverSapato(sapato))
            {
                MessageBox.Show("Sapato excluido com sucessso!");
            }
            else
            {
                MessageBox.Show("Erro ao deletar o sapato!");
            }
        }
    }
}