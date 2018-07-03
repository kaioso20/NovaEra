using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class FacedePessoaJ
    {
        private static ModelSapataria mdl = Auxiliar.Instance.ModelSapataria;
        public IList<PessoaJuridica> RetornarLista()
        {
            return mdl.pessoaJuridicas.ToList();
        }
        public static bool AdicionarPF(PessoaJuridica pj)
        {
            try
            {
                mdl.pessoaJuridicas.Add(pj);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool RemoverPJ(PessoaJuridica pj)
        {
            try
            {
                mdl.pessoaJuridicas.Remove(pj);
                mdl.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public static PessoaJuridica BuscarPJPorId(int CNPJ)
        {
            return mdl.pessoaJuridicas.Find(CNPJ);
        }
        public static bool AlterarPJ(PessoaJuridica pj)
        {
            try
            {
                mdl.Entry(pj).State = System.Data.Entity.EntityState.Modified;
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
