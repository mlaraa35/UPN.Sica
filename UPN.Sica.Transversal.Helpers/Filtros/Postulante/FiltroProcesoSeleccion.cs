using MED.Sigra.Transversal.Helpers.Filtros.Verificacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroProcesoSeleccion : FiltroVerificacionBase 
    {
        public int IdProcesoSeleccion { get; set; }
        public int IdOperativo { get; set; }
        public string CodigoProcesoSeleccion { get; set; }
        public string NombreProceso { get; set; }
        public int Cargo { get; set; }
        public int Ambito { get; set; }
        public int EstadoProcesoSeleccion { get; set; }
    }
}
