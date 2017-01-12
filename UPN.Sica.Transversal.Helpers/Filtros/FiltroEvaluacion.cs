using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MED.Sigra.Transversal.Helpers.Filtros.Evaluacion;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroEvaluacion : FiltroBaseEvaluacion
    {
        public int IdProcesoSeleccion { get; set; } 
        public string SedeRegion { get; set; }
        public string SedeProvincia { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }
        public string UwvCodigoGrado { get; set; }
        public int? TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; } 
        public int Ambito { get; set; }
        public int IdAsignacion { get; set; } 

        
    }
}
