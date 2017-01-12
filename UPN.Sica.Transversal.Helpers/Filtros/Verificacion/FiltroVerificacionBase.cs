using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Verificacion
{
    public class FiltroVerificacionBase
    {
        public int? IdProcesoSeleccion { get; set; }
        public string CodigoSedeRegion { get; set; }
        public string CodigoSedeProvinciaDistrito { get; set; }
        public int? TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public bool EsExcel { get; set; }
    }
}
