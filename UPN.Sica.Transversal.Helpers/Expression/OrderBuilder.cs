using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MED.Sigra.Transversal.Helpers
{
    public static class OrderBuilder
    {
        public static Expression<Func<T, object>> GetSortExpression<T>(MED.Comun.Entidades.Base.OrdenamientoBase orden)
        {
            var param = Expression.Parameter(typeof(T), "t");
            var member = Expression.Property(param, orden.Campo);

            Expression conversion = Expression.Convert(member, member.Type);

            // Expression conversion = Expression.Convert(Expression.Property(param, orden.Campo), typeof(object));

            return Expression.Lambda<Func<T, object>>(conversion, param);
        }

    }
}
