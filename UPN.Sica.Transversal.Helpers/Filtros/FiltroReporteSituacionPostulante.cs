using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroReporteSituacionPostulante
    {
        public int IdRol { get; set; }
        public int TipoEtapa { get; set; }
        public int IdProcesoSeleccion { get; set; }
        public string NumeroDocumento { get; set; }
        public int TipoDocumento { get; set; }
        public int IdSede { get; set; }
        public string CodigoSedePadre { get; set; }
    }
}
