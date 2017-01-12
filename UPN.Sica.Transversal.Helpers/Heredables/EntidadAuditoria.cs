using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Heredables
{
    public abstract class EntidadAuditoria
    {        
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.Nullable<System.DateTime> FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public string IpCreacion { get; set; }
        public string IpModificacion { get; set; }
    }
}
