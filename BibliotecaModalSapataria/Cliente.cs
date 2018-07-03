using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public abstract class Cliente
    {
        [Key]
        public int idCliente { get; set; }
        public String Nome { get; set; }
    }
}
