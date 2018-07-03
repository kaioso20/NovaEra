using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaModalSapataria
{
    public class ItensSapato
    {
        [Key]
        public int idItensSapato { get; set; }
        public Int32 quantidade { get; set; }
        public Sapato sapato { get; set; }
        

    }
}
