using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class FacedeCor
    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public IList<Cor> RetornarLista()
        {
            return mdl.Cores.ToList();
        }
        public static bool AdicionarCor(Cor cor)
        {
            try
            {
                mdl.Cores.Add(cor);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool RemoverCor(Cor cor)
        {
            try
            {
                mdl.Cores.Remove(cor);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static Cor BuscarCorPorId(int idCor)
        {
            return mdl.Cores.Find(idCor);
        }

        public static List<Cor> RetomarLista()
        {
            return mdl.Cores.ToList();
        }
        public static bool AlterarCor(Cor cor)
        {
            try
            {
                mdl.Entry(cor).State = System.Data.Entity.EntityState.Modified;
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
