using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MED.Sigra.Transversal.Helpers.Filtros.Evaluacion;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroCobertura : FiltroBaseEvaluacion
    {
        public int IdProcesoSeleccion { get; set; }
        public int IdSedeProcesoSeleccion { get; set; }
        public int TipoEtapa { get; set; }
        public string SedeRegion { get; set; }
        public string SedeProvincia { get; set; }
        public int TipoReporte { get; set; }
        public string CodigoGrado { get; set; }
        public string CodigoNivel { get; set; }
        public int EstadoFinal { get; set; }
        
    }
}
