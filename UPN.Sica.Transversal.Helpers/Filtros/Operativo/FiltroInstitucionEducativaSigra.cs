using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroInstitucionEducativaSigra : FiltroBaseOperativo
    {
        public int? IdInstitucionEducativaSigra { get; set; }
        public int? IdCarga { get; set; }
        public int? IdSede { get; set; }
        public int? IdSedeProvinciaDistrito { get; set; }
        public string IdNivel { get; set; }
        public string IdGrado { get; set; }
        public string NombreIe { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }
    }
}
