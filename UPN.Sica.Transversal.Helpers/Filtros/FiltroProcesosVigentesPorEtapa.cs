using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public class FiltroProcesosVigentesPorEtapa
    {
        public int Id_Operacion { get; set; }
        public int TipoRol { get; set; }
        public int IdRol { get; set; }
        public int Ambito { get; set; }
        public string NumeroDocumento { get; set; }
        public int TipoDocumento { get; set; }
        public int TipoEtapa { get; set; }
    }
}
