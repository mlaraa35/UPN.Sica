using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Resultados.Asignacion
{
    public class ItemListaSeccionPorIIEEResponse
    {
        public int IdSeccionSigra { get; set; }
        public int IdInstitucionEducativaSigra { get; set; }
        public string Seccion { get; set; }
        public int CantidadAlumnosProgramados { get; set; }
        public int TotalAplicadores { get; set; }
        public int TotalAcompanantes { get; set; }
    }
}
