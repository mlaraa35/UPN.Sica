using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroReportePostulantes
    {
        public int IdOperativo { get; set; }
        public int IdProcesoSeleccion { get; set; }
        public string SedeRegion { get; set; }
        public int Cargo { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int TipoReporte { get; set; }
    }
}
