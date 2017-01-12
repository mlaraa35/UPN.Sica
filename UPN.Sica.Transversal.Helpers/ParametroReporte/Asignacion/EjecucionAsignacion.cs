using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.ParametroReporte.Asignacion
{
    public class EjecucionAsignacion
    {
        public int IdProcesoSeleccion { get; set; }
        public int CodigoSedeRegion { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }        
        public string CodigoGrado { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Usuario { get; set; }
    }
}
