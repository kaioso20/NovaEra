using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    [Table("Sapatos")]
    public class Sapato
    {
        [Key]
        public int idSapato { get; set; }
        public int tamanho { get; set; }
        public string cor { get; set; }
        public String Nome { get; set; }
        public String material { get; set; }
        public Boolean cadarco { get; set; }
        public Decimal preco { get; set; }

    }
}
