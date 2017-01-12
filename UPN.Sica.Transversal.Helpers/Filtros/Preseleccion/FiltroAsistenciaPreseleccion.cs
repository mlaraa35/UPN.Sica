using MED.Sigra.Transversal.Helpers.Filtros.Verificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Preseleccion
{
    public class FiltroAsistenciaPreSeleccion : FiltroVerificacionBase
    {

        public int? IdProcesoSeleccion { get; set; }
        public int? IdSedesPorProcesoSeleccion { get; set; }
        //--------------------------------------------------------//
        public int IdLocalSigra { get; set; }
        public int? IdAulaSigra { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public int? IdPersonalSede { get; set; }
        public int? IdSedeHijo { get; set; }
    }
}
