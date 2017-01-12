using MED.Comun.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Proceso
{
    public class FiltroSedeProcesoSeleccion
    {
        public int IdProcesoSeleccion { get; set; }
        public int IdSede { get; set; }
        public string CodigoSede { get; set; }
        public string NombreSedeRegion { get; set; }
        public string NombreSedeProvinciaDistrito { get; set; }
        public bool EsExcel { get; set; }
    }
}
