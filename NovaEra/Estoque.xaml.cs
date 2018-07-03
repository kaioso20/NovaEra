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
    /// Lógica interna para Estoque.xaml
    /// </summary>
    public partial class Estoque : Window
    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public Estoque()
        {
            InitializeComponent();
            this.DataContext = this;

            BibliotecaModalSapataria.FacedeEstoque facade = new BibliotecaModalSapataria.FacedeEstoque();
            //this.
        }
    }
}
