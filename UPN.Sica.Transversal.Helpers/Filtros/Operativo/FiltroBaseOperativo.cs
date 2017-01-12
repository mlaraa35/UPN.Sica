using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroBaseOperativo
    {
        public int? IdOperativo { get; set; }
        public int? IdOperacion{ get; set; }
        public bool? EsExcel { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
