using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    [Table("Tamanhos")]
    public class Tamanho
    {
        [Key]
        public int idTamanho { get; set; }
        public int tamanho { get; set; }
    }
}
