using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Resultados.Asignacion
{
    public class UspSelAsigancionIIEESeccionProcesoResponse
    {
        public int IdInstitucionEducativaSigra { get; set; }
        public int IdSeccionSigra { get; set; }
        public int Tipo { get; set; }
        public int Pendientes { get; set; }
    }
}
