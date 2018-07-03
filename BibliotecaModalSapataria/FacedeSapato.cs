using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class FacedeSapato

    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public IList<Sapato> RetornarLista()
        {
           return mdl.Sapatos.ToList();
        }

        public static bool AdicionarSapato(Sapato sapato)
        {
            try
            {
                mdl.Sapatos.Add(sapato);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool RemoverSapato (Sapato sapato)
        {
            try
            {
                mdl.Sapatos.Remove(sapato);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static Sapato BuscarSapatoPorId(int idSapato)
        {
            return mdl.Sapatos.Find(idSapato);
        }
        public static bool AlterarSapato (Sapato sapato)
        {
            try
            {
                mdl.Entry(sapato).State = System.Data.Entity.EntityState.Modified;
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
