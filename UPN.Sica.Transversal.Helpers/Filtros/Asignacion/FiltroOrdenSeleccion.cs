using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Asignacion
{
    public class FiltroOrdenSeleccion : FiltroBaseAsignacion
    {
        public int IdProcesoSeleccion { get; set; }
        public int Ambito { get; set; }
        public int CodigoSede { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public int IdDistribucion { get; set; }
    }
}
