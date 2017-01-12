using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Asignacion
{
    public class FiltroUSPSelAsignacionIIEE
    {
        public int IdProcesoSeleccion { get; set; }
        public int CodigoSedeProvinciaDistrito { get; set; }
        public string CodigoNivel { get; set; }
        public string CodigoGrado { get; set; }
        public int CodigoEvaluacion { get; set; }
        public int CodigoArea { get; set; }
        public int CodigoGestion { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }
        public string OrdenColumna { get; set; }
        public string OrdenDireccion { get; set; }
        public int Pagina { get; set; }
        public int FilasPorPagina { get; set; }
    }
}
