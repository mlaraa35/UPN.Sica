using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Asignacion
{
    public class FiltroUSPSelAsignacionIIEEPostulantesProceso : Object
    {
        public int IdProcesoSeleccion { get; set; }        
        public int CodigoSedeProvinciaDistrito { get; set; }
        public string CodigoNivel { get; set; }
        public string CodigoGrado { get; set; }
    }
}
