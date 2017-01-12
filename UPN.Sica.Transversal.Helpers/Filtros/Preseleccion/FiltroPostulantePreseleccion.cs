using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Preseleccion
{
    public class FiltroPostulantePreseleccion
    {
        public int IdProcesoSeleccion { get; set; }
        //public int IdSede { get; set; }
        public int? TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string NumeroDocumentoBusqueda { get; set; }
        public int CodigoSedeRegion { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public int IdLocalSigra { get; set; }
        public int IdAulaSigra { get; set; }
        public int IdPostulacion { get; set; }
        public int IdDistribucion { get; set; }
    }
}
