using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class FacedePessoaF
    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public IList<PessoaFisica> RetornarLista()
        {
            return mdl.pessoaFisicas.ToList();
        }
        public static bool AdicionarPF(PessoaFisica pf)
        {
            try
            {
                mdl.pessoaFisicas.Add(pf);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool RemoverPF(PessoaFisica pf)
        {
            try
            {
                mdl.pessoaFisicas.Remove(pf);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static PessoaFisica BuscarPFPorId(int CPF)
        {
            return mdl.pessoaFisicas.Find(CPF);
        }
        public static bool AlterarPF(PessoaFisica pf)
        {
            try
            {
                mdl.Entry(pf).State = System.Data.Entity.EntityState.Modified;
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
