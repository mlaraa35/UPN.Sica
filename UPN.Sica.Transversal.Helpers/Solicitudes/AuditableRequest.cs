using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Solicitudes
{
    public class AuditableRequest<T> : Transversal.Helpers.Heredables.EntidadAuditoria
    {
        public T Item {get; set;}
    }
}
