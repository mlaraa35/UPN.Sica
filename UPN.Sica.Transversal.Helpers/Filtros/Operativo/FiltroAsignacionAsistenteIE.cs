using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros.Operativo
{
    public class FiltroAsignacionAsistenteIE : FiltroBaseOperativo
    {
        //IdOperativo viene de FiltroBaseOperativo
        //IdCarga viene de FiltroBaseOperativo
        public int? IdInstitucionEducativaSigra { get; set; }//PPK
        //--------------------------------------------------------//
        public string CodigoSedePadre { get; set; }
        public string CodigoSedeHijo { get; set; }
        public string IdNivel { get; set; }
        public string IdGrado { get; set; }
        public string CodigoEvaluacion { get; set; }
        public string CodigoArea { get; set; }
        public string CodigoGestion { get; set; }
        public string CodigoModular { get; set; }
        public string Anexo { get; set; }
        public int? IdTipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }

        public int? IdPersonalSede { get; set; }
        public int? IdSedeHijo { get; set; }
        public string TextoNivel { get; set; }
        public string TextoGrado { get; set; }
    }
}
