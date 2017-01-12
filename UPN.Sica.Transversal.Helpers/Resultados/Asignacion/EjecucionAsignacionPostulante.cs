using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Resultados.Asignacion
{
    public class EjecucionAsignacionPostulante
    {
        public int IdAsignacion { get; set; }
        public int IdDistribucion { get; set; }
        public string NombreCompleto { get; set; }
        public string NumeroDocumento { get; set; }
        public string Asignacion { get; set; }
        public string Seccion { get; set; }
        public string Orden { get; set; }
        public string EstadoFinal { get; set; }
        public int OrdenSeleccion { get; set; }
        public int? IdSeccionSigra { get; set; }
        public int? IdInstitucionEducativaSigra { get; set; }
    }
}
