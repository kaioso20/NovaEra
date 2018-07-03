using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class FacedeEstoque
    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public IList<Cor> RetornarListaCor()
        {
            return mdl.Cores.ToList();
        }
        public IList<Sapato> RetornarListaSapatos()
        {
            return mdl.Sapatos.ToList();
        }
        public IList<Tamanho> RetornarListaTamanho()
        {
            return mdl.Tamanhos.ToList();
        }
    }
}
