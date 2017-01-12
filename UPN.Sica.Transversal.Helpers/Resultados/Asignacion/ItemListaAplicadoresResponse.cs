using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Resultados.Asignacion
{
    public class ItemListaAplicadoresResponse
    {
        public int IdAsignacion { get; set; }
        public int IdDistribucion { get; set; }
        public string NombreTipoAsignacion { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public string EstadoAsignacion { get; set; }
        public decimal? Promedio { get; set; }
        public int TipoAsignacion { get; set; }
        public int IdSeccionSigra { get; set; }
    }
}
