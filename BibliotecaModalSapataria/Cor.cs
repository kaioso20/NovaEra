using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    [Table("Cores")]
    public class Cor
    {
        [Key]
        public int idCor { get; set; }
        public string cor { get; set; }
    }
}
