using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Solicitudes
{
    public class DescargaRequest<T> : Transversal.Helpers.Heredables.EntidadAuditoria
    {
        public string reporte { get; set; }
        public int Formato { get; set; } //xls, xlsx, pdf
        public string data { get; set; } 
        public string NombreArchivo { get; set; } 
        public string NombreReporte { get; set; } 
        public T Parametros { get; set; }

    }

    
}