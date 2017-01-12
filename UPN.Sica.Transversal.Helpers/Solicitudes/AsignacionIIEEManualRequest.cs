using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MED.Sigra.Transversal.Helpers.Resultados.Asignacion;
using MED.Sigra.Transversal.Helpers.Filtros.Asignacion;

namespace MED.Sigra.Transversal.Helpers.Solicitudes
{
    public class AsignacionIIEEManualRequest
    {
       public int IdProcesoSeleccion { get; set; }
       public int CodigoSedeProvinciaDistrito { get; set; }
       public int IdInstitucionEducativaSigra { get; set; }
       public string CodigoNivel { get; set; }
       public string CodigoGrado { get; set; }
       public List<ItemListaAplicadoresResponse> Postulantes { get; set;}
       public FiltroPostulantesDisponibles Filtro { get; set; }
    }
}
