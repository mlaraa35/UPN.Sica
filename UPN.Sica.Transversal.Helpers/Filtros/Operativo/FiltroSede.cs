using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroSede : FiltroBaseOperativo
    {
        //public int? IdOperativo { get; set; }
        public string CodigoSedePadre { get; set; }
        public string NombreSede { get; set; }
        public string NombreSedeHijo { get; set; }
        public int? IdSede { get; set; }
        public int? TipoSede { get; set; }
        public string Usuario { get; set; }
        //public bool EsExcel { get; set; }
    }
}
