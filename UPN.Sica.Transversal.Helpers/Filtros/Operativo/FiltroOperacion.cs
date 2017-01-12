using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroOperacion : FiltroBaseOperativo
    {
        public int IdOperacion { get; set; }
        public DateTime? Fecha_Programacion { get; set; }
        //public string UsuarioModificacion { get; set; }
    }
}
