using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class Auxiliar
    {
        private static readonly Auxiliar instance = new Auxiliar();
        private readonly ModelSapataria modelSapataria;

        private Auxiliar()
        {
            modelSapataria = new ModelSapataria();
        }

        public static Auxiliar Instance
        {
            get
            {
                return instance;
            }
        }

        public ModelSapataria ModelSapataria
        {
            get
            {
                return modelSapataria;
            }
        }
    }
}
