using MED.Sigra.Transversal.Helpers.Filtros.Verificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Preseleccion
{
    public class FiltroResultadoPreseleccion : FiltroVerificacionBase
    {

        public int? IdProcesoSeleccion { get; set; }
        public int? IdSedesPorProcesoSeleccion { get; set; }
        //--------------------------------------------------------//
        public int? IdLocalSigra { get; set; }
        public int? IdAulaSigra { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string numeroDocumento { get; set; }
        public int? IdPersonalSede { get; set; }
        public int? IdSedeHijo { get; set; }
        public int CodigoSedeRegion { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public string NombreLocal { get; set; }
        public int CAPACIDADLOCAL { get; set; }
        public int DISTRIBUCIONLOCAL { get; set; }
        public int DISPONIBLE { get; set; }
        public string DIRECCION { get; set; }
        public string FECHA_INICIO { get; set; }
        public string FECHA_FIN { get; set; }
        public string HORA_INICIO { get; set; }
        public string HORA_FIN { get; set; }
        public string PendienteNotificar { get; set; }
    }
}
