using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    [Table("PessoaFisica")]
    public class PessoaFisica : Cliente
    {
        public Boolean Ativo { get; set; }

        PessoaFisica()
        {
            this.Ativo = true;
        }

    }
}
