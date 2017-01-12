using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Asignacion
{
    public class FiltroEjecucionAsignacion
    {
        public int IdProcesoSeleccion { get; set; }
        public int CodigoSedeRegion { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }
        //public string CodigoNivel { get; set; }
        public string CodigoGrado { get; set; }

        public int TipoDocumento { get; set; } //DNI, Pasaporte
        public string NumeroDocumento { get; set; }
        public int IdRol { get; set; }

        public int IdDistribucion  { get; set; }
        public int IdInstitucionEducativaSigra { get; set; }
        public int TipoAsignacion { get; set; }
        public int IdSeccionSigra { get; set; }
        public int EstadoFinalEjecucion { get; set; }
        public int IdAsignacion { get; set; }

        public string Usuario { get; set; }
        
    }
}
