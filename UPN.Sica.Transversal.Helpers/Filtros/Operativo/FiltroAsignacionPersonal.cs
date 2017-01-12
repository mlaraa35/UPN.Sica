using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroAsignacionPersonal : FiltroBaseOperativo
    {
        public int? IdPersonaSede { get; set; }
        public int? IdSede { get; set; }

        public string NombreSedeRegion { get; set; }
        public string NombreSedeProvinciaDistrito { get; set; }
        public int? TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int? IdRol { get; set; }
    }
}
