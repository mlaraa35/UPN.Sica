using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroOperativo : FiltroBaseOperativo
    {
        //public int? IdOperativo  { get; set; }
        public string CodigoOperativo { get; set; }
        public string NombreOperativo { get; set; }
        public int? EstadoOperativo { get; set; }
        //public bool? EsExcel { get; set; }
    }
}
