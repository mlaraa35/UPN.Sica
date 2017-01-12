using MED.Comun.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers.Filtros
{
    public static class FiltroEstado
    {
        public static IList<Filter> Filtrar(List<Filter> filtro)
        {
            if (filtro == null)
                filtro = new List<Filter>();

            // Filtro registros activos logicamente
            filtro.Add(new Filter() { Operation = Op.Equals, PropertyName = "Estado_Registro", Value = true });

            return filtro;
        }
    }
}
