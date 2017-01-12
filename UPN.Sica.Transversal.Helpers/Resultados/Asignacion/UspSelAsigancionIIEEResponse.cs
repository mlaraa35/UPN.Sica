using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Resultados.Asignacion
{
    public class UspSelAsigancionIIEEResponse
    {
        public int IdInstitucionEducativaSigra { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }
        public string NombreIe { get; set; }
        public string NombreGestion { get; set; }
        public string NombreArea { get; set; }
        public string NombreCodigoEvaluacion { get; set; }
        public int CapacidadAplicador { get; set; }
        public int CapacidadAplicadorLider { get; set; }
        public int TotalSecciones { get; set; }
        public int TotalAlumnos { get; set; }
        public int TotalAsignados { get; set; }
    }
}
