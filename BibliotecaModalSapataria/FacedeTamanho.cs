using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class FacedeTamanho
    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public IList<Tamanho> RetornarLista()
        {
            return mdl.Tamanhos.ToList();
        }

        public static List<Tamanho> RetomarLista()
        {
            return mdl.Tamanhos.ToList();
        }

        public static bool AdicionarTamanho(Tamanho tamanho)
        {
            try
            {
                mdl.Tamanhos.Add(tamanho);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool RemoverTamanho(Tamanho tamanho)
        {
            try
            {
                mdl.Tamanhos.Remove(tamanho);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static Tamanho BuscarSapatoPorId(int idTamanho)
        {
            return mdl.Tamanhos.Find(idTamanho);
        }
        public static bool AlterarTamanho(Tamanho tamanho)
        {
            try
            {
                mdl.Entry(tamanho).State = System.Data.Entity.EntityState.Modified;
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
}
}

