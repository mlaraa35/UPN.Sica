using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MED.Sigra.Transversal.Helpers.Filtros.Evaluacion;

namespace MED.Sigra.Transversal.Helpers.Filtros.Capacitacion
{
    public class FiltroComunCargaProceso
    {
        public int IdProcesoSeleccion { get; set; }
        //public int IdSede { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int CodigoSedeRegion { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public int IdLocalSigra { get; set; }
        public int IdTipoLocal { get;set; }
        public int IdOperativo { get; set; }
        public int tipoLocal { get; set; }

    }
}
