using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Parametro
{
    public class Parametro
    {
        public enum TipoParametro : int
        {
            Cargos = 1,
            ConocimientoInformatico = 2,
            LenguaOriginaria = 3,
            Idioma = 4,
            CodigoEvaluacion = 5,
            EquivalenciaCiclosPorAño = 6,
            CantidadAlumnosParaAsignarAcompañante = 7,
            CantidadAplicadoresPorSeccion = 8
        }
    }
}