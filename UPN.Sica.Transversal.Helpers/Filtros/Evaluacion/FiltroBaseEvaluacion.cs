using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Evaluacion
{
    public class FiltroBaseEvaluacion
    { 
        public string UsuarioModificacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public int TipoDocumentoUsuario { get; set; }
        public string NumeroDocumentoUsuario { get; set; } 
        public string Reporte { get; set; }
        public bool EsExcel { get; set; }
    }
} 